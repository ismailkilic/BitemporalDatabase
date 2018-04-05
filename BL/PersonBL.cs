﻿using DAL;
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
   public class PersonBL
    {
        VeritabaniSaglayici vt = new VeritabaniSaglayici();

        public DataTable getAllPersonRows( )
        {

           
            vt.ParametreleriTemizle();
             
            return vt.DataTableYap("sp_getAllPerson", CommandType.StoredProcedure);
        }
        public DataTable getValidPersonRows()
        {


            vt.ParametreleriTemizle();

            return vt.DataTableYap("sp_getValidPerson", CommandType.StoredProcedure);
        }

        public DataTable getChangesForAPerson(int person_id)
        {

            vt.ParametreleriTemizle();
            vt.InParametreleriEkle("@person_id", DbType.Int32,person_id);

            return vt.DataTableYap("sp_getChangesForAPerson", CommandType.StoredProcedure);
        }


        public DataTable getPersonOnBranch(int Branch_id)
        {

            vt.ParametreleriTemizle();
            vt.InParametreleriEkle("@Branch_id", DbType.Int32, Branch_id);

            return vt.DataTableYap("sp_getPersonOnBranch", CommandType.StoredProcedure);
        }

        public DataTable getPersonOnMaster(Commit c)
        {

            vt.ParametreleriTemizle();
            vt.InParametreleriEkle("@CommitDate", DbType.DateTime, c.date);

            return vt.DataTableYap("sp_getPersonOnMaster_New", CommandType.StoredProcedure);
        }


        public List<Person> getAllChangesForPerson()
        {
            List<Person> listPerson = new List<Person>();
            vt.ParametreleriTemizle();
            SqlDataReader dr;

            dr = vt.ExecuteReaderYap("sp_getAllChangesForPerson", System.Data.CommandType.StoredProcedure);



            while (dr.Read())
            {
                Person u = new Person();
                u.PersonID = (int)dr["person_id"];
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

        public void EditPerson(Person p)
        {

            
            vt.ParametreleriTemizle();
            vt.InParametreleriEkle("@ID", DbType.Int32, p.ID);
            vt.InParametreleriEkle("@PersonName", DbType.String, p.PersonName);
            vt.InParametreleriEkle("@Location", DbType.String, p.Location);
            vt.InParametreleriEkle("@Valid_from", DbType.DateTime, p.Valid_From);
            

            try
            {
                vt.ExecuteNonQueryYap("sp_EditPerson", System.Data.CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void DeletePerson(Person p)
        {


            vt.ParametreleriTemizle();
            vt.InParametreleriEkle("@ID", DbType.Int32, p.ID);
         


            try
            {
                vt.ExecuteNonQueryYap("sp_DeletePerson", System.Data.CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}