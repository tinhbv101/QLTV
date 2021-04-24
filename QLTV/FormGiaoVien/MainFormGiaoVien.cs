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

namespace QLTV.FormGiaoVien
{
    public partial class MainFormGiaoVien : Form
    {
        string magv;
        public MainFormGiaoVien(string mgv)
        {
            magv = mgv;
            InitializeComponent();
            changePasswordGV1.Visible = false;
            editGiaoViencs1.Visible = false;
            usTraSachGV1.Visible = false;
            usMuonSachGV1.Visible = false;
            usChoMuonSach1.Visible = false;

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            changePasswordGV1.magv = magv;
            changePasswordGV1.Visible = true;
            changePasswordGV1.BringToFront();
            changePasswordGV1.ChangePasswordGV_Load(sender, e);
            MainFormGiaoVien_Load(sender, e);
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            editGiaoViencs1.magv = magv;
            editGiaoViencs1.Visible = true;
            editGiaoViencs1.BringToFront();
            editGiaoViencs1.EditGiaoViencs_Load(sender, e);
            MainFormGiaoVien_Load(sender, e);

        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            usMuonSachGV1.magv = magv;
            usMuonSachGV1.Visible = true;
            usMuonSachGV1.BringToFront();
            usMuonSachGV1.USMuonSachGV_Load(sender, e);
            MainFormGiaoVien_Load(sender, e);

        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            usTraSachGV1.magv = magv;
            usTraSachGV1.Visible = true;
            usTraSachGV1.BringToFront();
            usTraSachGV1.USTraSachGV_Load(sender, e);
            MainFormGiaoVien_Load(sender, e);

        }

        private void MainFormGiaoVien_Load(object sender, EventArgs e)
        {
            
            Teacher sach = new Teacher();
            
            //LẤY TÊN
            //LẤY SỐ DƯ
            SqlCommand command = new SqlCommand("Select * from giaovien where magv = @msv");
            command.Parameters.Add("@msv", SqlDbType.VarChar).Value = magv;
            DataTable dt = new DataTable(); 
            dt = sach.getBooksCommand(command);
            label_Name.Text = dt.Rows[0][1].ToString().Trim();
            labelSodu.Text = "Số dư: " + dt.Rows[0][11].ToString() + "đ";


            //LẤY TỔNG SỐ PHIẾU ĐANG MƯỢN
            command = new SqlCommand("Select count(maphieu) from hsphieumuon where ms = @msv");
            command.Parameters.Add("@msv", SqlDbType.VarChar).Value = magv;
            dt = sach.getBooksCommand(command);
            labelDangMuon.Text = "Đang mượn: " + dt.Rows[0][0].ToString();

            //TÍNH TỔNG PHIẾU MƯỢN TRỄ HẠN
            command = new SqlCommand("Select ngaytra from hsphieumuon where ms = @msv");
            command.Parameters.Add("@msv", SqlDbType.VarChar).Value = magv;
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
            command = new SqlCommand("Select magv, tengv, gioitinhgv,ngaysinhgv, sdtgv, diachigv,avatar from giaovien where magv = @msv");
            command.Parameters.Add("@msv", SqlDbType.VarChar).Value = magv;
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

        private void btn_choMuon_Click(object sender, EventArgs e)
        {
            usChoMuonSach1.magv = magv;
            usChoMuonSach1.Visible = true;
            usChoMuonSach1.BringToFront();
            usChoMuonSach1.USChoMuonSach_Load(sender, e);
            MainFormGiaoVien_Load(sender, e);
        }

        private void usTraSachGV1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
