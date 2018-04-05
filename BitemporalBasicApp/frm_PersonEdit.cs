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
    public partial class frm_PersonEdit : Form
    {

        Person person = new Person();
        List<Person> plist;
        public frm_PersonEdit()
        {
            InitializeComponent();
        }
        public frm_PersonEdit(Person p, List<Person> personList)
        {
            InitializeComponent();
            person = p;


            txt_name.Text= p.PersonName  ;
            txt_location.Text= p.Location ;

            dt_validfrom.Value= p.Valid_From  ;

            plist = personList;
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            
            person.PersonName = txt_name.Text;
            person.Location = txt_location.Text;

            person.Valid_From = dt_validfrom.Value;
            person.TransType = 2;
            // new PersonBL().EditPerson(person);
            plist.Add(person);
            this.Close();
        }
    }
}
