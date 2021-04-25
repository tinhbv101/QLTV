using DoAnThuVien;
using QLTV.FormGiaoVien;
using QLTV.Script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            MainFormGiaoVien mainFormGiaoVien = new MainFormGiaoVien("GV001");
            mainFormGiaoVien.Show();
            */
            mainFrmSinhVien mainFrmSinhVien = new mainFrmSinhVien("SV001");
            mainFrmSinhVien.Show();
        }


        private void TextBox_Username_Enter(object sender, EventArgs e)
        {
            if (TextBox_Username.Text == "Username")
            {
                TextBox_Username.Text = "";
            }
        }

        private void TextBox_Username_Leave(object sender, EventArgs e)
        {
            if (TextBox_Username.Text == "")
            {
                TextBox_Username.Text = "Username";
            }
        }

        private void TextBox_Password_Leave(object sender, EventArgs e)
        {
            if (TextBox_Password.Text == "")
            {
                TextBox_Password.UseSystemPasswordChar = false;
                TextBox_Password.Text = "Password";
            }
        }

        private void TextBox_Password_Enter(object sender, EventArgs e)
        {
            if (TextBox_Password.Text == "Password")
            {
                TextBox_Password.UseSystemPasswordChar = true;
                TextBox_Password.Text = "";
            }
        }

        private void TextBox_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLinkLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            myDB mydb = new myDB();
            if (rdoSinhVien.Checked)
            {
                SqlCommand command = new SqlCommand("select * from sinhvien where tentaikhoansv = @tk and matkhausv = @mk", mydb.getConnection);
                command.Parameters.Add("@tk", SqlDbType.VarChar).Value = TextBox_Username.Text;
                command.Parameters.Add("@mk", SqlDbType.VarChar).Value = TextBox_Password.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    
                    mainFrmSinhVien mainSV = new mainFrmSinhVien(dt.Rows[0][0].ToString());
                    Visible = false;
                    mainSV.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Sai Tài khoản hoặc Mật khẩu", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rdoGiaoVien.Checked)
            {
                SqlCommand command = new SqlCommand("select * from giaovien where tentaikhoangv = @tk and matkhaugv = @mk", mydb.getConnection);
                command.Parameters.Add("@tk", SqlDbType.VarChar).Value = TextBox_Username.Text;
                command.Parameters.Add("@mk", SqlDbType.VarChar).Value = TextBox_Password.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    MainFormGiaoVien mainSV = new MainFormGiaoVien(dt.Rows[0][0].ToString());
                    Visible = false;
                    mainSV.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Sai Tài khoản hoặc Mật khẩu", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }
        }

        private void CheckBox_HienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_HienThiMK.Checked)
            {
                TextBox_Password.UseSystemPasswordChar = false;
            }
            else if(TextBox_Password.Text != "Password")
            {
                TextBox_Password.UseSystemPasswordChar = true;
            }
        }
    }
}
