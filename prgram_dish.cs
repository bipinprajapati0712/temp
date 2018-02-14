using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag;
            int candidateId;
            string name;
            DateTime Dob;
            string gender;
            string city;
            double Ugpercentage;
            string position;
            int choice;

            try
            {
                do
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1.Register");
                    Console.WriteLine("2.View");
                    Console.WriteLine("3.Count");
                    Console.WriteLine("4.Delete");
                    Console.WriteLine("0.Exit");
                    Console.WriteLine("Enter your choice");
                    choice = Convert.ToInt32(Console.ReadLine());
                    ICandidateOperation Icanobj = new CandidateOperation();
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter name");
                            name = Console.ReadLine();
                            Console.WriteLine("Enter your Dob");
                            Dob = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Enter city");
                            city = Console.ReadLine();
                            Console.WriteLine("Enter Gender");
                            gender = Console.ReadLine();
                            Console.WriteLine("Enter UG Percentage");
                            Ugpercentage = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter job position");
                            position = Console.ReadLine().ToUpper();
                            ICandidate candidateobj = new Candidate(name, Dob, city, gender, Ugpercentage, position);
                            candidateId = Icanobj.RegisterJob(candidateobj);

                            break;

                        case 2:

                            Console.WriteLine("Enter job position ASET,ASE,SE,ITA=");
                            //flag=0;
                            position = Console.ReadLine().ToUpper();
                            if (position == "ASET" || position == "ASE" || position == "SE" || position == "ITA")
                            {
                                List<ICandidate> detailList = Icanobj.View(position);
                                Console.WriteLine("............................................................................................");
                                foreach (ICandidate bObj in detailList)
                                {
                                    Console.WriteLine("candidate ID:" + bObj.CandidateId);
                                    Console.WriteLine("name:" + bObj.Name);
                                    Console.WriteLine("DOB:" + bObj.Dob);
                                    Console.WriteLine("Gender:" + bObj.Gender);
                                    Console.WriteLine("City:" + bObj.City);
                                    Console.WriteLine("Ugpercentage:" + bObj.Ugpercentage);
                                    Console.WriteLine("................................................................");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Job osition not found");
                            }
                            break;



                        case 3:
                            Console.WriteLine("Enter job position=");
                            flag = 0;
                            position = Console.ReadLine().ToUpper();
                            if (position == "ASET" || position == "ASE" || position == "SE" || position == "ITA")
                            {
                                flag = 1;
                                int t = 0;
                                Console.WriteLine("..................................................");
                                t = Icanobj.CountList(position);
                                if (t == 0)
                                {
                                    Console.WriteLine("sorry no record found");
                                }

                                else
                                {
                                    Console.WriteLine("No. of candidate in" + position + "is:" + t);

                                }
                                Console.WriteLine("......................................................");
                            }
                            else
                            {
                                Console.WriteLine("job position not nin the list");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Enter candidate ID:");
                            candidateId = Convert.ToInt32(Console.ReadLine());
                            flag = Icanobj.delete(candidateId);
                            if (flag == 1)
                            {
                                Console.WriteLine("candidate details with candidate ID:" + candidateId + "succefully deleted");
                            }
                            else
                            {
                                Console.WriteLine("Candidate Id not in the list");
                            }
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                    }
                        



                }
                while (choice <5 && choice>0);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }
            Console.ReadKey();
          
}
    }
}
