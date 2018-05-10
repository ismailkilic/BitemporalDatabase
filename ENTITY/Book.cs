using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Book
    {   public int ID { get; set; }
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string author { get; set; }
        public DateTime Valid_From { get; set; }
        public DateTime Valid_To { get; set; }
        public DateTime Trans_From { get; set; }
        public DateTime Trans_To { get; set; }
        public int TransType { get; set; }
        public int commitID { get; set; }}
}
