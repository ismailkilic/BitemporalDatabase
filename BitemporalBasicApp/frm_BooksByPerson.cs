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
    public partial class frm_BooksByPerson : Form
    {
        Person p;
        public frm_BooksByPerson(Person p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void frm_BooksByPerson_Load(object sender, EventArgs e)
        {

            if (Settings.Default.commitID != 0)
            {
                dataGridView1.DataSource = null;
                Commit c = new Commit();
                c.ID = Convert.ToInt32(Settings.Default.commitID);
                dataGridView1.DataSource = new PersonBL().getBooksByPerson(p, c);
            }
            else {
                MessageBox.Show("Please select a current Commit!");

                this.Close();
            }


        }

        private void frm_BooksByPerson_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
