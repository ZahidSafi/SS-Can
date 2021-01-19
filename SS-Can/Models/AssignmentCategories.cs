using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SS_Can.Models
{
    public class AssignmentCategories
    {
        public AssignmentCategories()
        {
            Assignments = new HashSet<Assignments>();
        }

        public uint CategoryId { get; set; }
        public uint Weight { get; set; }
        public string Name { get; set; }
        public uint Class { get; set; }

        public virtual Classes ClassNavigation { get; set; }
        public virtual ICollection<Assignments> Assignments { get; set; }
    }
}
