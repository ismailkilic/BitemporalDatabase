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
   public class CommitBL
    {
        VeritabaniSaglayici vt = new VeritabaniSaglayici();

   
 

        public void doCommit(Commit c)
        {
            vt.ParametreleriTemizle();
            vt.InParametreleriEkle("@CommitName", DbType.String, c.name);
            vt.InParametreleriEkle("@BranchID", DbType.Int32, c.branchID);
           

            try
            {
                vt.ExecuteNonQueryYap("sp_doCommit", System.Data.CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public List<Commit> getAllCommits()
        {
            List<Commit> listCommit = new List<Commit>();
            vt.ParametreleriTemizle();
            SqlDataReader dr;

            dr = vt.ExecuteReaderYap("sp_getAllCommits", System.Data.CommandType.StoredProcedure);



            while (dr.Read())
            {
                Commit c = new Commit();
                c.ID = (int)dr["id"];
                c.name = (string)dr["name"];

                c.date = (DateTime)dr["date"];

                c.branchID = (int)dr["branchID"];
                if (dr["commitPrevious"] != DBNull.Value)
                {
                    c.commitPrevious = (string)dr["commitPrevious"];
                }
                else
                {
                    c.commitPrevious = "Start";
                }
            
                c.commitHash = (string)dr["commitHash"];

                listCommit.Add(c);


            }

            return listCommit;
        }

        public DataTable getAllChangesOnCommit(int commitID)
        {

            vt.ParametreleriTemizle();
            vt.InParametreleriEkle("@commitID", DbType.Int32, commitID);

            return vt.DataTableYap("sp_getAllChangesOnCommit", CommandType.StoredProcedure);
        }


    }
}
