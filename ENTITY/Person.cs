using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Person
    {

        public Person()
        { bookList = new List<Book>(); }
        public int ID { get; set; }
        public int PersonID { get; set; }
        public List<Book> bookList { get; set; }
        public string PersonName { get; set; }
        public string Location { get; set; }
        public DateTime Valid_From { get; set; }
        public DateTime Valid_To { get; set; }
        public DateTime Trans_From { get; set; }
        public DateTime Trans_To { get; set; }
        public int TransType { get; set; }





    }
}
