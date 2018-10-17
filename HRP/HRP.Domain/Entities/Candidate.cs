using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRP.Domain.Entities
{
    public class Candidate
    {
        public int CandidateID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Education { get; set; }
        public string University { get; set; }
        public string StreetAddress { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetCity { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
