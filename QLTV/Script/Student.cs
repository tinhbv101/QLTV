﻿using DoAnThuVien;
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
    class Student
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
        public bool changePassword(string mssv, string mkcu, string mkmoi)
        {
            SqlCommand command = new SqlCommand("select matkhausv from sinhvien where mssv = '" + mssv +"'", mydb.getConnection);
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if(mkcu != dt.Rows[0][0].ToString())
            {
                MessageBox.Show("Mật khẩu cũ sai", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            command = new SqlCommand("update sinhvien set matkhausv = @mkm where mssv = @msv", mydb.getConnection);
            command.Parameters.Add("@mkm", SqlDbType.VarChar).Value = mkmoi;
            command.Parameters.Add("@msv", SqlDbType.VarChar).Value = mssv;
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
        public bool traSachALL(string maphieu, string mssv, string masach)
        {
            SqlCommand command = new SqlCommand("delete from hsphieumuon where maphieu = @mp and masach = @ms and ms = @msv", mydb.getConnection);
            command.Parameters.Add("@mp", SqlDbType.VarChar).Value = maphieu;
            command.Parameters.Add("@msv", SqlDbType.VarChar).Value = mssv;
            command.Parameters.Add("@ms", SqlDbType.VarChar).Value = masach;
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
        public bool traSachUpdate(int slmuon, string maphieu, string mssv, string masach)
        {
            SqlCommand command = new SqlCommand("update hsphieumuon set slmuon = @sl where maphieu = @mp and ms = @msv and masach =@ms", mydb.getConnection);
            command.Parameters.Add("@sl", SqlDbType.Int).Value = slmuon;
            command.Parameters.Add("@mp", SqlDbType.VarChar).Value = maphieu;
            command.Parameters.Add("@msv", SqlDbType.VarChar).Value = mssv;
            command.Parameters.Add("@ms", SqlDbType.VarChar).Value = masach;
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
        public bool muonSach(string maphieu,string mssv, string masach, string ngmuon, string ngtra, int slmuon, string tinhtrang, string ghichu)
        {
            SqlCommand command = new SqlCommand("insert into HSPhieuMuon values (@mp, @msv, @ms, @nm, @nt, @sl, @tt, @gc)",mydb.getConnection);
            command.Parameters.Add("@mp", SqlDbType.VarChar).Value = maphieu;
            command.Parameters.Add("@msv", SqlDbType.VarChar).Value = mssv;
            command.Parameters.Add("@ms", SqlDbType.VarChar).Value = masach;
            command.Parameters.Add("@nm", SqlDbType.NVarChar).Value = ngmuon;
            command.Parameters.Add("@nt", SqlDbType.NVarChar).Value = ngtra;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = slmuon;
            command.Parameters.Add("@tt", SqlDbType.NVarChar).Value = tinhtrang;
            command.Parameters.Add("@gc", SqlDbType.NVarChar).Value = ghichu;
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
        public bool getCommandSinhVien(SqlCommand command)
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
    }
}
