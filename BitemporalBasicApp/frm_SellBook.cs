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
    public partial class frm_SellBook : Form
    {
        List<Person> personList = new List<Person>();
        Person person;
        public frm_SellBook(Person p, List<Person> personList)
        {
            InitializeComponent();
            person = p;
            this.personList = personList;
        }

        private void frm_SellBook_Load(object sender, EventArgs e)
        {
            lbl_PersonID.Text = person.ID.ToString();
            lbl_PersonName.Text = person.PersonName;

            lbl_commit.Text = Settings.Default.commitName;
            lbl_branch.Text = Settings.Default.BranchName;

          //  dataGridView1.DataSource = null;
            Commit c = new Commit();
            c.ID = Convert.ToInt32(Settings.Default.commitID);
            dataGridView1.DataSource = new BookBL().getActualBookOnSelectedCommit(c);

            lsb_cart.DataSource = person.bookList;
            lsb_cart.DisplayMember = "BookName";
            lsb_cart.ValueMember = "BookID";
            

        }

        private void btn_AddtoCart_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 || dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select 1 row");

            }
            else if (dataGridView1.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Please select 1 valid row");
            }
            else
            {

                Book b = new Book();
                b.ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                b.BookID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);

                b.BookName = (dataGridView1.SelectedRows[0].Cells[2].Value).ToString();
                b.author = (dataGridView1.SelectedRows[0].Cells[3].Value).ToString();
                b.Valid_From = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[5].Value);


                person.bookList.Add(b);
                lsb_cart.DataSource = null;
                lsb_cart.DataSource = person.bookList;

                lsb_cart.DisplayMember = "BookName";
                lsb_cart.ValueMember = "BookID";
 
            }
        }

        private void btn_deletefromList_Click(object sender, EventArgs e)
        {
            person.bookList.Remove((Book)lsb_cart.SelectedItem);
            lsb_cart.DataSource = null;
            lsb_cart.DataSource = person.bookList;

            lsb_cart.DisplayMember = "BookName";
            lsb_cart.ValueMember = "BookID";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personList.Add(person);
            this.Close();
        }
    }
}
