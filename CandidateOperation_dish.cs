using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CandidateOperation : ICandidateOperation 
    {
       
        
            static List<ICandidate> reglst = new List<ICandidate>();
            public int RegisterJob(ICandidate Iobj)
            {
                reglst.Add(Iobj);
                return Iobj.CandidateId;
            }
            public List<ICandidate> View(string position)
            {
                List<ICandidate> TempLst = new List<ICandidate>();
                foreach (ICandidate bObj in reglst)
                {
                    if(bObj.Position.Equals(position))
                    {
                        TempLst.Add(bObj);
                    }
                }
                return TempLst;
            }
            public int CountList(string position)
            {
                int count = 0;
                foreach(ICandidate bObj in reglst)
                {
                    if(bObj.Position.Equals(position))
                    {
                    count++;
                    }
                }
                return count;
            }
            public int delete (int id)
            { int flag = 0;
            foreach(ICandidate bObj in reglst)
                {
                    if(bObj.CandidateId==id)
                    {
                        flag = 1;
                        reglst.Remove(bObj);
                        break;
                    }
                }
                return flag;
            }
        }
    }

