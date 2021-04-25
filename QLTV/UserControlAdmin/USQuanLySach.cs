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
    public partial class USQuanLySach : UserControl
    {
        public USQuanLySach()
        {
            InitializeComponent();
        }
        Admin admin = new Admin();
        int flag;
        public void USQuanLySach_Load(object sender, EventArgs e)
        {
            rdoMaSach.Checked = true;
            SqlCommand command = new SqlCommand("select masach as 'Mã Sách', tensach as 'Tên Sách', chude as 'Chủ Đề', tacgia as 'Tác Giả', nxb as NXB, namxb as 'Năm XB', slnhap as 'SL Nhập', dongia as 'Đơn Giá',tinhtrang as 'tình trạng', ghichu as 'ghi chú', nguon as Nguồn from sach");

            DGV_Sach.DataSource = admin.getBooksCommand(command);
            DGV_Sach.AutoGenerateColumns = false;
            DGV_Sach.RowTemplate.Height = 50;
            btnThem.Enabled = true;
            btnhuy.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            DGV_Sach.Enabled = true;
            unableTextbox();
            flag = 0;
        }

        void unableTextbox()
        {
            TextBox_MaSach.Enabled = false;
            TextBox_TenSach.Enabled = false;
            TextBox_ChuDe.Enabled = false;
            TextBox_TacGia.Enabled = false;
            TextBox_NXB.Enabled = false;
            TextBox_NamXB.Enabled = false;
            TextBox_SL.Enabled = false;
            TextBox_DonGia.Enabled = false;
            cboTinhTrang.Enabled = false;
            TextBox_GhiChu.Enabled = false;
            TextBox_Nguon.Enabled = false;

        }
        void enableTextBox()
        {
            TextBox_TenSach.Enabled = true;
            TextBox_ChuDe.Enabled = true;
            TextBox_TacGia.Enabled = true;
            TextBox_NXB.Enabled = true;
            TextBox_NamXB.Enabled = true;
            TextBox_SL.Enabled = true;
            TextBox_DonGia.Enabled = true;
            cboTinhTrang.Enabled = true;
            TextBox_GhiChu.Enabled = true;
            TextBox_Nguon.Enabled = true;
            
        }

        private void DGV_Sach_Click(object sender, EventArgs e)
        {
            if (DGV_Sach.CurrentRow.Index + 1 != DGV_Sach.Rows.Count)
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                TextBox_MaSach.Text = DGV_Sach.CurrentRow.Cells[0].Value.ToString();
                TextBox_TenSach.Text = DGV_Sach.CurrentRow.Cells[1].Value.ToString();
                TextBox_ChuDe.Text = DGV_Sach.CurrentRow.Cells[2].Value.ToString();
                TextBox_TacGia.Text = DGV_Sach.CurrentRow.Cells[3].Value.ToString();
                TextBox_NXB.Text = DGV_Sach.CurrentRow.Cells[4].Value.ToString();
                TextBox_NamXB.Text = DGV_Sach.CurrentRow.Cells[5].Value.ToString();
                TextBox_SL.Text = DGV_Sach.CurrentRow.Cells[6].Value.ToString();
                TextBox_DonGia.Text = DGV_Sach.CurrentRow.Cells[7].Value.ToString();
                cboTinhTrang.Text = DGV_Sach.CurrentRow.Cells[8].Value.ToString();
                TextBox_GhiChu.Text = DGV_Sach.CurrentRow.Cells[9].Value.ToString();
                TextBox_Nguon.Text = DGV_Sach.CurrentRow.Cells[10].Value.ToString();
            }
            else
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;

            }
        }

        private void TextBox_Search_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command;
            if (rdoMaSach.Checked == true)
            {
                command = new SqlCommand("select masach as 'Mã Sách', tensach as 'Tên Sách', chude as 'Chủ Đề', tacgia as 'Tác Giả', nxb as NXB, namxb as 'Năm XB', slnhap as 'SL Nhập', dongia as 'Đơn Giá',tinhtrang as 'tình trạng', ghichu as 'ghi chú', nguon as Nguồn from sach where MaSach like '%" + TextBox_Search.Text + "%'");
                DGV_Sach.DataSource = admin.getBooksCommand(command);
            }
            else if (rboTenSach.Checked == true)
            {
                command = new SqlCommand("select masach as 'Mã Sách', tensach as 'Tên Sách', chude as 'Chủ Đề', tacgia as 'Tác Giả', nxb as NXB, namxb as 'Năm XB', slnhap as 'SL Nhập', dongia as 'Đơn Giá',tinhtrang as 'tình trạng', ghichu as 'ghi chú', nguon as Nguồn from sach where TenSach like N'%" + TextBox_Search.Text + "%'");
                DGV_Sach.DataSource = admin.getBooksCommand(command);
            }
            else
            {
                command = new SqlCommand("select masach as 'Mã Sách', tensach as 'Tên Sách', chude as 'Chủ Đề', tacgia as 'Tác Giả', nxb as NXB, namxb as 'Năm XB', slnhap as 'SL Nhập', dongia as 'Đơn Giá',tinhtrang as 'tình trạng', ghichu as 'ghi chú', nguon as Nguồn from sach where chude like N'%" + TextBox_Search.Text + "%'");
                DGV_Sach.DataSource = admin.getBooksCommand(command);
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            setupThemSach();
            flag = 2;
        }

        void setupThemSach()
        {
            TextBox_MaSach.Text = tangMaTuDong();
            enableTextBox();
            TextBox_Nguon.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnhuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            DGV_Sach.Enabled = false;
            TextBox_TenSach.Text = "";
            TextBox_ChuDe.Text = "";
            TextBox_TacGia.Text = "";
            TextBox_NXB.Text = "";
            TextBox_NamXB.Text = "";
            TextBox_SL.Text = "";
            TextBox_DonGia.Text = "";
            TextBox_GhiChu.Text = "";
        }  

        string tangMaTuDong()
        {
            SqlCommand command = new SqlCommand("Select max(masach) from sach");
            DataTable dt = admin.getBooksCommand(command);
            string maphieu = dt.Rows[0][0].ToString();
            maphieu = maphieu.Replace("MS", "");
            int sophieu = Convert.ToInt32(maphieu);
            string maTuDong = "MS";
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

            return maTuDong;
        }



        private void btnhuy_Click(object sender, EventArgs e)
        {
            USQuanLySach_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                if (flag == 1)
                {
                    if (TextBox_Nguon.Text != "")
                    {
                        SqlCommand command = new SqlCommand("update sach set tensach = @ts, chude = @cd, tacgia = @tg, nxb = @xb, namxb = @nam, slnhap = @sl," +
                            " dongia = @dg, tinhtrang = @tt, ghichu = @gc, nguon = @ng where masach = @ms");
                        command.Parameters.Add("@ts", SqlDbType.NVarChar).Value = TextBox_TenSach.Text.Trim();
                        command.Parameters.Add("@cd", SqlDbType.NVarChar).Value = TextBox_ChuDe.Text.Trim();
                        command.Parameters.Add("@tg", SqlDbType.NVarChar).Value = TextBox_TacGia.Text.Trim();
                        command.Parameters.Add("@xb", SqlDbType.NVarChar).Value = TextBox_NXB.Text.Trim();
                        command.Parameters.Add("@nam", SqlDbType.Int).Value = Convert.ToInt32(TextBox_NamXB.Text.Trim());
                        command.Parameters.Add("@sl", SqlDbType.Int).Value = Convert.ToInt32(TextBox_SL.Text.Trim());
                        command.Parameters.Add("@dg", SqlDbType.Int).Value = Convert.ToInt32(TextBox_DonGia.Text.Trim());
                        command.Parameters.Add("@tt", SqlDbType.NVarChar).Value = cboTinhTrang.Text;
                        command.Parameters.Add("@gc", SqlDbType.NVarChar).Value = TextBox_GhiChu.Text;
                        command.Parameters.Add("@ng", SqlDbType.NVarChar).Value = TextBox_Nguon.Text;
                        command.Parameters.Add("@ms", SqlDbType.VarChar).Value = TextBox_MaSach.Text;
                        if (admin.getCommandAdmin(command))
                        {
                            MessageBox.Show("Sửa thành công", "Sửa sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Sửa không thành công", "Sửa sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        USQuanLySach_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Nguồn không được bỏ trống", "Sửa sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else if (flag == 2)
                {
                    string masach = TextBox_MaSach.Text;
                    string tensach = TextBox_TenSach.Text.Trim();
                    string chude = TextBox_ChuDe.Text.Trim();
                    string tacgia = TextBox_TacGia.Text.Trim();
                    string nxb = TextBox_NXB.Text.Trim();
                    int namxb = Convert.ToInt32(TextBox_NamXB.Text.Trim());
                    int sluong = Convert.ToInt32(TextBox_SL.Text.Trim());
                    int dongia = Convert.ToInt32(TextBox_DonGia.Text.Trim());
                    string tinhtrang = cboTinhTrang.Text;
                    string ghichu = TextBox_GhiChu.Text;
                    string nguon = "TV";
                    if (admin.themSach(masach, tensach, chude, tacgia, nxb, namxb, sluong, dongia, tinhtrang, ghichu, nguon))
                    {
                        MessageBox.Show("Thêm thành công", "Thêm sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        USQuanLySach_Load(sender, e);


                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thêm sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập thông tin không đủ hoặc không đúng", "Thêm sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("delete from sach where masach = '" + TextBox_MaSach.Text + "'");
            if (admin.getCommandAdmin(command))
            {
                MessageBox.Show("Xóa thành công", "Xóa sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "Xóa sách", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            USQuanLySach_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setupSuaSach();
            flag = 1;
            
        }

        void setupSuaSach()
        {
            enableTextBox();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnhuy.Enabled = true;
            btnLuu.Enabled = true;
            DGV_Sach.Enabled = false;
            btnSua.Enabled = false;
            
        }

        bool verif()
        {
            if(TextBox_TenSach.Text == ""
                || TextBox_ChuDe.Text == ""
                || TextBox_TacGia.Text == ""
                || TextBox_NXB.Text == ""
                || TextBox_NamXB.Text == ""
                || TextBox_SL.Text ==""
                || TextBox_DonGia.Text == ""
                || TextBox_GhiChu.Text == "")
            {
                return false;
            }
            try
            {
                int laso;
                laso = Convert.ToInt32(TextBox_NamXB.Text.Trim());
                if(laso < 0)
                {
                    return false;
                }
                laso = Convert.ToInt32(TextBox_SL.Text.Trim());
                if (laso < 0)
                {
                    return false;
                }
                laso = Convert.ToInt32(TextBox_DonGia.Text.Trim());
                if (laso < 0)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void groupBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
