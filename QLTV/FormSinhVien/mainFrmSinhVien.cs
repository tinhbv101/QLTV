using QLTV.Script;
using QLTV.UserControll;
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

namespace QLTV
{
    public partial class mainFrmSinhVien : Form
    {
        public mainFrmSinhVien()
        {
            InitializeComponent();
        }
        Student sinhvien = new Student();
        private void usMuonSach1_Load(object sender, EventArgs e)
        {

        }

        private void btnMuon_Click(object sender, EventArgs e)
        {

            usMuonSachSV1.BringToFront();
            usMuonSachSV1.USMuonSach_Load(sender, e);
        }


        private void btnTra_Click(object sender, EventArgs e)
        {
            usTraSachSV1.BringToFront();
            usTraSachSV1.USTraSachSV_Load(sender, e);
        }

        private void Avatar_Pic_Click(object sender, EventArgs e)
        {
            
        }

        private void mainFrmSinhVien_Load(object sender, EventArgs e)
        {
            Student sach = new Student();
            SqlCommand command = new SqlCommand("Select * from Sinhvien where mssv = @msv");
            command.Parameters.Add("@msv", SqlDbType.VarChar).Value = "SV001";
            DataTable dt = new DataTable();
            dt = sinhvien.getBooksCommand(command);
            label_Name.Text = dt.Rows[0][1].ToString().Trim();

            command = new SqlCommand("Select mssv, tensv, gioitinhsv,ngaysinhsv, sdtsv, diachisv,avatar from sinhvien where mssv = @msv");
            command.Parameters.Add("@msv", SqlDbType.VarChar).Value = "SV001";
            dt = sach.getBooksCommand(command);
            
            if (dt.Rows[0]["avatar"].ToString() == "")
            {
                
            }
            else
            {
                byte[] pic;
                pic = (byte[])dt.Rows[0]["avatar"];
                MemoryStream picture = new MemoryStream(pic);
                Avatar_Pic.Image = Image.FromStream(picture);
            }
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            editSinhVien1.BringToFront();
            editSinhVien1.EditSinhVien_Load(sender, e);
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            changePassword1.BringToFront();
            changePassword1.ChangePassword_Load(sender, e);
        }
    }
}
