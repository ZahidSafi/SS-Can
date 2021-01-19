using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SS_Can.Models
{
    public class Student
    {

        public Student()
        {
            Submissions = new HashSet<Submissions>();
        }
        public uint ssID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Class { get; set; }

        public virtual Enrolled EnrolledNavigation { get; set; }
        public virtual ICollection<Submissions> Submissions { get; set; }

    }
}
