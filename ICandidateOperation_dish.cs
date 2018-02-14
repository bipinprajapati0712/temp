using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface ICandidateOperation
    {
        int RegisterJob(ICandidate Iobj);
        List<ICandidate> View(string position);
        int CountList(string position);
        int delete(int id);
    }
}
