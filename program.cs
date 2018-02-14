using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICandidate> lst = new List<ICandidate>();
            string choice="";
            ICandidateOperation s = new CandidateOperation();
          //  throw new Exception("pleae selecy correcty optopn ");
            
            do
            {
                try {
                    Console.WriteLine("\t\t\t\t\tCANDIDATE JOB REGISTRATION PORTAL");
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    Console.WriteLine("\t\t\tMENU");
                    Console.WriteLine("1.Register for a Job");
                    Console.WriteLine("2.View all candidate registered for a specific job");
                    Console.WriteLine("3.Number of candidate registerd for a specific job");
                    Console.WriteLine("4.Cancel the registration by the registaration id");
                    Console.WriteLine("5.Exit");
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            ICandidate new1 = new Candidate();
                            Console.WriteLine("Enter Candidate name");
                            new1.Name1 = Console.ReadLine();
                            Console.WriteLine("Enter Date of Birth in MM/DD/YYYY format");
                            new1.DateOfBirth1 = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Gender M/F");
                            new1.Gender1 = Convert.ToChar(Console.ReadLine());
                            Console.WriteLine("Enter  City");
                            new1.City = Console.ReadLine();
                            Console.WriteLine("Enter UG Percentage");
                            new1.UGpercentage1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter job positon ASET ASE SE ITA");
                            new1.Job_position1 = Console.ReadLine();
                            s.Register(new1);
                            break;
                        case "2":


                            break;
                        case "3":
                            break;
                        case "4":
                            break;
                        case "5":
                            break;
                        default:
                            break;




                            foreach (ICandidate sob in lst)
                            {
                                Console.Write(sob.Id);
                                Console.Write("\t\t\t" + sob.Name);
                                Console.WriteLine("\t\t\t" + sob.City);


                            }
                            Console.WriteLine("Enter Id to remove");
                            // string newcity = Console.ReadLine();
                            int id = Convert.ToInt32(Console.ReadLine());
                            foreach (ICandidate sob in lst)
                            {
                                if (sob.Id == id)
                                {
                                    lst.Remove(sob);
                                    break;

                                }
                            }
                            Console.WriteLine("---------------------------------------------------------------------------------");
                            Console.WriteLine("Id\t\t\tName\t\t\tCity");
                            Console.WriteLine("---------------------------------------------------------------------------------");
                            foreach (ICandidate sob in lst)
                            {
                                Console.Write(sob.Id);
                                Console.Write("\t\t\t" + sob.Name);
                                Console.WriteLine("\t\t\t" + sob.City);


                            }
                            Console.WriteLine("Enter Id and city");
                            id = Convert.ToInt32(Console.ReadLine());
                            string newcity = Console.ReadLine();
                            foreach (ICandidate sob in lst)
                            {
                                if (sob.Id == id)
                                {
                                    sob.City = newcity;
                                    break;

                                }
                            }
                            Console.WriteLine("---------------------------------------------------------------------------------");
                            Console.WriteLine("Id\t\t\tName\t\t\tCity");
                            Console.WriteLine("---------------------------------------------------------------------------------");
                            foreach (ICandidate sob in lst)
