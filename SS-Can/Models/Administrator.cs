using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SS_Can.Models
{
    public class Administrator
    {
        public uint ssID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime Dob { get; set; }
    }
}
