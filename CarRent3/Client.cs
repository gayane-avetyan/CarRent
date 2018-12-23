using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent3
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PassportNumber { get; set; }
        public string LicenceNumber { get; set; }
        public DateTime LicenceYear { get; set; }

        public Client(int id, string firstName, string lastName, int age, string address, string passportNumber, string licenceNumber, DateTime licenceYear)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Address = address;
            PassportNumber = passportNumber;
            LicenceNumber = licenceNumber;
            LicenceYear = licenceYear;
        }
    }
}
