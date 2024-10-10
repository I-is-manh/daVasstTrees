using daVasstTrees.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace daVasstTrees.DAO
{
    public class categoryDao
    {
        string str = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        public List<Categoryy> getListCategory()
        {
            List<Categoryy> list = new List<Categoryy>();
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from tblCategory";
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Categoryy c = new Categoryy(dr.GetInt32(0),dr.GetString(1),dr.GetString(2));
                list.Add(c);
            }
            cmd.Dispose();
            conn.Close();
            return list;
        }
        public Categoryy getInfoCategory(int id)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = $"select * from tblCategory where categoryID = {id}";
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Categoryy c = new Categoryy();
            while (dr.Read())
            {
                c = new Categoryy(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
            }
            cmd.Dispose();
            con.Close();
            return c;
        }
    }
}