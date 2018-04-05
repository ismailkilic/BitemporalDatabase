using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class BaglantiSaglayici
    {
        public static SqlConnection BaglantiOlustur()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = BaglantiSaglayici.BaglantiCumlesi;

            return con;
        }

        public static string BaglantiCumlesi
        {
            get
            {
                return ConfigurationSettings.AppSettings["Veritabani"];
                

            }
        }


    }
}
