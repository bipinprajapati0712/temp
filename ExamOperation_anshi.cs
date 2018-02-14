using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class ExamOperation:IExamOperation
    {
        List<IStudentDetails> lst = new List<IStudentDetails>();

        public int getappointmnet(IStudentDetails a)
        {
            lst.Add(a);
            return a.Id;
        }
        public List<IStudentDetails> viewbyexam(string ename)
        {
            List<IStudentDetails> templst = new List<IStudentDetails>();
            foreach(IStudentDetails k in lst)
            {
                if(k.Ename.Equals(ename))
                {
                    templst.Add(k);
                }
            }
            return templst;
        }

        public int CountbyExam(string ename)
        {
            int c = 0;
            foreach(IStudentDetails k in lst)
            {
                if(k.Ename==ename)
                {
                    c++;
                }
            }
            return c;

        }
        public bool delete(int sid)
        {
            foreach(IStudentDetails k in lst)
            {
                if(k.Id==sid)
                {
                    lst.Remove(k);
                    return true;
                }
            }
            return false;
        }
        public void display()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Id\t\tName\t\tDateofbirth\t\tGender\t\tCity\t\tUGpercentage\t\tExam Center\t\tExam Name");
            Console.WriteLine("---------------------------------------------------------------------");
            foreach(IStudentDetails k in lst)
            {
                Console.Write(k.Id);
                Console.Write("\t\t" + k.Name);
                //string arr=Convert.ToString(k.Dateofbirth)
                Console.Write("\t\t" + Convert.ToString(k.Dateofbirth).Split(' ')[0]);
                Console.Write("\t\t" + k.Gender);
                Console.Write("\t\t" + k.City);
                Console.Write("\t\t" + k.Ugper);
                Console.Write("\t\t" + k.Ecenter);
                Console.WriteLine("\t\t" + k.Ename);


            }
        }
    }
}
