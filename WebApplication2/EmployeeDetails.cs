using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class EmployeeDetails
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country  { get; set; }
    }

    public class PersonDetails
    {
        public string PlaceOfBirth { get; set; }

        public DateTime DOB { get; set; }

        public string Nationality { get; set; }

        public string Phone { get; set; }

        public string Name { get; set; }
    }


}
