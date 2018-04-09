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
    public partial class frm_Commit : Form
    {
        public frm_Commit()
        {
            InitializeComponent();



        }
        ObjectForCommit ofc;
        public frm_Commit(ObjectForCommit ofc)
        {
            InitializeComponent();
            if (Settings.Default.branchID != 0)
            {
                lbl_Branch.Text = Settings.Default.BranchName;
            }
            comboBox1.DataSource = new BranchBL().getAllValidBranches();
            comboBox1.DisplayMember = "BranchName";
            comboBox1.ValueMember = "BranchID";
            this.ofc = ofc;

        }

        private void frm_Commit_Load(object sender, EventArgs e)
        {


            //
            TreeNode node2 = new TreeNode("C#");
            TreeNode node3 = new TreeNode("VB.NET");
            TreeNode[] array = new TreeNode[] { node2, node3 };
            //
            // Final node.
            //
            TreeNode treeNode = new TreeNode("Person Table");

            treeView1.Nodes.Add(treeNode);
            treeView1.Nodes[0].Nodes.Add("new Inserts - " + ((from x in ofc.personList where x.TransType == 1 select x).Count()));
            treeView1.Nodes[0].Nodes.Add("new Updates - " + ((from x in ofc.personList where x.TransType == 2 select x).Count()));
            treeView1.Nodes[0].Nodes.Add("new Deletes - " + ((from x in ofc.personList where x.TransType == 3 select x).Count()));


            TreeNode treeNode1 = new TreeNode("Book Table");

            treeView1.Nodes.Add(treeNode1);
            treeView1.Nodes[1].Nodes.Add("new Inserts - " + ((from x in ofc.bookList where x.TransType == 1 select x).Count()));
            treeView1.Nodes[1].Nodes.Add("new Updates - " + ((from x in ofc.bookList where x.TransType == 2 select x).Count()));
            treeView1.Nodes[1].Nodes.Add("new Deletes - " + ((from x in ofc.bookList where x.TransType == 3 select x).Count()));

            TreeNode treeNode2 = new TreeNode("Sales Table");

            treeView1.Nodes.Add(treeNode2);
            treeView1.Nodes[2].Nodes.Add("new Inserts - " + ((from x in ofc.personList from b in x.bookList select b).Count()));







            //foreach (var p in (personList))
            //{

            //    treeView1.Nodes[0].Nodes.Add(p.PersonID.ToString());
            //}


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dataGridView1.DataSource = null;

            if (e.Node.Parent != null)
            {
                DataTable dt = new DataTable();

                #region Person Table


                if (e.Node.Parent.Text == "Person Table")
                {
                    dt.Columns.Add("Identity  ID", typeof(string));
                    dt.Columns.Add("Name", typeof(string));
                    dt.Columns.Add("Location", typeof(string));
                    dt.Columns.Add("ValidDate", typeof(string));

                    if (e.Node.Text.Contains("Insert"))
                    {
                        foreach (var p in (from x in ofc.personList where x.TransType == 1 select x))
                        {
                            DataRow row = dt.NewRow();
                            row[1] = p.PersonName;
                            row[2] = p.Location;
                            row[3] = p.Valid_From;

                            dt.Rows.Add(row);
                            dt.AcceptChanges();
                        }
                    }
                    else if (e.Node.Text.Contains("Update"))
                    {
                        foreach (var p in (from x in ofc.personList where x.TransType == 2 select x))
                        {
                            DataRow row = dt.NewRow();
                            row[0] = p.ID;
                            row[1] = p.PersonName;
                            row[2] = p.Location;
                            row[3] = p.Valid_From;

                            dt.Rows.Add(row);
                            dt.AcceptChanges();
                        }
                    }
                    else if (e.Node.Text.Contains("Delete"))
                    {
                        foreach (var p in (from x in ofc.personList where x.TransType == 3 select x))
                        {
                            DataRow row = dt.NewRow();
                            row[0] = p.ID;
                            row[1] = p.PersonName;
                            row[2] = p.Location;
                            row[3] = p.Valid_From;

                            dt.Rows.Add(row);
                            dt.AcceptChanges();
                        }
                    }

                }
                #endregion
                #region Book Table
                if (e.Node.Parent.Text == "Book Table")
                {
                    dt.Columns.Add("Identity  ID", typeof(string));
                    dt.Columns.Add("Name", typeof(string));
                    dt.Columns.Add("Author", typeof(string));
                    dt.Columns.Add("ValidDate", typeof(string));

                    if (e.Node.Text.Contains("Insert"))
                    {
                        foreach (var p in (from x in ofc.bookList where x.TransType == 1 select x))
                        {
                            DataRow row = dt.NewRow();
                            row[1] = p.BookName;
                            row[2] = p.author;
                            row[3] = p.Valid_From;

                            dt.Rows.Add(row);
                            dt.AcceptChanges();
                        }
                    }
                    else if (e.Node.Text.Contains("Update"))
                    {
                        foreach (var p in (from x in ofc.bookList where x.TransType == 2 select x))
                        {
                            DataRow row = dt.NewRow();
                            row[0] = p.ID;
                            row[1] = p.BookName;
                            row[2] = p.author;
                            row[3] = p.Valid_From;

                            dt.Rows.Add(row);
                            dt.AcceptChanges();
                        }
                    }
                    else if (e.Node.Text.Contains("Delete"))
                    {
                        foreach (var p in (from x in ofc.bookList where x.TransType == 3 select x))
                        {
                            DataRow row = dt.NewRow();
                            row[0] = p.ID;
                            row[1] = p.BookName;
                            row[2] = p.author;
                            row[3] = p.Valid_From;

                            dt.Rows.Add(row);
                            dt.AcceptChanges();
                        }
                    }
                }

                #endregion

                #region Sales Table
                if (e.Node.Parent.Text == "Sales Table")
                {
                    dt.Columns.Add("personID", typeof(string));
                    dt.Columns.Add("PersonName", typeof(string));
                    dt.Columns.Add("BookName", typeof(string));
                    dt.Columns.Add("Author", typeof(string));

                    if (e.Node.Text.Contains("Insert"))
                    {
                        foreach (var p in (from x in ofc.personList where x.bookList.Count > 0 select x))
                        {
                            foreach (var b in p.bookList)
                            {
                                DataRow row = dt.NewRow();
                                row[0] = p.PersonID;
                                row[1] = p.PersonName;
                                row[2] = b.BookName;
                                row[3] = b.author;

                                dt.Rows.Add(row);
                                dt.AcceptChanges();
                            }

                        }
                    }

                }

                #endregion

                dataGridView1.DataSource = dt;
                //  dataGridView1.DataSource = new PersonBL().getChangesForAPerson(Convert.ToInt32(e.Node.Text));
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Settings.Default.branchID != 0)
            {


                if (DialogResult.Yes == MessageBox.Show("Do you want commit?", "Warning", MessageBoxButtons.YesNo))
                {
                    #region forPerson

                    foreach (var p in (from x in ofc.personList where x.TransType == 1 select x))
                    {
                        new PersonBL().AddPerson(p);
                    }

                    foreach (var p in (from x in ofc.personList where x.TransType == 2 select x))
                    {
                        new PersonBL().EditPerson(p, Convert.ToInt32(comboBox1.SelectedValue.ToString()));
                    }

                    foreach (var p in (from x in ofc.personList where x.TransType == 3 select x))
                    {
                        new PersonBL().DeletePerson(p, Convert.ToInt32(comboBox1.SelectedValue.ToString()));
                    }
                    #endregion

                    #region forBook

                    foreach (var p in (from x in ofc.bookList where x.TransType == 1 select x))
                    {
                        new BookBL().AddBook(p);
                    }

                    foreach (var p in (from x in ofc.bookList where x.TransType == 2 select x))
                    {
                        new BookBL().EditBook(p, Convert.ToInt32(comboBox1.SelectedValue.ToString()));
                    }

                    foreach (var p in (from x in ofc.bookList where x.TransType == 3 select x))
                    {
                        new BookBL().DeleteBook(p, Convert.ToInt32(comboBox1.SelectedValue.ToString()));
                    }
                    #endregion
                    #region forSales

                    
                        foreach (var p in (from x in ofc.personList where x.bookList.Count > 0 select x))
                        {
                            foreach (var b in p.bookList)
                            {
                                   new PersonBL().SellBookToPerson(p,b);

                            }

                        }

                    

                   
                    #endregion


                    Commit c = new Commit();
                    c.name = textBox1.Text;
                    c.branchID = Convert.ToInt32(Settings.Default.branchID);
                    new CommitBL().doCommit(c);


                    ofc = new ObjectForCommit();


                }
            }
            else
            {
                MessageBox.Show("Please select a branch and Current Commit before Commit!");
            }
        }

        private void btn_commitHistory_Click(object sender, EventArgs e)
        {

            frm_CommitHistory frm = new frm_CommitHistory();
            frm.ShowDialog();
        }
    }
}
