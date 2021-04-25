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

namespace QLTV.UserControlAdmin
{
    public partial class USQuanLyMuonTra : UserControl
    {
        int flag;
        public USQuanLyMuonTra()
        {
            InitializeComponent();
        }

        private void gunaContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        Admin admin = new Admin();

        public void USQuanLyMuonTra_Load(object sender, EventArgs e)
        {
            flag = 0;
            SqlCommand command = new SqlCommand("Select maphieu as 'Mã phiếu',masach as 'Mã sách', ms as 'Người mượn', ngaymuon as 'Ngày mượn', ngaytra as 'Ngày trả', slmuon as 'SL mượn', tinhtrang as 'Tình trạng', ghichu as 'Ghi chú' from hsphieumuon");
            admin.getBooksCommand(command);
            DGV_Sach.DataSource = admin.getBooksCommand(command);
            rdoMaPhieu.Checked = true;
            onlyReadBox();
            setComboBox();
            setNULL();
            setButton();
            DGV_Sach.Enabled = true;
            label_Log.Text = "";
            dtmNgayMuon.MinDate = DateTime.ParseExact("01/01/1900", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            dtmNgayTra.MinDate = DateTime.ParseExact("01/01/1900", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
        }


        void onlyReadBox()
        {
            TextBox_MaPhieu.Enabled = false;
            cboMaSach.Enabled = false;
            cboMaNguoiMuon.Enabled = false;
            TextBox_SL.Enabled = false;
            dtmNgayMuon.Enabled = false;
            dtmNgayTra.Enabled = false;
            cboTinhTrang.Enabled = false;
            TextBox_GhiChu.Enabled = false;
        }

        void EnableEditBox()
        {
            cboMaSach.Enabled = true;
            cboMaNguoiMuon.Enabled = true;
            TextBox_SL.Enabled = true;
            dtmNgayMuon.Enabled = true;
            dtmNgayTra.Enabled = true;
            cboTinhTrang.Enabled = true;
            TextBox_GhiChu.Enabled = true;
        }


        void setComboBox()
        {
            SqlCommand command = new SqlCommand("Select masach from sach");
            cboMaSach.DataSource = admin.getBooksCommand(command);
            cboMaSach.DisplayMember = "masach";
            cboMaSach.ValueMember = "masach";
            command = new SqlCommand("SELECT MaGV FROM dbo.GiaoVien UNION SELECT MSSV FROM dbo.SinhVien");
            cboMaNguoiMuon.DataSource = admin.getBooksCommand(command);
            cboMaNguoiMuon.DisplayMember = "MaGV";
            cboMaNguoiMuon.ValueMember = "MaGV";
        }

        void setNULL()
        {
            TextBox_Search.Text = "";
            TextBox_SL.Text = "";
            dtmNgayMuon.Value = DateTime.Now;
            dtmNgayTra.Value = DateTime.Now;
            cboTinhTrang.Text = "Mới";
            TextBox_GhiChu.Text = "";

        }


        void setButton()
        {
            btnMuon.Enabled = true;
            btnTra.Enabled = false;
            btnGiaHan.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void TextBox_Search_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command;
            if (rdoMaPhieu.Checked)
            {
                command = new SqlCommand("Select maphieu as 'Mã phiếu',masach as 'Mã sách', ms as 'Người mượn', ngaymuon as 'Ngày mượn', ngaytra as 'Ngày trả', slmuon as 'SL mượn', tinhtrang as 'Tình trạng', ghichu as 'Ghi chú' from hsphieumuon where maphieu like '%"+TextBox_Search.Text+"%'");
                admin.getBooksCommand(command);
                DGV_Sach.DataSource = admin.getBooksCommand(command);
            }
            else if (rboMaSach.Checked)
            {
                command = new SqlCommand("Select maphieu as 'Mã phiếu',masach as 'Mã sách', ms as 'Người mượn', ngaymuon as 'Ngày mượn', ngaytra as 'Ngày trả', slmuon as 'SL mượn', tinhtrang as 'Tình trạng', ghichu as 'Ghi chú' from hsphieumuon where masach like '%" + TextBox_Search.Text + "%'");
                admin.getBooksCommand(command);
                DGV_Sach.DataSource = admin.getBooksCommand(command);
            }
            else
            {
                command = new SqlCommand("Select maphieu as 'Mã phiếu',masach as 'Mã sách', ms as 'Người mượn', ngaymuon as 'Ngày mượn', ngaytra as 'Ngày trả', slmuon as 'SL mượn', tinhtrang as 'Tình trạng', ghichu as 'Ghi chú' from hsphieumuon where ms like '%" + TextBox_Search.Text + "%'");
                admin.getBooksCommand(command);
                DGV_Sach.DataSource = admin.getBooksCommand(command);
            }
        }

        private void DGV_Sach_Click(object sender, EventArgs e)
        {
            if (DGV_Sach.CurrentRow.Index +1 != DGV_Sach.Rows.Count)
            {
                btnTra.Enabled = true;
                btnGiaHan.Enabled = true;
                TextBox_MaPhieu.Text = DGV_Sach.CurrentRow.Cells[0].Value.ToString();
                cboMaSach.Text = DGV_Sach.CurrentRow.Cells[1].Value.ToString();
                cboMaNguoiMuon.Text = DGV_Sach.CurrentRow.Cells[2].Value.ToString();
                dtmNgayMuon.Value = DateTime.ParseExact(DGV_Sach.CurrentRow.Cells[3].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                dtmNgayTra.Value = DateTime.ParseExact(DGV_Sach.CurrentRow.Cells[4].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                TextBox_SL.Text = DGV_Sach.CurrentRow.Cells[5].Value.ToString();
                cboTinhTrang.Text = DGV_Sach.CurrentRow.Cells[6].Value.ToString();
                TextBox_GhiChu.Text = DGV_Sach.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            label_Log.Text = "Nhập thông tin phía trên!";
            btnMuon.Enabled = false;
            btnTra.Enabled = false;
            btnGiaHan.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            DGV_Sach.Enabled = false;
            EnableEditBox();
            dtmNgayMuon.Enabled = false;
            dtmNgayMuon.Value = DateTime.Now;
            dtmNgayTra.MinDate = DateTime.Now;
            flag = 1;
            tangMaTuDong();
        }

        public void tangMaTuDong()
        {
            SqlCommand command = new SqlCommand("select Max(maphieu) from HSPhieuMuon");
            DataTable dt = admin.getBooksCommand(command);
            string maphieu = dt.Rows[0][0].ToString();
            maphieu = maphieu.Replace("MP", "");
            int sophieu = Convert.ToInt32(maphieu);
            string maTuDong = "MP";
            int k = sophieu + 1;
            if (k < 10)
            {
                maTuDong += "00" + k.ToString();
            }
            else if (k < 100)
            {
                maTuDong += "0" + k.ToString();
            }
            else
            {
                maTuDong += k.ToString();
            }

            TextBox_MaPhieu.Text = maTuDong;
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            label_Log.Text = "Nhập số lượng!";
            btnMuon.Enabled = false;
            btnTra.Enabled = false;
            btnGiaHan.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            DGV_Sach.Enabled = false;
            onlyReadBox();
            TextBox_SL.Enabled = true;
            flag = 2;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            label_Log.Text = "Nhập ngày trả!";
            btnMuon.Enabled = false;
            btnTra.Enabled = false;
            btnGiaHan.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            DGV_Sach.Enabled = false;
            onlyReadBox();
            dtmNgayTra.Enabled = true;
            flag = 3;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            USQuanLyMuonTra_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                if (verifThem())
                {
                    SqlCommand command = new SqlCommand("insert into hsphieumuon values (@mp, @mso, @msa,@nm,@nt,@sl,@tt,@gc)");
                    command.Parameters.Add("@mp", SqlDbType.VarChar).Value = TextBox_MaPhieu.Text.Trim();
                    command.Parameters.Add("@mso", SqlDbType.VarChar).Value = cboMaNguoiMuon.Text;
                    command.Parameters.Add("@msa", SqlDbType.VarChar).Value = cboMaSach.Text;
                    command.Parameters.Add("@nm", SqlDbType.NVarChar).Value = dtmNgayMuon.Text;
                    command.Parameters.Add("@nt", SqlDbType.NVarChar).Value = dtmNgayTra.Text;
                    command.Parameters.Add("@sl", SqlDbType.Int).Value = Convert.ToInt32(TextBox_SL.Text.Trim());
                    command.Parameters.Add("@tt", SqlDbType.NVarChar).Value = cboTinhTrang.Text;
                    command.Parameters.Add("@gc", SqlDbType.NVarChar).Value = TextBox_GhiChu.Text.Trim();
                    if (admin.getCommandAdmin(command))
                    {
                        MessageBox.Show("Cho mượn thành công", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        USQuanLyMuonTra_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Cho mượn sách không thành công", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else if (flag == 2)
            {
                if (isNum(TextBox_SL.Text))
                {
                    int sltra = Convert.ToInt32(TextBox_SL.Text.Trim());
                    int slmuon = Convert.ToInt32(DGV_Sach.CurrentRow.Cells[1].Value.ToString().Trim());
                }
            }
        }

        bool verifThem()
        {
            if(!isNum(TextBox_SL.Text.Trim()) || TextBox_GhiChu.Text == "")
            {
                MessageBox.Show("Không được bỏ trống", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            SqlCommand command = new SqlCommand("select slnhap from sach where masach = '" + cboMaSach.Text + "'");
            DataTable dt = admin.getBooksCommand(command);
            int slnhap = Convert.ToInt32(dt.Rows[0][0].ToString());
            command = new SqlCommand("select sum(slmuon) from hsphieumuon where masach = '" + cboMaSach.Text + "'");
            dt = admin.getBooksCommand(command);
            int sldamuon = Convert.ToInt32(dt.Rows[0][0].ToString());
            int slmuon = Convert.ToInt32(TextBox_SL.Text.Trim());
            if (slnhap < sldamuon + slmuon)
            {
                MessageBox.Show("Nhập sai số lượng", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            return true;
        }
        bool isNum(string str)
        {
            try
            {
                int a = Convert.ToInt32(str);
                if (a < 0)
                    return false;
            }
            catch
            {
                return false;
            }
            return true;
        }

       
    }
}
