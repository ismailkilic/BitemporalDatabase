using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class BranchBL
    {
        VeritabaniSaglayici vt = new VeritabaniSaglayici();

        public DataTable getAllValidBranchesassasa( )
        {

           
            vt.ParametreleriTemizle();
             
            return vt.DataTableYap("sp_getAllValidBranches", CommandType.StoredProcedure);
        }


       

        public List<Branch> getAllValidBranches()
        {
            List<Branch> listPerson = new List<Branch>();
            vt.ParametreleriTemizle();
            SqlDataReader dr;

            dr = vt.ExecuteReaderYap("sp_getAllValidBranches", System.Data.CommandType.StoredProcedure);



            while (dr.Read())
            {
                Branch u = new Branch();
                u.BranchID = (int)dr["branch_id"];
                u.BranchName = (string)dr["branch_name"];

                listPerson.Add(u);


            }

            return listPerson;
        }



        public void AddPerson(Person p)
        {
            vt.ParametreleriTemizle();
            vt.InParametreleriEkle("@PersonName", DbType.String, p.PersonName);
            vt.InParametreleriEkle("@Location", DbType.String, p.Location);
            vt.InParametreleriEkle("@Valid_from", DbType.DateTime, p.Valid_From);

            try
            {
                vt.ExecuteNonQueryYap("sp_AddPerson", System.Data.CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
 



    }
}
