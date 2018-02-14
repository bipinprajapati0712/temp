using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    interface IExamOperation
    {
        int getappointmnet(IStudentDetails a);
        List<IStudentDetails> viewbyexam(string ename);
        int CountbyExam(string ename);
        bool delete(int sid);
        void display();
    }
}
