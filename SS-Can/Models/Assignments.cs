using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SS_Can.Models
{
    public class Assignments
    {
        public Assignments()
        {
            Submissions = new HashSet<Submissions>();
        }

        public uint AssignmentId { get; set; }
        public string Name { get; set; }
        public string Contents { get; set; }
        public DateTime DueDate { get; set; }
        public uint MaxPoints { get; set; }
        public uint Category { get; set; }

        public virtual AssignmentCategories CategoryNavigation { get; set; }
        public virtual ICollection<Submissions> Submissions { get; set; }
    }
}
