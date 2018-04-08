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
   public class BookBL
    {
        VeritabaniSaglayici vt = new VeritabaniSaglayici();

        public DataTable getAllBookRows( )
        {

           
            vt.ParametreleriTemizle();
             
            return vt.DataTableYap("sp_getAllBook", CommandType.StoredProcedure);
        }
        public DataTable getValidBookRows()
        {


            vt.ParametreleriTemizle();

            return vt.DataTableYap("sp_getValidBook", CommandType.StoredProcedure);
        }

        public DataTable getChangesForABook(int Book_id)
        {

            vt.ParametreleriTemizle();
            vt.InParametreleriEkle("@book_id", DbType.Int32,Book_id);

            return vt.DataTableYap("sp_getChangesForABook", CommandType.StoredProcedure);
        }


        public DataTable getBookOnBranch(int Branch_id)
        {

            vt.ParametreleriTemizle();
            vt.InParametreleriEkle("@Branch_id", DbType.Int32, Branch_id);

            return vt.DataTableYap("sp_getBookOnBranch", CommandType.StoredProcedure);
        }

        public DataTable getBookOnMaster(Commit c)
        {

            vt.ParametreleriTemizle();
            vt.InParametreleriEkle("@CommitDate", DbType.DateTime, c.date);

            return vt.DataTableYap("sp_getBookOnMaster_New", CommandType.StoredProcedure);
        }
        public DataTable getActualBookOnSelectedCommit(Commit c)
        {

            vt.ParametreleriTemizle();
            vt.InParametreleriEkle("@CommitID", DbType.Int32, c.ID);

            return vt.DataTableYap("sp_getActualBookOnSelectedCommit", CommandType.StoredProcedure);
        }


        public List<Book> getAllChangesForBook()
        {
            List<Book> listBook = new List<Book>();
            vt.ParametreleriTemizle();
            SqlDataReader dr;

            dr = vt.ExecuteReaderYap("sp_getAllChangesForBook", System.Data.CommandType.StoredProcedure);



            while (dr.Read())
            {
                Book u = new Book();
                u.BookID = (int)dr["Book_id"];
                listBook.Add(u);


            }

            return listBook;
        }

        public void AddBook(Book p)
        {
            vt.ParametreleriTemizle();
            vt.InParametreleriEkle("@bookName", DbType.String, p.BookName);
            vt.InParametreleriEkle("@author", DbType.String, p.author);
            vt.InParametreleriEkle("@Valid_from", DbType.DateTime, p.Valid_From);

            try
            {
                vt.ExecuteNonQueryYap("sp_AddBook", System.Data.CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EditBook(Book p,int branchID)
        {

            
            vt.ParametreleriTemizle();
            vt.InParametreleriEkle("@ID", DbType.Int32, p.ID);
            vt.InParametreleriEkle("@bookName", DbType.String, p.BookName);
            vt.InParametreleriEkle("@author", DbType.String, p.author);
            vt.InParametreleriEkle("@Valid_from", DbType.DateTime, p.Valid_From);
            vt.InParametreleriEkle("@BranchID", DbType.Int32, branchID);



            try
            {
                vt.ExecuteNonQueryYap("sp_EditBook", System.Data.CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void DeleteBook(Book p, int branchID)
        {


            vt.ParametreleriTemizle();
            vt.InParametreleriEkle("@ID", DbType.Int32, p.ID);
            vt.InParametreleriEkle("@BranchID", DbType.Int32, branchID);


            try
            {
                vt.ExecuteNonQueryYap("sp_DeleteBook", System.Data.CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
