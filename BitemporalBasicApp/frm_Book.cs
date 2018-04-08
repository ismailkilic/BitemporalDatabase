using BL;
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
    public partial class frm_Book : Form
    {
        List<Book> bookList = new List<Book>();
        public frm_Book(ObjectForCommit ofc)
        {
            InitializeComponent();
            ofc.bookList = bookList;

            dataGrid_Archive.DataSource = new BookBL().getAllBookRows();

            comboBox1.DataSource = new BranchBL().getAllValidBranches();
            comboBox1.DisplayMember = "BranchName";
            comboBox1.ValueMember = "BranchID";

            cmb_commits.DataSource = new CommitBL().getAllCommitsOnBranch(1);
            cmb_commits.DisplayMember = "name";
            cmb_commits.ValueMember = "ID";
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dataGrid_Archive.DataSource = null;

            dataGrid_Archive.DataSource = new BookBL().getAllBookRows();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGrid_Archive.SelectedRows.Count == 0 || dataGrid_Archive.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select 1 row");

            }
            else if (dataGrid_Archive.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Please select 1 valid row");
            }
            else
            {

                Book b = new Book();
                b.ID = Convert.ToInt32(dataGrid_Archive.SelectedRows[0].Cells[0].Value);
                b.BookID = Convert.ToInt32(dataGrid_Archive.SelectedRows[0].Cells[1].Value);

                b.BookName = (dataGrid_Archive.SelectedRows[0].Cells[2].Value).ToString();

                b.author = (dataGrid_Archive.SelectedRows[0].Cells[3].Value).ToString();


                b.Valid_From = Convert.ToDateTime(dataGrid_Archive.SelectedRows[0].Cells[5].Value);

                frm_BookEdit frm = new frm_BookEdit(b, bookList);
                frm.ShowDialog();
            }
        }

        private void btn_add_new_person_Click(object sender, EventArgs e)
        {
            frm_BookAdd frmBookAdd = new frm_BookAdd(bookList);



            frmBookAdd.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGrid_Archive.SelectedRows.Count == 0 || dataGrid_Archive.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select 1 row");

            }
            else if (dataGrid_Archive.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Please select 1 valid row");
            }
            else
            {

                Book b = new Book();
                b.ID = Convert.ToInt32(dataGrid_Archive.SelectedRows[0].Cells[0].Value);
                b.BookID = Convert.ToInt32(dataGrid_Archive.SelectedRows[0].Cells[1].Value);
                b.BookName = "" + (dataGrid_Archive.SelectedRows[0].Cells[2].Value);
                b.author = "" + (dataGrid_Archive.SelectedRows[0].Cells[3].Value);
                b.TransType = 3;

                if (DialogResult.Yes == MessageBox.Show("Do you want delete this data?", "Warning", MessageBoxButtons.YesNo))
                {
                    // new PersonBL().DeletePerson(p);

                    bookList.Add(b);
                }


            }
        }

        private void btn_refresh_valid_on_branch_Click(object sender, EventArgs e)
        {
            if (cmb_commits.SelectedIndex >= 0)
            {
                dataGrid_Archive.DataSource = null;
                Commit c = new Commit();
                c.ID = Convert.ToInt32(cmb_commits.SelectedValue);
                dataGrid_Archive.DataSource = new BookBL().getActualBookOnSelectedCommit(c);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_commits.Text = "";
            try
            {
                cmb_commits.DataSource = new CommitBL().getAllCommitsOnBranch(Convert.ToInt32(comboBox1.SelectedValue));
                cmb_commits.DisplayMember = "name";
                cmb_commits.ValueMember = "ID";
            }
            catch (Exception)
            {


            }
        }
    }
}
