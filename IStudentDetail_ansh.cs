using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    interface IStudentDetails
    {
        int Id { get; set; }
        string Name { get; set; }
        DateTime Dateofbirth { get; set; }
        string Gender { get; set; }
        string City { get; set; }
        float Ugper { get; set; }
        string Ecenter { get; set; }
        string Ename { get; set; }
        int Fees { get; set; }
    }
}
