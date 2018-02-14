using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = " ";

            IExamOperation cobj = new ExamOperation();
            try
            {
                do
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Get an appointment");
                    Console.WriteLine("2. View all students registered for specific exam");
                    Console.WriteLine("3. Number of students registered for specific exam");
                    Console.WriteLine("4.Cancel Booking by the registration number");
                    Console.WriteLine("5.View the list of the registered student");
                    Console.WriteLine("6. Exit");
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            IStudentDetails obj = new StudentDetails();
                            Console.WriteLine("Enter your name");
                            obj.Name = Console.ReadLine();
                            Console.WriteLine("Enter your daye of birth in mm/dd/yyy");
                            obj.Dateofbirth = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your gender M/F");
                            obj.Gender = Console.ReadLine();
                            Console.WriteLine("Enter your city");
                            obj.City = Console.ReadLine();
                            Console.WriteLine("Enter your ugpercentage");
                            obj.Ugper = float.Parse(Console.ReadLine());

                            if (obj.Ugper >= 80)
                            {
                                obj.Fees = 2000;

                            }
                            else
                            {
                                obj.Fees = 3000;
                            }
                            Console.WriteLine("Enter your exam center");
                            obj.Ecenter = Console.ReadLine();
                            Console.WriteLine("Enter your exam name");
                            obj.Ename = Console.ReadLine();

                            int cid = cobj.getappointmnet(obj);
                            cobj.display();

                            break;

                        case "2":
                            List<IStudentDetails> templist = new List<IStudentDetails>();
                            Console.WriteLine("Enter your exam name");
                            string exname = Console.ReadLine();
                            templist = cobj.viewbyexam(exname);
                            Console.Clear();
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Id\t\tName\t\tDateofbirth\t\tGender\t\tCity\t\tUGpercentage\t\tExam Center\t\tExam Name");
                            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                            foreach (IStudentDetails k in templist)
                            {
                                Console.Write(k.Id);
                                Console.Write("\t\t" + k.Name);
                                //string arr=Convert.ToString(k.Dateofbirth)
                                Console.Write("\t\t" + Convert.ToString(k.Dateofbirth).Split(' ')[0]);
                                Console.Write("\t\t" + k.Gender);
                                Console.Write("\t\t" + k.City);
                                Console.Write("\t\t" + k.Ugper);
                                Console.Write("\t\t" + k.Ecenter);
                                Console.Write("\t\t" + k.Ename);

                            }
                            
                            break;

                        case "3":
                            int d;
                            Console.WriteLine("Enter the exam name");
                            string ex_name = Console.ReadLine();
                            d = cobj.CountbyExam(ex_name);
                            Console.Clear();
                            Console.WriteLine("The count of candidate is" + d);
                            break;

                        case "4":
                            bool yes;
                            int id;
                            Console.WriteLine("Enter the id you want to delete");
                            id = Convert.ToInt16(Console.ReadLine());
                            yes = cobj.delete(id);
                            cobj.display();
                            break;

                        case "5":
                            cobj.display();
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Enter the correct choice");
                            break;

                    }

                } while (choice != "6");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
                
        }
    }
}
