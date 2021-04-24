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

namespace QLTV.UserControlGiaoVien
{
    public partial class USChoMuonSach : UserControl
    {
        public string magv;
        public USChoMuonSach()
        {
            InitializeComponent();
        }
        Teacher sach = new Teacher();
        public void USChoMuonSach_Load(object sender, EventArgs e)
        {
            TextBox_MaSach.Text = tangMaTuDong();
            TextBox_TenSach.Text = "";
            TextBox_ChuDe.Text = "";
            TextBox_TacGia.Text = "";
            TextBox_NXB.Text = "";
            TextBox_NamXB.Text = "";
            TextBox_SL.Text = "";
            TextBox_DonGia.Text = "";
            cboTinhTrang.Text = "Mới";
            TextBox_GhiChu.Text = "";
        }
        public string tangMaTuDong()
        {
            SqlCommand command = new SqlCommand("Select max(masach) from sach");
            DataTable dt = sach.getBooksCommand(command);
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

        private void btnChoMuon_Click(object sender, EventArgs e)
        {
           // try
           // {
                string masach = TextBox_MaSach.Text;
                string tensach = TextBox_TenSach.Text;
                string chude = TextBox_ChuDe.Text;
                string tacgia = TextBox_TacGia.Text;
                string nxb = TextBox_NXB.Text;
                int namxb = Convert.ToInt32(TextBox_NamXB.Text.Trim());
                int sluong = Convert.ToInt32(TextBox_SL.Text.Trim());
                int dongia = Convert.ToInt32(TextBox_DonGia.Text.Trim());
                string tinhtrang = cboTinhTrang.Text;
                string ghichu = TextBox_GhiChu.Text;


                if (sach.choMuonSach(masach, tensach, chude, tacgia, nxb, namxb, sluong, dongia, tinhtrang, ghichu, magv))
                {
                    MessageBox.Show("Cho mượn thành công", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cho mượn sách không thành công", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

          //  }
         //   catch
          //  {
           //     MessageBox.Show("Nhập sai", "Cho mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          //  }
        }
    }
}
