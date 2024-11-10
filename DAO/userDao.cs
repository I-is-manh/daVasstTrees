using daVasstTrees.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace daVasstTrees.DAO
{
    public class userDao
    {
        private string strConnect = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        public bool checkDn(string email,string password)
        {
            SqlConnection con = new SqlConnection(strConnect);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select count(*) from tblKhachHang where email = \'{email}\' and customerPassword = \'{password}\'";
            con.Open();
            var check = cmd.ExecuteScalar();
            cmd.Dispose();
            con.Close();
            if(int.Parse(check.ToString()) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool changePassWord(string  email,string password)
        {
            SqlConnection conn = new SqlConnection(strConnect);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"update tblKhachHang " +
                $"set customerPassword = '{password}' " +
                $"where email = '{email}'";
            conn.Open();
            if(cmd.ExecuteNonQuery() == -1)
            {
                return false;
            }
            else
            return true;
        }
        public User getInfomation(string email, string password)
        {
            SqlConnection con = new SqlConnection(strConnect);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from tblKhachHang where email = \'{email}\' and customerPassword = \'{password}\'";
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            User user = new User();
            while (dr.Read())
            {
                user = new User(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr["address"].ToString(), dr["numberphone"].ToString(), dr["avatar"].ToString(), dr["customerFullName"].ToString());
            }
            cmd.Dispose();
            con.Close();
            return user;
        }
        public void updateUser(int id,string name,string email,string address,string numberphone,string linkimg)
        {
            SqlConnection conn = new SqlConnection(strConnect);
            SqlCommand cmd = conn.CreateCommand();
            //cmd.CommandText = $"update tblKhachHang" +
            //    $"set email = \'{email}\' , address=\'{address}\', numberphone=\'{numberphone}\', avatar=\'{linkimg}\',customerFullName = \'{name}\'" +
            //    $"where customerId = \'{id}\'";
            cmd.CommandText = $"update tblKhachHang " +
                $"set email = '{email}', address = N'{address}', numberphone='{numberphone}', avatar = '{linkimg}', customerFullName=N'{name}'" +
                $"where customerId = '{id}'";
            conn.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
        public int checkEmailExist(string email)
        {
            SqlConnection con = new SqlConnection(strConnect);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = $"select count(*) from tblKhachHang where email = \'{email}\'";
            con.Open();
            var check = cmd.ExecuteScalar();
            cmd.Dispose();
            con.Close();
            if (int.Parse(check.ToString()) == 0)
            {
                return int.Parse(check.ToString());
            }
            else
            {
                return int.Parse(check.ToString());
            }
        }
        public bool signUp(string email,string password)
        {
            SqlConnection con = new SqlConnection(strConnect);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = $"insert into tblKhachHang(email,customerPassword)\r" +
                                        $"\nvalues('{email}','{password}')";
            con.Open();
            int checkInsert = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            if(checkInsert == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
    }
}