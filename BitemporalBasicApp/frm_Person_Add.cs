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
    public partial class frm_Person_Add : Form
    {

        List<Person> pList;
        public frm_Person_Add()

        {
            InitializeComponent();
        }

        public frm_Person_Add(List<Person> personList)
        {
            pList = personList;
            InitializeComponent();

        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.PersonName = txt_name.Text;
            p.Location = txt_location.Text;

            p.Valid_From = dt_validfrom.Value;
            p.TransType = 1;
            pList.Add(p);
           
            this.Close();
        }
    }
}
