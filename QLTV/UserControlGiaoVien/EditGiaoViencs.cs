using QLTV.Script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.UserControlGiaoVien
{
    public partial class EditGiaoViencs : UserControl
    {
        public EditGiaoViencs()
        {
            InitializeComponent();
        }
        Teacher sach = new Teacher();
        public void EditGiaoViencs_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select magv, tengv, gioitinhgv,ngaysinhgv, sdtgv, diachigv,avatar from giaovien where magv = @msv");
            command.Parameters.Add("@msv", SqlDbType.VarChar).Value = "GV001";
            DataTable dt = sach.getBooksCommand(command);
            TextBox_mssv.Text = dt.Rows[0][0].ToString();
            TextBox_ten.Text = dt.Rows[0][1].ToString();
            cboGioiTinh.Text = dt.Rows[0][2].ToString();
            dtmNgaySinh.Value = DateTime.ParseExact(dt.Rows[0][3].ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            TextBox_sdt.Text = dt.Rows[0][4].ToString();
            TextBox_diachi.Text = dt.Rows[0][5].ToString();
            if (dt.Rows[0]["avatar"].ToString() == "")
            {

            }
            else
            {
                byte[] pic;
                pic = (byte[])dt.Rows[0]["avatar"];
                MemoryStream picture = new MemoryStream(pic);
                pic_avt.Image = Image.FromStream(picture);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*jpg;*.png;*gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pic_avt.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                SqlCommand command = new SqlCommand("update  giaovien set tengv = @ten, gioitinhgv = @gt,ngaysinhgv = @ns, sdtgv = @sdt, diachigv = @dc,avatar = @av  where magv = @msv");
                command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = TextBox_ten.Text.Trim();
                command.Parameters.Add("@gt", SqlDbType.NVarChar).Value = cboGioiTinh.Text.Trim();
                command.Parameters.Add("@ns", SqlDbType.VarChar).Value = dtmNgaySinh.Text.Trim();
                command.Parameters.Add("@sdt", SqlDbType.Int).Value = Convert.ToInt32(TextBox_sdt.Text.Trim());
                command.Parameters.Add("@dc", SqlDbType.NVarChar).Value = TextBox_diachi.Text.Trim();
                command.Parameters.Add("@msv", SqlDbType.VarChar).Value = "GV001";

                MemoryStream avatar = new MemoryStream();
                pic_avt.Image.Save(avatar, pic_avt.Image.RawFormat);
                command.Parameters.Add("@av", SqlDbType.Image).Value = avatar.ToArray();
                if (sach.getCommandGiaoVien(command))
                {
                    MessageBox.Show("Chỉnh sửa thông tin thành công", "Sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi", "Sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }
        private bool verif()
        {
            if (TextBox_ten.Text.Trim() == ""
                || cboGioiTinh.Text.Trim() == ""
                || TextBox_diachi.Text.Trim() == ""
                || TextBox_sdt.Text.Trim() == ""
                || pic_avt.Image == null)
            {
                return false;
            }
            int born_year = dtmNgaySinh.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("Tuổi Giáo viên Sai", "Sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
