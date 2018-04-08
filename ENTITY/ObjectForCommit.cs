using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class ObjectForCommit
    {
        public ObjectForCommit()
        {
            personList = new List<Person>();
            bookList = new List<Book>();
        }

        public List<Person> personList { get; set; }
        public List<Book> bookList { get; set; }

      






    }
}
