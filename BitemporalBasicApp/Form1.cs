﻿using BL;
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
    public partial class Form1 : Form
    {

        List<Person> personList = new List<Person>();

        public Form1(ObjectForCommit ofc)
        {
            
            ofc.personList = personList;
            InitializeComponent();
            lbl_branch.Text = Settings.Default.BranchName;
            lbl_commit.Text = Settings.Default.commitName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Settings.Default.commitID!=0  )
            {
                dataGrid_locationArchive.DataSource = null;
                Commit c = new Commit();
                c.ID = Convert.ToInt32(Settings.Default.commitID);
                dataGrid_locationArchive.DataSource = new PersonBL().getActualPersonOnSelectedCommit(c);
            }
            else
            dataGrid_locationArchive.DataSource = new PersonBL().getAllPersonRows();

            comboBox1.DataSource = new BranchBL().getAllValidBranches();
            comboBox1.DisplayMember = "BranchName";
            comboBox1.ValueMember = "BranchID";

            cmb_commits.DataSource = new CommitBL().getAllCommitsOnBranch(1);
            cmb_commits.DisplayMember = "name";
            cmb_commits.ValueMember = "ID";
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dataGrid_locationArchive.DataSource = null;

            dataGrid_locationArchive.DataSource = new PersonBL().getAllPersonRows();
        }


        private void btn_add_new_person_Click(object sender, EventArgs e)
        {
            frm_Person_Add frmPersonAdd = new frm_Person_Add(personList);



            frmPersonAdd.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGrid_locationArchive.SelectedRows.Count == 0 || dataGrid_locationArchive.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select 1 row");

            }
            else if (dataGrid_locationArchive.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Please select 1 valid row");
            }
            else
            {

                Person p = new Person();
                p.ID = Convert.ToInt32(dataGrid_locationArchive.SelectedRows[0].Cells[0].Value);
                p.PersonID = Convert.ToInt32(dataGrid_locationArchive.SelectedRows[0].Cells[1].Value);

                p.PersonName = (dataGrid_locationArchive.SelectedRows[0].Cells[2].Value).ToString();

                p.Location = (dataGrid_locationArchive.SelectedRows[0].Cells[3].Value).ToString();


                p.Valid_From = Convert.ToDateTime(dataGrid_locationArchive.SelectedRows[0].Cells[5].Value);

                frm_PersonEdit frm = new frm_PersonEdit(p, personList);
                frm.ShowDialog();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGrid_locationArchive.SelectedRows.Count == 0 || dataGrid_locationArchive.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select 1 row");

            }
            else if (dataGrid_locationArchive.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Please select 1 valid row");
            }
            else
            {

                Person p = new Person();
                p.ID = Convert.ToInt32(dataGrid_locationArchive.SelectedRows[0].Cells[0].Value);
                p.PersonID = Convert.ToInt32(dataGrid_locationArchive.SelectedRows[0].Cells[1].Value);
                p.PersonName = "" + (dataGrid_locationArchive.SelectedRows[0].Cells[2].Value);
                p.Location = "" + (dataGrid_locationArchive.SelectedRows[0].Cells[3].Value);
                p.TransType = 3;

                if (DialogResult.Yes == MessageBox.Show("Do you want delete this data?", "Warning", MessageBoxButtons.YesNo))
                {
                    // new PersonBL().DeletePerson(p);

                    personList.Add(p);
                }


            }
        }

        private void btn_refresh_valid_Click(object sender, EventArgs e)
        {
            dataGrid_locationArchive.DataSource = null;

          

            DataTable dt = new BookBL().getValidBookRows();


  
            dataGrid_locationArchive.DataSource = dt;



        }

        private void btn_Commit_Click(object sender, EventArgs e)
        {
            //frm_Commit frm = new frm_Commit(personList);
            //frm.Show();
        }

        private void btn_refresh_valid_on_branch_Click(object sender, EventArgs e)
        {

           
            if (cmb_commits.SelectedIndex >= 0)
            {
                Commit c = new Commit();
                c.ID = Convert.ToInt32(cmb_commits.SelectedValue);

                new CommitBL().changeVersion(c); // Sistemin Versiyonu değiştiriliyor
                
                dataGrid_locationArchive.DataSource = null;
               
                dataGrid_locationArchive.DataSource = new PersonBL().getActualPersonOnSelectedCommit(c);

                Settings.Default.commitID = Convert.ToInt32(cmb_commits.SelectedValue);
                Settings.Default.commitName = Convert.ToString(cmb_commits.Text);

                Settings.Default.branchID = Convert.ToInt32(comboBox1.SelectedValue);
                Settings.Default.BranchName = Convert.ToString(comboBox1.Text);

                Settings.Default.Save();

                lbl_branch.Text = Settings.Default.BranchName;
                lbl_commit.Text = Settings.Default.commitName;

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

        private void btn_addBookToPerson_Click(object sender, EventArgs e)
        {
            if (dataGrid_locationArchive.SelectedRows.Count == 0 || dataGrid_locationArchive.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select 1 row");

            }
            else if (dataGrid_locationArchive.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Please select 1 valid row");
            }
            else
            {

                Person p = new Person();
                p.ID = Convert.ToInt32(dataGrid_locationArchive.SelectedRows[0].Cells[0].Value);
                p.PersonID = Convert.ToInt32(dataGrid_locationArchive.SelectedRows[0].Cells[1].Value);

                p.PersonName = (dataGrid_locationArchive.SelectedRows[0].Cells[2].Value).ToString();

                p.Location = (dataGrid_locationArchive.SelectedRows[0].Cells[3].Value).ToString();


                p.Valid_From = Convert.ToDateTime(dataGrid_locationArchive.SelectedRows[0].Cells[5].Value);

                frm_SellBook frm = new frm_SellBook(p, personList);
                frm.Show ();
            }
        }

        private void btn_ShowBooksSelectedPerson_Click(object sender, EventArgs e)
        {
            if (dataGrid_locationArchive.SelectedRows.Count == 0 || dataGrid_locationArchive.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select 1 row");

            }
            else if (dataGrid_locationArchive.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Please select 1 valid row");
            }
            else
            {

                Person p = new Person();
                p.ID = Convert.ToInt32(dataGrid_locationArchive.SelectedRows[0].Cells[0].Value);
                p.PersonID = Convert.ToInt32(dataGrid_locationArchive.SelectedRows[0].Cells[1].Value);

                p.PersonName = (dataGrid_locationArchive.SelectedRows[0].Cells[2].Value).ToString();

                p.Location = (dataGrid_locationArchive.SelectedRows[0].Cells[3].Value).ToString();


                p.Valid_From = Convert.ToDateTime(dataGrid_locationArchive.SelectedRows[0].Cells[5].Value);

                frm_BooksByPerson frm = new frm_BooksByPerson(p );
                frm.Show();
            }
        }
    }
}
