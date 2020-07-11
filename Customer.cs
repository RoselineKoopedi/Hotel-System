using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming281_Project
{
    class Customer
    {
        private string id;
        private string firstName;
        private string lastName;
        private string gender;
        private DateTime dob;
        private string nationality;
        private string phoneNumber;
        private string creditRating;

        public string Id
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

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
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

        public DateTime Dob
        {
            get
            {
                return dob;
            }

            set
            {
                dob = value;
            }
        }

        public string Nationality
        {
            get
            {
                return nationality;
            }

            set
            {
                nationality = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public string CreditRating
        {
            get
            {
                return creditRating;
            }

            set
            {
                creditRating = value;
            }
        }
        public Customer()
        {

        }
        public Customer(string idNumber,string fname,string lname,string gen,DateTime dobirth,string nat,string number,string rate)
        {
            id = idNumber;
            firstName = fname;
            lastName = lname;
            gender = gen;
            dob = dobirth;
            nationality = nat;
            phoneNumber = number;
            creditRating = rate;
        }
        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", id, firstName, lastName, gender, dob, nationality, phoneNumber, creditRating); 
        }
    }
}
