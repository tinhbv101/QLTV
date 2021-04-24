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
        public string mssv;
        public mainFrmSinhVien(string msv)
        {
            mssv = msv;
            InitializeComponent();
            changePassword1.Visible = false;
            editSinhVien1.Visible = false;
            usMuonSachSV1.Visible = false;
            usTraSachSV1.Visible = false;

        }
        Student sinhvien = new Student();
        private void usMuonSach1_Load(object sender, EventArgs e)
        {
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            usMuonSachSV1.Visible = true;
            usMuonSachSV1.BringToFront();
            usMuonSachSV1.USMuonSach_Load(sender, e);
            mainFrmSinhVien_Load(sender, e);
        }


        private void btnTra_Click(object sender, EventArgs e)
        {
            usTraSachSV1.Visible = true;
            usTraSachSV1.BringToFront();
            usTraSachSV1.USTraSachSV_Load(sender, e);
            mainFrmSinhVien_Load(sender, e);

        }

        private void Avatar_Pic_Click(object sender, EventArgs e)
        {
            
        }

        private void mainFrmSinhVien_Load(object sender, EventArgs e)
        {


            changePassword1.mssv = mssv;
            editSinhVien1.mssv = mssv;
            usMuonSachSV1.mssv = mssv;
            usTraSachSV1.mssv = mssv;


            Student sach = new Student();


            //LẤY TÊN
            //LẤY SỐ DƯ
            SqlCommand command = new SqlCommand("Select * from Sinhvien where mssv = @msv");
            command.Parameters.Add("@msv", SqlDbType.VarChar).Value = mssv;
            DataTable dt = new DataTable();
            dt = sinhvien.getBooksCommand(command);
            label_Name.Text = dt.Rows[0][1].ToString().Trim();
            labelSodu.Text = "Số dư: " + dt.Rows[0][11].ToString() + "đ";



            //LẤY TỔNG SỐ PHIẾU ĐANG MƯỢN
            command = new SqlCommand("Select count(maphieu) from hsphieumuon where ms = @msv");
            command.Parameters.Add("@msv", SqlDbType.VarChar).Value = mssv;
            dt = sach.getBooksCommand(command);
            labelDangMuon.Text = "Đang mượn: " + dt.Rows[0][0].ToString();

            //TÍNH TỔNG PHIẾU MƯỢN TRỄ HẠN
            command = new SqlCommand("Select ngaytra from hsphieumuon where ms = @msv");
            command.Parameters.Add("@msv", SqlDbType.VarChar).Value = mssv;
            dt = sach.getBooksCommand(command);
            int sosachtre = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string temp = dt.Rows[i][0].ToString();
                DateTime ngtra = DateTime.ParseExact(temp, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                int res = DateTime.Compare(DateTime.Now, ngtra);
                if (res > 0)
                {
                    sosachtre++;
                }

            }
            labelHetHang.Text = "Trễ hạn: " + sosachtre.ToString();

            //LẤY AVATAR
            command = new SqlCommand("Select mssv, tensv, gioitinhsv,ngaysinhsv, sdtsv, diachisv,avatar from sinhvien where mssv = @msv");
            command.Parameters.Add("@msv", SqlDbType.VarChar).Value = mssv;
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
            editSinhVien1.Visible = true;
            editSinhVien1.BringToFront();
            editSinhVien1.EditSinhVien_Load(sender, e);
            mainFrmSinhVien_Load(sender, e);

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            changePassword1.Visible = true;
            changePassword1.BringToFront();
            changePassword1.ChangePassword_Load(sender, e);
            mainFrmSinhVien_Load(sender, e);

        }
    }
}
