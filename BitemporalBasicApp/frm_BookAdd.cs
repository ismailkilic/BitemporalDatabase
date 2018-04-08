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
    public partial class frm_BookAdd : Form
    {
        List<Book> bList;
        public frm_BookAdd()
        {
            InitializeComponent();
        }
        public frm_BookAdd(List<Book> bookList)
        {
            bList = bookList;
            InitializeComponent();

        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.BookName = txt_name.Text;
            b.author = txt_location.Text;

            b.Valid_From = DateTime.Now;
            b.TransType = 1;
            bList.Add(b);

            this.Close();
        }
    }
}
