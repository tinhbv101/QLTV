using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.UserControll
{
    public partial class ChangePassword : UserControl
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        public void ChangePassword_Load(object sender, EventArgs e)
        {
            TextBox_MKCu.Text = "";
            TextBox_MKMoi.Text = "";
            TextBox_NhapLai.Text = "";
            CheckBox_HienThiMK.Checked = false;
            TextBox_MKCu.UseSystemPasswordChar = false;
            TextBox_MKMoi.UseSystemPasswordChar = false;
            TextBox_NhapLai.UseSystemPasswordChar = false;
        }

        private void CheckBox_HienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_HienThiMK.Checked)
            {
                TextBox_MKCu.UseSystemPasswordChar = true;
                TextBox_MKMoi.UseSystemPasswordChar = true;
                TextBox_NhapLai.UseSystemPasswordChar = true;
            }
            else 
            {
                TextBox_MKCu.UseSystemPasswordChar = false;
                TextBox_MKMoi.UseSystemPasswordChar = false;
                TextBox_NhapLai.UseSystemPasswordChar = false;
            }
        }
    }
}
