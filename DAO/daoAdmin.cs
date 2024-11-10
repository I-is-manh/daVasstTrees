using daVasstTrees.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace daVasstTrees.DAO
{
    public class daoAdmin
    {
        string str = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        public Admin getAdmin(string email,string password)
        {
            
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from tblAdmin";
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Admin admin = new Admin(dr.GetInt32(0),dr.GetString(1),dr.GetString(2),dr.GetString(3),dr.GetString(4));
                cmd.Dispose();
                conn.Close();
                return admin;
            }
            else
            {
                return null;
            }
            
        }
    }
}