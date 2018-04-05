using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Data.OleDb;

namespace DAL
{
    public class VeritabaniSaglayici
    {
        private List<SqlParameter> parametreler = new List<SqlParameter>();

        private SqlCommand SqlCommandOlustur(string sorgu, CommandType komutTipi)
        {
            #region 1.YOL :
            //SqlCommand cmd = new SqlCommand(sorgu, BaglantiSaglayici.BaglantiOlustur());
            //cmd.CommandType = komutTipi;

            //return cmd; 
            #endregion

            SqlCommand cmd = BaglantiSaglayici.BaglantiOlustur().CreateCommand();
            cmd.CommandText = sorgu;
            cmd.CommandType = komutTipi;

            return cmd;
        }

        public void InParametreleriEkle(string parametreIsmi, DbType parametreTipi, object deger)
        {
            SqlParameter p = new SqlParameter();
            p.ParameterName = parametreIsmi;
            p.DbType = parametreTipi;
            p.Value = deger;
            parametreler.Add(p);
        }

        public void OutParametreleriEkle(string parametreIsmi, DbType parametreTipi)
        {
            SqlParameter p = new SqlParameter();
            p.ParameterName = parametreIsmi;
            p.DbType = parametreTipi;
            p.Direction = ParameterDirection.Output;
            // SqlParameter tipinin default olarak Direction özelliğinin değeri Inputtur. Yani Input tipteki parametre için bu özelliğ iset etmeye lüzum yoktur, ancak diğer tipteki parametreler için bu özellik set edilmelidir.
            // Eğer sorgu içinden bize return ile değer dönüyorsa bu durumda Direction ReturnValue seçilmelidir.
            parametreler.Add(p);
        }

        private void ParametreleriEkle(SqlCommand cmd)
        {
            // 1. YOL :
            //foreach (SqlParameter item in parametreler)
            //{
            //    cmd.Parameters.Add(item);
            //}
            //---------------------------------------------------------------
            // 2. YOL
            cmd.Parameters.AddRange(parametreler.ToArray());
            //parametreler.ToArray() : parmetreler koleksiyonu SqlParameter tipinden bir generic olduğu için ToaArray metdu ile SqlParameter dizisine çevirme işlemini yapar.

            // eĞER ELİMİZDE bir ArrayList içineki parametreler olsaydı :
            //ArrayList a = new ArrayList();
            //SqlParameter[] pler = (SqlParameter[])a.ToArray(typeof(SqlParameter));
            //cmd.Parameters.AddRange(pler);
        }

        public object ParametreDegeriniGetir(string parametreIsmi)
        {
            foreach (SqlParameter item in parametreler)
            {
                if (item.ParameterName == parametreIsmi)
                    return item.Value;
            }

            return null;
        }

        public void ParametreleriTemizle()
        {
            parametreler.Clear();
        }

        public int ExecuteNonQueryYap(string sorgu, CommandType komutTipi)
        {
            SqlCommand cmd = this.SqlCommandOlustur(sorgu, komutTipi);
            this.ParametreleriEkle(cmd);
    
       
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }

                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }
            }
        }

        public object ExecuteScalarYap(string sorgu, CommandType komutTipi)
        {
            SqlCommand cmd = this.SqlCommandOlustur(sorgu, komutTipi);
            this.ParametreleriEkle(cmd);

            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }

                return cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw e;
              //  throw new Exception("VERİTABANINDA HATA OLUŞTU");
            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }
            }
        }

        public SqlDataReader ExecuteReaderYap(string sorgu, CommandType komutTipi)
        {
            SqlCommand cmd = this.SqlCommandOlustur(sorgu, komutTipi);
            this.ParametreleriEkle(cmd);
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }

                return cmd.ExecuteReader(CommandBehavior.CloseConnection);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            //finally
            //{
            //    if (cmd.Connection.State != ConnectionState.Closed)
            //    {
            //        cmd.Connection.Close();
            //    }
            //}
            // NOT : ExecuteReader(CommandBehavior.CloseConnection); ile, zaten reader ın işi bittiğinde conenctionı kapat dediğimiz için finally e gerek yoktur. eğer finally koyarsak bu durumda reader sonuç kümesinden sadece ilk satırı okur sonra try bloğu finally e dallanır ve conenction kapanır. böylece sadece 1 satır okunmuş olur, bu da mantıksal bir hatadır.
        }
        public DataSet DataSetYap(string sorgu, CommandType komutTipi, string dataTableIsmi)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = this.SqlCommandOlustur(sorgu, komutTipi);
            this.ParametreleriEkle(da.SelectCommand);
            try
            {
                da.SelectCommand.Connection.Open(); // da nesnesi normalde conenctio nı otomatik açar, ama biz manuel olarak da nesnesinin kullandığı conenctionı bu şekilde açtırabiliriz.

                if (string.IsNullOrEmpty(dataTableIsmi))
                {

                    // IsNullOrEmpty : içine verdiğimiz string ifadenin empty ya da null olup olmadığına bakar, ilgili duruma göre true ya da false döner.
                    da.Fill(ds);

                }
                else
                {
                    da.Fill(ds, dataTableIsmi);
                }

                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                da.SelectCommand.Connection.Close();
            }
        }

        public DataSet DataSetYap(string sorgu, CommandType komutTipi)
        {
            return DataSetYap(sorgu, komutTipi, "");
        }

        public DataTable DataTableYap(string sorgu, CommandType komutTipi, string dataTableIsmi)
        {
            DataTable dt;
            if (string.IsNullOrEmpty(dataTableIsmi))
            {
                //dt = new DataTable();
                dt = DataSetYap(sorgu, komutTipi).Tables[0];
            }
            else
            {
                //dt = new DataTable(dataTableIsmi);
                dt = DataSetYap(sorgu, komutTipi, dataTableIsmi).Tables[dataTableIsmi];
            }

            return dt;
            //SqlDataAdapter da = new SqlDataAdapter();
            //da.SelectCommand = this.SqlCommandOlustur(sorgu, komutTipi);
            //this.ParametreleriEkle(da.SelectCommand);
            //try
            //{
            //    da.SelectCommand.Connection.Open();
            //    da.Fill(dt);
            //    return dt;
            //}
            //catch (Exception ex)
            //{
            //    throw new VeritabaniException(ex.Message);
            //}
            //finally
            //{
            //    da.SelectCommand.Connection.Close();
            //}

        }

        public DataTable DataTableYap(string sorgu, CommandType komutTipi)
        {
            return DataTableYap(sorgu, komutTipi, null);
        }



        // NULLABLE TYPE

        //---------------------------------------------------------------------
        // normalde value typelar (int,bool,double,char v.s.) null değer alamazlar. değişken tanımlarken bu değer tiplerinin sonuna ? koyarsak(int?,bool? v.s) artık bu tip null değer de alabilir hale gelir.,
        // string ler için bunu yapmamıza gerek yoktuır, çünkü string tip, hem değer tipi hem de referans tipidir. doğal olarak null olablir.
        //public void Deneme(int? s) { }
        //public void DenemeY()
        //{
        //    Deneme(null);
        //    Deneme(5);
        //}
    }
}
