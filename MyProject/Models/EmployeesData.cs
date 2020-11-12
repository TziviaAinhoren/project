using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class EmployeesData
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public DateTime StartDate { get; set; }

        public byte [] Image { get; set; }

        public string City { get; set; }

        public string CityCode { get; set; }

        public string Street { get; set; }

       }
} 
