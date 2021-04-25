using QLTV.Script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class mainFormAdmin : Form
    {
        public string maad;
        public mainFormAdmin(string mad)
        {
            maad = mad;

            InitializeComponent();
            usQuanLySach1.Visible = false;
        }

        private void mainFormAdmin_Load(object sender, EventArgs e)
        {
            Admin sach = new Admin();



            //LẤY AVATAR
            SqlCommand command = new SqlCommand("Select maad, tenad, gioitinhad,ngaysinhad, sdtad, diachiad,avatar from admin where maad = @msv");
            command.Parameters.Add("@msv", SqlDbType.VarChar).Value = maad;
            DataTable dt = sach.getBooksCommand(command);

            if (dt.Rows[0]["avatar"].ToString() == "")
            {

            }
            else
            {
                byte[] pic;
                pic = (byte[])dt.Rows[0]["avatar"];
                MemoryStream picture = new MemoryStream(pic);
                Avatar_Pic.Image = Image.FromStream(picture);
            }


            //LẤY TÊN
            command = new SqlCommand("Select tenad from admin where maad = @msv");
            command.Parameters.Add("@msv", SqlDbType.VarChar).Value = maad;
            dt = new DataTable();
            dt = sach.getBooksCommand(command);
            label_Name.Text = dt.Rows[0][0].ToString().Trim();
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            usQuanLySach1.Visible = true;
            usQuanLySach1.BringToFront();
            usQuanLySach1.USQuanLySach_Load(sender, e);
        }

        private void usQuanLySach1_Load(object sender, EventArgs e)
        {

        }
    }
}
