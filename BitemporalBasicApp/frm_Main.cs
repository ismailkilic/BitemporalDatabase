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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        ObjectForCommit ofc = new ObjectForCommit();


        private void btn_frmperson_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(ofc);
            frm.Show();
        }

        private void btn_frmBook_Click(object sender, EventArgs e)
        {
            frm_Book frm = new frm_Book(ofc);
            frm.Show();
        }

        private void btn_Commit_Click(object sender, EventArgs e)
        {
            frm_Commit frm = new frm_Commit(ofc);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_CommitHistory frm = new frm_CommitHistory();
            frm.Show();
        }
    }
}
