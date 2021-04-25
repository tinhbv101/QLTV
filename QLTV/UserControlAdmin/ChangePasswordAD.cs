using QLTV.Script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.UserControlAdmin
{
    public partial class ChangePasswordAD : UserControl
    {
        public string maad;
        public ChangePasswordAD()
        {
            InitializeComponent();
        }
        Admin admin = new Admin();
        private void CheckBox_HienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_HienThiMK.Checked)
            {
                TextBox_MKCu.UseSystemPasswordChar = false;
                TextBox_MKMoi.UseSystemPasswordChar = false;
                TextBox_NhapLai.UseSystemPasswordChar = false;
            }
            else
            {

                TextBox_MKCu.UseSystemPasswordChar = true;
                TextBox_MKMoi.UseSystemPasswordChar = true;
                TextBox_NhapLai.UseSystemPasswordChar = true;
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                if (admin.changePassword(maad, TextBox_MKCu.Text, TextBox_MKMoi.Text))
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChangePasswordAD_Load(sender, e);
                }
            }
        }
        private bool verif()
        {
            if (TextBox_MKCu.Text.Trim() == ""
                || TextBox_MKMoi.Text.Trim() == ""
                || TextBox_NhapLai.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (TextBox_MKMoi.Text != TextBox_NhapLai.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public void ChangePasswordAD_Load(object sender, EventArgs e)
        {
            TextBox_MKCu.Text = "";
            TextBox_MKMoi.Text = "";
            TextBox_NhapLai.Text = "";
            CheckBox_HienThiMK.Checked = false;
            TextBox_MKCu.UseSystemPasswordChar = true;
            TextBox_MKMoi.UseSystemPasswordChar = true;
            TextBox_NhapLai.UseSystemPasswordChar = true;
        }
    }
}
