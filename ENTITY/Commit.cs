using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Commit
    {
        public int ID { get; set; }

        public string name { get; set; }
        public int branchID { get; set; }
        public DateTime date { get; set; }


        public string commitPrevious { get; set; }
        public string commitHash { get; set; }







    }
}
