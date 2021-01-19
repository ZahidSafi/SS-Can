using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SS_Can.Models
{
    public class Submissions
    {
        public uint Student { get; set; }
        public uint Assignment { get; set; }
        public DateTime Time { get; set; }
        public string Contents { get; set; }
        public uint Score { get; set; }

        public virtual Assignments AssignmentNavigation { get; set; }
        public virtual Student StudentNavigation { get; set; }
    }
}
