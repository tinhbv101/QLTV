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

namespace QLTV.UserControll
{
    public partial class USTraSachSV : UserControl
    {
        public USTraSachSV()
        {
            InitializeComponent();
        }
        Student sach = new Student();
        Color bg = Color.FromArgb(100, 88, 255);
        Color oh = Color.FromArgb(151, 143, 255);

        public void USTraSachSV_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT MaPhieu as 'Mã phiếu', dbo.HSPhieuMuon.MaSach as 'Mã sách', TenSach as 'Tên sách', SLMuon 'SL Mượn',NgayMuon as 'Ngày mượn',NgayTra as 'Ngày trả', HSPhieuMuon.GhiChu as 'Ghi chú'" +
                "FROM dbo.HSPhieuMuon " +
                "INNER JOIN dbo.Sach ON Sach.MaSach = HSPhieuMuon.MaSach " +
                "WHERE dbo.HSPhieuMuon.MS = 'SV001'");
            DGV_Sach.DataSource = sach.getBooksCommand(command);
            TextBox_Tre.Enabled = false;
            btnTra.Enabled = false;
            btnTra.BaseColor = Color.Black;
            btnTra.OnHoverBaseColor = Color.Black;
            btn_Duyet.Enabled = true;
            btn_Duyet.BaseColor = bg;
            btn_Duyet.OnHoverBaseColor = oh;
            TextBox_MaPhieu.Enabled = true;
            TextBox_MaSach.Enabled = true;
            TextBoxt_SLTra.Enabled = true;
            TextBox_SLMat.Enabled = true;
            TextBox_SLHong.Enabled = true;
            TextBox_MaPhieu.Text = "";
            TextBox_MaSach.Text = "";
            TextBoxt_SLTra.Text = "";
            TextBox_SLMat.Text = "";
            TextBox_SLHong.Text = "";
            TextBox_Tre.Text = "";
            labelDenBu.Text = "0";
        }

        private void DGV_Sach_Click(object sender, EventArgs e)
        {
            TextBox_MaPhieu.Text = DGV_Sach.CurrentRow.Cells[0].Value.ToString();
            TextBox_MaSach.Text = DGV_Sach.CurrentRow.Cells[1].Value.ToString();

        }

        private void btn_Duyet_Click(object sender, EventArgs e)
        {
            if (dieuKienDuyet())
            {
                SqlCommand command = new SqlCommand("Select ngaytra from hsphieumuon where MAphieu = '" + TextBox_MaPhieu.Text.Trim() + "'");
                string temp = sach.getBooksCommand(command).Rows[0][0].ToString();
                DateTime ngtra = DateTime.ParseExact(temp, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                TimeSpan Time = DateTime.Now - ngtra;
                int TongSoNgay = Time.Days;
                TextBox_Tre.Text = TongSoNgay.ToString();
                command = new SqlCommand("SELECT DONGIA FROM SACH WHERE MASACH = '" + TextBox_MaSach.Text.Trim() +"'");
                DataTable dt = sach.getBooksCommand(command);
                int giasach = Convert.ToInt32(dt.Rows[0][0].ToString());
                int slm = Convert.ToInt32(TextBox_SLMat.Text.Trim());
                int slh = Convert.ToInt32(TextBox_SLHong.Text.Trim());
                int snt = Convert.ToInt32(TextBox_Tre.Text.Trim());
                int tongtien = slm * giasach + slh * 2000 + snt * 1000;
                labelDenBu.Text = tongtien.ToString() + "đ";
                btnTra.BaseColor = bg;
                btnTra.OnHoverBaseColor = oh;
                btnTra.Enabled = true;
                btn_Duyet.BaseColor = Color.Black;
                btn_Duyet.OnHoverBaseColor = Color.Black;
                btn_Duyet.Enabled = false;
                TextBox_MaPhieu.Enabled = false;
                TextBox_MaSach.Enabled = false;
                TextBoxt_SLTra.Enabled = false;
                TextBox_SLMat.Enabled = false;
                TextBox_SLHong.Enabled = false;

            }
        }

        private bool dieuKienDuyet()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM hsphieumuon WHERE MAphieu = '" + TextBox_MaPhieu.Text.Trim() + "' and MAsach= '" + TextBox_MaSach.Text.Trim() + "'");
            DataTable dt = sach.getBooksCommand(command);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Sai mã sách hoặc mã phiếu", "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            } 
            if (TextBox_MaPhieu.Text.Trim() == "" || TextBox_MaSach.Text.Trim() == "" || TextBoxt_SLTra.Text.Trim() =="" ||
                TextBox_SLMat.Text.Trim() == "" || TextBox_SLHong.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống", "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            int tongtra = Convert.ToInt32(TextBoxt_SLTra.Text.Trim());
            int tongmat = Convert.ToInt32(TextBox_SLMat.Text.Trim());
            int tonghong = Convert.ToInt32(TextBox_SLHong.Text.Trim());
            if(tongtra < tongmat + tonghong)
            {
                MessageBox.Show("Nhập sai số sách hỏng, số sách mất", "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            command = new SqlCommand("Select SLMUON from hsphieumuon where MAphieu = '" + TextBox_MaPhieu.Text.Trim() + "'");
            dt = sach.getBooksCommand(command);
            int tongMuon = Convert.ToInt32(dt.Rows[0][0].ToString());
            int tongTra = Convert.ToInt32(TextBoxt_SLTra.Text.ToString().Trim());
            int hieu = tongMuon - tongTra;
            if(hieu < 0)
            {
                MessageBox.Show("Nhập số lượng trả sai", "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            return true;
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            
            SqlCommand command = new SqlCommand("Select SLMUON from hsphieumuon where MAphieu = '" + TextBox_MaPhieu.Text.Trim() + "'");
            DataTable dt = sach.getBooksCommand(command);
            int tongMuon = Convert.ToInt32(dt.Rows[0][0].ToString());
            int tongTra = Convert.ToInt32(TextBoxt_SLTra.Text.ToString().Trim());
            int hieu = tongMuon - tongTra;

            //xem số dư tk
            command = new SqlCommand("Select * from sinhvien where mssv = @msv");
            command.Parameters.Add("@msv", SqlDbType.VarChar).Value = "SV001";
            dt = new DataTable();
            dt = sach.getBooksCommand(command);
            int sodu = Convert.ToInt32(dt.Rows[0][11].ToString());



            if (hieu == 0)
            {
                //tính tổng tiền  cần thanh toán
                command = new SqlCommand("SELECT DONGIA FROM SACH WHERE MASACH = '" + TextBox_MaSach.Text.Trim() + "'");
                dt = sach.getBooksCommand(command);
                int giasach = Convert.ToInt32(dt.Rows[0][0].ToString());
                int slm = Convert.ToInt32(TextBox_SLMat.Text.Trim());
                int slh = Convert.ToInt32(TextBox_SLHong.Text.Trim());
                int snt = Convert.ToInt32(TextBox_Tre.Text.Trim());
                int tongtien = slm * giasach + slh * 2000 + snt * 1000;

                if (sodu < tongtien)
                {
                    MessageBox.Show("Tài khoản không đủ vui lòng nạp thêm", "Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    sodu = sodu - tongtien;
                    command = new SqlCommand("update sinhvien set sodu = @sd where mssv = @msv");
                    command.Parameters.Add("@sd", SqlDbType.Int).Value = sodu;
                    command.Parameters.Add("@msv", SqlDbType.VarChar).Value = "SV001";

                    if (sach.getCommandSinhVien(command))//update so du
                    {
                        if (sach.traSachALL(TextBox_MaPhieu.Text.Trim(), "SV001", TextBox_MaSach.Text.Trim()))
                        {
                            MessageBox.Show("Trả thành công", "Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Trả không thành công", "Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        USTraSachSV_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi thanh toán", "Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
            else if(hieu > 0)
            {

                //tính tổng tiền  cần thanh toán
                command = new SqlCommand("SELECT DONGIA FROM SACH WHERE MASACH = '" + TextBox_MaSach.Text.Trim() + "'");
                dt = sach.getBooksCommand(command);
                int giasach = Convert.ToInt32(dt.Rows[0][0].ToString());
                int slm = Convert.ToInt32(TextBox_SLMat.Text.Trim());
                int slh = Convert.ToInt32(TextBox_SLHong.Text.Trim());
                int snt = Convert.ToInt32(TextBox_Tre.Text.Trim());
                int tongtien = slm * giasach + slh * 2000 + snt * 1000;


                if (sodu < tongtien)
                {
                    MessageBox.Show("Tài khoản không đủ vui lòng nạp thêm", "Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    sodu = sodu - tongtien;
                    command = new SqlCommand("update sinhvien set sodu = @sd where mssv = @mgv");
                    command.Parameters.Add("@sd", SqlDbType.Int).Value = sodu;
                    command.Parameters.Add("@mgv", SqlDbType.VarChar).Value = "SV001";

                    if (sach.getCommandSinhVien(command))//update so du
                    {
                        if (sach.traSachUpdate(hieu, TextBox_MaPhieu.Text.Trim(), "SV001", TextBox_MaSach.Text.Trim()))
                        {
                            MessageBox.Show("Trả thành công", "Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Trả không thành công", "Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        USTraSachSV_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi thanh toán", "Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập lỗi", "Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SqlCommand command;
            if (rdoMaSach.Checked)
            {
                command = new SqlCommand("SELECT MaPhieu as 'Mã phiếu', dbo.HSPhieuMuon.MaSach as 'Mã sách', TenSach as 'Tên sách', SLMuon 'SL Mượn',NgayMuon as 'Ngày mượn',NgayTra as 'Ngày trả', HSPhieuMuon.GhiChu as 'Ghi chú'" +
                                        "FROM dbo.HSPhieuMuon " +
                                        "INNER JOIN dbo.Sach ON Sach.MaSach = HSPhieuMuon.MaSach " +
                                        "WHERE dbo.HSPhieuMuon.MS = 'SV001'" +
                                        " and dbo.Sach.MaSach like '%" + TextBox_Search.Text.Trim() + "%'");
            }
            else
            {
                command = new SqlCommand("SELECT MaPhieu as 'Mã phiếu', dbo.HSPhieuMuon.MaSach as 'Mã sách', TenSach as 'Tên sách', SLMuon 'SL Mượn',NgayMuon as 'Ngày mượn',NgayTra as 'Ngày trả', HSPhieuMuon.GhiChu as 'Ghi chú'" +
                                        "FROM dbo.HSPhieuMuon " +
                                        "INNER JOIN dbo.Sach ON Sach.MaSach = HSPhieuMuon.MaSach " +
                                        "WHERE dbo.HSPhieuMuon.MS = 'SV001'" +
                                        " and dbo.HSPhieuMuon.MaPhieu like '%" + TextBox_Search.Text.Trim() + "%'");
            }
            DGV_Sach.DataSource = sach.getBooksCommand(command);
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
