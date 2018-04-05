using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class UrunBLL
    {

      public UrunBLL()
        {


        }


      VeritabaniSaglayici vt = new VeritabaniSaglayici();

      //Urun Kayıt İşlemi
        public  void Kaydet(Urun urun)
        {
            vt.ParametreleriTemizle();
            vt.InParametreleriEkle("@UrunAdi", DbType.String,urun.UrunAdi);
            vt.InParametreleriEkle("@UrunFiyati", DbType.Double, urun.UrunFiyati);
            try
            {
                vt.ExecuteNonQueryYap("sp_UrunKayit", System.Data.CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Urun Düzenleme İşlemi
        public void Duzenle(Urun urun)
        {
            vt.ParametreleriTemizle();
            vt.InParametreleriEkle("@UrunID", DbType.String, urun.UrunID);
            vt.InParametreleriEkle("@UrunAdi", DbType.String, urun.UrunAdi);
            vt.InParametreleriEkle("@UrunFiyati", DbType.String, urun.UrunFiyati);
            try
            {
                vt.ExecuteNonQueryYap("sp_UrunDuzenle", System.Data.CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        //Urun Silme İşlemi
        public  void Sil(Urun urun)
        {
            vt.ParametreleriTemizle();
            vt.InParametreleriEkle("@ID", DbType.Int32, urun.UrunID);

            vt.ExecuteNonQueryYap("sp_UrunSil", System.Data.CommandType.StoredProcedure);
        }

        //Urun Listeleme İşlemi
        public List<Urun>  Listele()
        {
            List<Urun> urunler = new List<Urun>();
            vt.ParametreleriTemizle();
            SqlDataReader dr;

            dr = vt.ExecuteReaderYap("sp_Urunler", System.Data.CommandType.StoredProcedure);



            while (dr.Read())
            {
                Urun u = new Urun();
                u.UrunID = (int)dr["id"];
                u.UrunAdi = (string)dr["UrunAdi"];
                urunler.Add(u);


            }

            return urunler;
        }

      //Urun Bulma İşlemi
        public Urun UrubBul(int id)
        {
            Urun geriGonder = new Urun();
            vt.ParametreleriTemizle();
            vt.InParametreleriEkle("@UrunID", DbType.String, id);

            SqlDataReader dr = vt.ExecuteReaderYap("sp_UrunGetir", CommandType.StoredProcedure);
            if (dr.Read())
            {
                //geriGonder.KullaniciId = (int)dr["id"];
                geriGonder.UrunAdi = dr["UrunAdi"].ToString();
                geriGonder.UrunFiyati = Convert.ToDouble(dr["UrunFiyati"]);
                
            }
            else
            {
        
            }

            return geriGonder;

        }

      //Urun Satiş Yapma İşlemi
        public void UrunSatisyap(int id,int adet,double toplamtutar,string tarih)
        {
            vt.ParametreleriTemizle();
            vt.InParametreleriEkle("@UrunID", DbType.Int32, id);
            vt.InParametreleriEkle("@UrunAdeti", DbType.Int32, adet);
            vt.InParametreleriEkle("@UrunTutari", DbType.Int32, toplamtutar);
            vt.InParametreleriEkle("@SatisTarihi", DbType.Date, tarih);

            vt.ExecuteNonQueryYap("sp_UrunSatisyap", System.Data.CommandType.StoredProcedure);
        }


      //Urun Raporlama İşlemi
        public DataTable GelirRaporTablola(int AramaKriteri,int ID,string UrunAdi,string baslangic,string bitis)
        {
            
            VeritabaniSaglayici vt = new VeritabaniSaglayici();
            vt.ParametreleriTemizle();
            vt.InParametreleriEkle("@AramaKriteri", DbType.Int32, AramaKriteri);
            vt.InParametreleriEkle("@UrunID", DbType.Int32, ID);
            vt.InParametreleriEkle("@UrunAdi", DbType.String, UrunAdi);
            vt.InParametreleriEkle("@baslangictarihi", DbType.DateTime, Convert.ToDateTime(baslangic));
            vt.InParametreleriEkle("@bitistarihi", DbType.DateTime, Convert.ToDateTime(bitis));
            return vt.DataTableYap("sp_UrunSatisRapor", CommandType.StoredProcedure);
        }
    }
}
