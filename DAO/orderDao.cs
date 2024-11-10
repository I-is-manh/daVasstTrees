using daVasstTrees.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.WebSockets;

namespace daVasstTrees.DAO
{
    public class orderDao
    {
        static string str = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        public int getOrderID(int customerID)
        {
            int id = 0;
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"select top 1 * from tblOrder where customerId = {customerID} order by orderID desc ";
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = int.Parse(dr.GetInt32(0).ToString());
                Console.Write(id);
            }
            cmd.Dispose();
            conn.Close();
            return id;
        }
        public order getOrderByID(int orderID)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"select * from tblOrder where orderID = {orderID}";
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            order oderr = null;
            if (dr.Read())
            {
                oderr = new order(dr.GetInt32(0), dr.GetInt32(1), dr.GetDateTime(2), dr.GetString(3), dr.GetString(4), dr["moreinfo"].ToString());
            }
            return oderr;
        }
        public bool inserData(int customerID, string address,string pttt,string phone,string moreinfo)
        {
            DateTime date = DateTime.Now;
            string datetime = date.ToString("yyyy-MM-dd");
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            if(moreinfo != null)
            {
                cmd.CommandText = $"insert into tblOrder " +
                $"values({customerID},N\'{datetime}\',N\'{address}\',N\'{pttt}\',\'{phone}\',N\'{moreinfo}\')";
            }
            else
            {
                cmd.CommandText = $"insert into tblOrder " +
                $"values({customerID},N\'{datetime}\',N\'{address}\',N\'{pttt}\',\'{phone}\',NULL)";
            }
            conn.Open();
            if(cmd.ExecuteNonQuery() == -1)
            {
                cmd.Dispose();
                conn.Close();
                return false;
            }
            else
            {
                return true;
            }
           
        }
    }
}