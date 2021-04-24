using QLTV.FormGiaoVien;
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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormGiaoVien mainFormGiaoVien = new MainFormGiaoVien(textBox1.Text);
            mainFormGiaoVien.Show();
        }
    }
}
