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
        Color bg;
        Color oh;

        public void USTraSachSV_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT MaPhieu, dbo.HSPhieuMuon.MaSach, TenSach, SLMuon,NgayMuon,NgayTra, HSPhieuMuon.GhiChu " +
                "FROM dbo.HSPhieuMuon " +
                "INNER JOIN dbo.Sach ON Sach.MaSach = HSPhieuMuon.MaSach " +
                "WHERE dbo.HSPhieuMuon.MSSV = 'SV001'");
            DGV_Sach.DataSource = sach.getBooksCommand(command);
            TextBox_Tre.Enabled = false;
            bg = btnTra.BaseColor;
            oh = btnTra.OnHoverBaseColor;
            btnTra.BaseColor = Color.Black;
            btnTra.OnHoverBaseColor = Color.Black;

        }

        private void DGV_Sach_Click(object sender, EventArgs e)
        {
            TextBox_MaPhieu.Text = DGV_Sach.CurrentRow.Cells[0].Value.ToString();
            TextBox_MaSach.Text = DGV_Sach.CurrentRow.Cells[1].Value.ToString();

            SqlCommand command = new SqlCommand("Select ngaytra from hsphieumuon where MAphieu = '" + TextBox_MaPhieu.Text.Trim() + "'");
            string temp = sach.getBooksCommand(command).Rows[0][0].ToString();
            DateTime ngtra = DateTime.ParseExact(temp, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            TimeSpan Time = DateTime.Now - ngtra;
            int TongSoNgay = Time.Days;
            TextBox_Tre.Text = TongSoNgay.ToString();
        }

        private void btn_Duyet_Click(object sender, EventArgs e)
        {
            if (dieuKienDuyet())
            {
                SqlCommand command = new SqlCommand("SELECT DONGIA FROM SACH WHERE MASACH = '" + TextBox_MaSach.Text.Trim() +"'");
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

            }
        }

        private bool dieuKienDuyet()
        {
            if (TextBox_MaPhieu.Text.Trim() == "" || TextBox_MaSach.Text.Trim() == "" || TextBoxt_SLTra.Text.Trim() =="" ||
                TextBox_SLMat.Text.Trim() == "" || TextBox_SLHong.Text.Trim() == "" || TextBox_Tre.Text.Trim() == "")
            {
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
            if(hieu == 0)
            {
                command = new SqlCommand("delete form hsphieumuon where maphieu = @mp and masach = @ms and mssv = @msv");
                command.Parameters.Add("@mp", SqlDbType.VarChar).Value = TextBox_MaPhieu.Text.Trim();
                command.Parameters.Add("@ms", SqlDbType.VarChar).Value = TextBox_MaSach.Text.Trim();
                command.Parameters.Add("@msv", SqlDbType.VarChar).Value = "SV001";
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
            else if(hieu > 0)
            {
                if (sach.traSachUpdate(hieu,TextBox_MaPhieu.Text.Trim(), "SV001", TextBox_MaSach.Text.Trim()))
                {
                    MessageBox.Show("Trả thành công", "Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Trả không thành công", "Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                USTraSachSV_Load(sender, e);

            }
        }
    }
}
