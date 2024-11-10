using daVasstTrees.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace daVasstTrees.DAO
{
    public class orderDetailDao
    {
        static string str = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        public bool insertData(int orderID,List<CartProduct> list)
        {
            bool check = true;
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            conn.Open();
            foreach(CartProduct x in list)
            {
                cmd.CommandText = $"insert into tblorderDetail " +
                    $"values({orderID},{x.Product.ProductID},{x.Quantity})" +
                    $"";
                if(cmd.ExecuteNonQuery() == -1)
                {
                    check = false;
                }
            }
            cmd.Dispose();
            conn.Close();
            if(check == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<orderDetail> getListOrderDetail(int id)
        {
            List<orderDetail> list = new List<orderDetail>();
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"select * from tblorderDetail where orderID = {id}";
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                orderDetail orderdetail = new orderDetail(dr.GetInt32(0),dr.GetInt32(1),dr.GetInt32(2));
                list.Add(orderdetail);
            }
            return list;
        }
    }
}