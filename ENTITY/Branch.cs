using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Branch
    {
        public int ID { get; set; }

        public int BranchID { get; set; }
        public string BranchName { get; set; }
        public string TransType { get; set; }

        public DateTime Valid_From { get; set; }
        public DateTime Valid_To { get; set; }

        public DateTime Trans_From { get; set; }
        public DateTime Trans_To { get; set; }

        public string CommitPrevious { get; set; }
        public string BranchPrevious { get; set; }

        public string BranchHash { get; set; }
       






    }
}
