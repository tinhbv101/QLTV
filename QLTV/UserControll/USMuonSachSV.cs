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
    public partial class USMuonSachSV : UserControl
    {
        public USMuonSachSV()
        {
            InitializeComponent();
        }
        Student sach = new Student();
        public void USMuonSach_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT dbo.Sach.MaSach AS 'Mã Sách', TenSach AS 'Tên Sách', SLNhap AS 'Số Lượng', ISNULL(Q.SLMuon,0) AS 'Đã Mượn' "
                                                 + " FROM dbo.Sach "
                                                 + " LEFT JOIN( "
                                                 + " SELECT MaSach, SUM(SLMuon) AS SLMuon "
                                                 + " FROM dbo.HSPhieuMuon "
                                                 + " GROUP BY MaSach) AS Q ON Q.MaSach = Sach.MaSach");
            DGV_Sach.DataSource = sach.getBooksCommand(command);
            layMaSach();
            TextBox_MaPhieu.Text = tangMaTuDong();
            TextBox_MaPhieu.Enabled = false;
            TextBox_Search.Text = "";
            TextBoxt_SLMuon.Text = "";
        }

        public string tangMaTuDong()
        {
            SqlCommand command = new SqlCommand("select * from HSPhieuMuon");
            DataTable dt = sach.getBooksCommand(command);
            string maTuDong = "MP";
            int k = dt.Rows.Count + 1;
            if (k < 10)
            {
                maTuDong += "00" + k.ToString();
            }
            else if(k < 100)
            {
                maTuDong += "0" + k.ToString();
            }
            else
            {
                maTuDong += k.ToString();
            }

            return maTuDong;
        }


        public void layMaSach()
        {
            SqlCommand comLayMaDG = new SqlCommand("select * from Sach");
            cboMaSach.DataSource = sach.getBooksCommand(comLayMaDG);
            cboMaSach.DisplayMember = "MaSach";
            cboMaSach.ValueMember = "MaSach";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            SqlCommand command;
            if (rdoMaSach.Checked)
            {
                command = new SqlCommand("SELECT dbo.Sach.MaSach AS 'Mã Sách', TenSach AS 'Tên Sách', SLNhap AS 'Số Lượng', ISNULL(Q.SLMuon,0) AS 'Đã Mượn' "
                                     + " FROM dbo.Sach "
                                     + " LEFT JOIN( "
                                     + " SELECT MaSach, SUM(SLMuon) AS SLMuon "
                                     + " FROM dbo.HSPhieuMuon "
                                     + " GROUP BY MaSach) AS Q ON Q.MaSach = Sach.MaSach" +
                                     " where dbo.Sach.MaSach like '%" + TextBox_Search.Text.Trim() + "%'");
            }
            else
            {
                command = new SqlCommand("SELECT dbo.Sach.MaSach AS 'Mã Sách', TenSach AS 'Tên Sách', SLNhap AS 'Số Lượng', ISNULL(Q.SLMuon,0) AS 'Đã Mượn' "
                                    + " FROM dbo.Sach "
                                    + " LEFT JOIN( "
                                    + " SELECT MaSach, SUM(SLMuon) AS SLMuon "
                                    + " FROM dbo.HSPhieuMuon "
                                    + " GROUP BY MaSach) AS Q ON Q.MaSach = Sach.MaSach" +
                                    " where TenSach like N'%" + TextBox_Search.Text.Trim() + "%'");
            }
            DGV_Sach.DataSource = sach.getBooksCommand(command);
        }

        private void DGV_Sach_Click(object sender, EventArgs e)
        {
            cboMaSach.Text = DGV_Sach.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            if(dieuKienMuon())
            {
                string maphieu = TextBox_MaPhieu.Text;
                string mssv = "SV001";
                string masach = cboMaSach.Text;
                string ngaymuon = DateTime.Now.ToString("dd/MM/yyyy");
                string ngaytra = dtmNgayTra.Value.ToString("dd/MM/yyyy");
                int sl = Convert.ToInt32(TextBoxt_SLMuon.Text);
                string tt = cboTinhTrang.Text;
                string ghichu = TextBoxt_GhiChu.Text;
                if (sach.muonSach(maphieu, mssv, masach, ngaymuon, ngaytra, sl, tt, ghichu))
                {
                    MessageBox.Show("Mượn thành công", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Mượn không thành công", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            USMuonSach_Load(sender, e);
        }

        private bool dieuKienMuon()
        {
            try
            {
                if (TextBoxt_GhiChu.Text == "" || TextBoxt_SLMuon.Text == "" || cboTinhTrang.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                for (int i = 0; i < DGV_Sach.Rows.Count - 1; i++)
                {
                    if (DGV_Sach.Rows[i].Cells[0].Value.ToString().Trim() == cboMaSach.Text.Trim())
                    {
                        int tongsach = int.Parse(DGV_Sach.Rows[i].Cells[2].Value.ToString());
                        int sachdamuon = int.Parse(DGV_Sach.Rows[i].Cells[3].Value.ToString());
                        int sl = int.Parse(TextBoxt_SLMuon.Text.ToString().Trim());
                        if (tongsach < sachdamuon + sl)
                        {
                            MessageBox.Show("Vui lòng nhập đúng số lượng", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Nhập sai số lượng", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

    }
}
