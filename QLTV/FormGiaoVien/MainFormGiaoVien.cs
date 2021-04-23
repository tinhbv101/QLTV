using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.FormGiaoVien
{
    public partial class MainFormGiaoVien : Form
    {
        public MainFormGiaoVien()
        {
            InitializeComponent();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            changePasswordGV1.BringToFront();
            changePasswordGV1.ChangePasswordGV_Load(sender, e);
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            editGiaoViencs1.BringToFront();
            editGiaoViencs1.EditGiaoViencs_Load(sender, e);
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            usMuonSachGV1.BringToFront();
            usMuonSachGV1.USMuonSachGV_Load(sender, e);
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            usTraSachGV1.BringToFront();
            usTraSachGV1.USTraSachGV_Load(sender, e);
        }
    }
}
