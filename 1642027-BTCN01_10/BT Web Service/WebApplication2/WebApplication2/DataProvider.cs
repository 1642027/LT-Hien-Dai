using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class DataProvider
    {
        
        public String PhapAnh(String c)
        {
            SqlConnection cn = new SqlConnection("Server=.;Database=Phap-Anh;User Id=sa;Password = 123456; ");
            SqlCommand sqlCommand = cn.CreateCommand();
            SqlDataReader dar;
            string sql = "Select TiengAnh from TuPhapAnh where TiengPhap='" + c + "'";
            sqlCommand.CommandText = sql;
            cn.Open();
            dar = sqlCommand.ExecuteReader();
            String kq = " ";
            while (dar.Read())
            {
                kq = dar["TiengAnh"].ToString();
            }
            cn.Close();
            return kq;
        }
    }
}