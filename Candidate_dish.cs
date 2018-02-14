using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Candidate : ICandidate
    {
        private int _candidateId;
        private string _name;
        private DateTime _Dob;
        private string _gender;
        private string _city;
        private double _Ugpercentage;
        private string _position;
        private static int autoid = 5000;

        public int CandidateId
        {
            get
            {
                return _candidateId;
            }

            set
            {
                _candidateId = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public DateTime Dob
        {
            get
            {
                return _Dob;
            }

            set
            {
                _Dob = value;
            }
        }

        public string Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }

        public string City
        {
            get
            {
                return _city;
            }

            set
            {
                _city = value;
            }
        }

        public double Ugpercentage
        {
            get
            {
                return _Ugpercentage;
            }

            set
            {
                _Ugpercentage = value;
            }
        }

        public string Position
        {
            get
            {
                return _position;
            }

            set
            {
                _position = value;
            }
        }

        public Candidate(string _name, DateTime _Dob, string _gender, string _city, double _Ugercentage, string _position)
        {
            this.CandidateId = autoid++;
            this.Name = _name;
            this.Dob = _Dob;
            this.Gender = _gender;
            this.City = _city;
            this.Ugpercentage = _Ugercentage;
            this.Position = _position;
        }
    }
}

    
