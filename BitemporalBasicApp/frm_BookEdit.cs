using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitemporalBasicApp
{
    public partial class frm_BookEdit : Form
    {
        Book book = new Book();
        List<Book> plist;

     
        public frm_BookEdit(Book b, List<Book> bookList)
        {
            InitializeComponent();
            book = b;


            txt_name.Text = b.BookName;
            txt_location.Text = b.author;

             

            plist = bookList;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            book.BookName = txt_name.Text;
            book.author = txt_location.Text;

            book.Valid_From = DateTime.Now;
            book.TransType = 2;
      
            plist.Add(book);
            this.Close();
        }
    }
}
