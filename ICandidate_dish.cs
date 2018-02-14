using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface ICandidate
    {
        int CandidateId { get; set; }
        string Name { get; set; }
        DateTime Dob { get; set; }
        string Gender { get; set; }
        string City { get; set; }
        double Ugpercentage { get; set; }
        string Position { get; set; }
    }
}
