using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void usMuonSach1_Load(object sender, EventArgs e)
        {

        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            usMuonSach1.USMuonSach_Load(sender, e);
            usMuonSach1.BringToFront();
            
        }

        private void usTraSachSV1_Load(object sender, EventArgs e)
        {

        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            usTraSachSV1.USTraSachSV_Load(sender, e);
            usTraSachSV1.BringToFront();
        }
    }
}
