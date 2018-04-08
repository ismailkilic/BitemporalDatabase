using System.Configuration;
using System.Data.SqlClient;

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
                return ConfigurationManager.AppSettings["Veritabani"];
                

            }
        }


    }
}
