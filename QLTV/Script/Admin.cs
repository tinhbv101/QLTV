using DoAnThuVien;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.Script
{
    class Admin
    {
        myDB mydb = new myDB();

        public DataTable getBooksCommand(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public bool changePassword(string maad, string mkcu, string mkmoi)
        {
            SqlCommand command = new SqlCommand("select matkhauad from admin where maad = '" + maad + "'", mydb.getConnection);
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (mkcu != dt.Rows[0][0].ToString())
            {
                MessageBox.Show("Mật khẩu cũ sai", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            command = new SqlCommand("update admin set matkhauad = @mkm where maad = @msv", mydb.getConnection);
            command.Parameters.Add("@mkm", SqlDbType.VarChar).Value = mkmoi;
            command.Parameters.Add("@msv", SqlDbType.VarChar).Value = maad;
            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool getCommandAdmin(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool themSach(string masach, string tensach, string chude, string tacgia,
            string nxb, int namxb, int sluong, int dongia, string tinhtrang,
            string ghichu, string nguon)
        {
            SqlCommand command = new SqlCommand("insert into sach values (@ms,@ts,@cd,@tg,@xb,@nam,@sl,@dg,@tt,@gc,@ng)", mydb.getConnection);
            command.Parameters.Add("@ms", SqlDbType.VarChar).Value = masach;
            command.Parameters.Add("@ts", SqlDbType.NVarChar).Value = tensach;
            command.Parameters.Add("@cd", SqlDbType.NVarChar).Value = chude;
            command.Parameters.Add("@tg", SqlDbType.NVarChar).Value = tacgia;
            command.Parameters.Add("@xb", SqlDbType.NVarChar).Value = nxb;
            command.Parameters.Add("@nam", SqlDbType.Int).Value = namxb;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = sluong;
            command.Parameters.Add("@dg", SqlDbType.Int).Value = dongia;
            command.Parameters.Add("@tt", SqlDbType.NVarChar).Value = tinhtrang;
            command.Parameters.Add("@gc", SqlDbType.NVarChar).Value = ghichu;
            command.Parameters.Add("@ng", SqlDbType.VarChar).Value = nguon;
            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}
