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
        public void USTraSachSV_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT MaPhieu, dbo.HSPhieuMuon.MaSach, TenSach, SLMuon,NgayMuon,NgayTra, HSPhieuMuon.GhiChu " +
                "FROM dbo.HSPhieuMuon " +
                "INNER JOIN dbo.Sach ON Sach.MaSach = HSPhieuMuon.MaSach " +
                "WHERE dbo.HSPhieuMuon.MSSV = 'SV001'");
            DGV_Sach.DataSource = sach.getBooksCommand(command);
        }

        private void DGV_Sach_Click(object sender, EventArgs e)
        {
            TextBox_MaPhieu.Text = DGV_Sach.CurrentRow.Cells[0].Value.ToString();
            TextBox_MaSach.Text = DGV_Sach.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
