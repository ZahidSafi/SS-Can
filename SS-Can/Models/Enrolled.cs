using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SS_Can.Models
{
    public class Enrolled
    {
        public uint Student { get; set; }
        public uint ClassId { get; set; }
        public string Grade { get; set; }

        public virtual Classes Class { get; set; }
        public virtual Student StudentNavigation { get; set; }
    }
}
