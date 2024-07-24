using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    public class Employee
    {
        public int Code { get; set; }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public DateTime Birthday { get; set; }
        public int Age { get { return DateTime.Now.Year - Birthday.Year; } }
        public bool IsMale { get; set; }
        public string Status { get; set; }
        public string PhoneNumber { get; set; }
        public string CallNumber { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string HomeAddress { get { return City + ", " + Street + " " + HouseNumber; } }

        public Employee(int code, string id, string firstName, string lastName, DateTime birthDay, string phoneNumber, string callNumber, string street, string houseNumber, string city, bool isMale, string status)
        {
            Code = code;
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthDay;
            CallNumber = callNumber;
            PhoneNumber = phoneNumber;
            Street = street;
            City = city;
            HouseNumber = houseNumber;
            IsMale = isMale;
            Status = status;
        }


    }
}
