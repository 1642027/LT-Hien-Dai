using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class DataProvider
    {
        public String AnhViet(String c)
        {
            SqlConnection cn = new SqlConnection("Server=.;Database=Anh-Viet;User Id=sa;Password = 123456; ");
            SqlCommand sqlCommand = cn.CreateCommand();
            SqlDataReader dar;
            string sql = "Select TiengViet from TuAnhViet where TiengAnh='" + c + "'";
            sqlCommand.CommandText = sql;
            cn.Open();
            dar = sqlCommand.ExecuteReader();
            String kq = " ";
            while (dar.Read())
            {
                kq = dar["TiengViet"].ToString();
            }
            cn.Close();
            return kq;
        }
    }
}