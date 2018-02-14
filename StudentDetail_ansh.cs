
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class StudentDetails:IStudentDetails
    {
        static public int a = 5000;
        int id;
        string name;
        DateTime dateofbirth;
        string gender;
        string city;
        float ugper;
        string ecenter; // it will be TVM or AHD
        string ename; //problem solving, ASP.NET layering, ASP.NET MVC
        int fees;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public DateTime Dateofbirth
        {
            get
            {
                return dateofbirth;
            }

            set
            {
                dateofbirth = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public float Ugper
        {
            get
            {
                return ugper;
            }

            set
            {
                ugper = value;
            }
        }

        public string Ecenter
        {
            get
            {
                return ecenter;
            }

            set
            {
                ecenter = value;
            }
        }

        public string Ename
        {
            get
            {
                return ename;
            }

            set
            {
                ename = value;
            }
        }

        public int Fees
        {
            get
            {
                return fees;
            }

            set
            {
                fees = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public StudentDetails()
        {
            id = a++;
        }
        public StudentDetails(string sname,DateTime sdateofbirth,string sgender,string scity,float sugper,string secenter,string sename)
        {
            sname = name;
            sdateofbirth = dateofbirth;
            sgender = gender;
            scity = city;
            sugper = ugper;
            secenter = ecenter;
            sename = ename;



        }
    }
    
}
