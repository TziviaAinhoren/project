using System;
using System.Collections.Generic;

namespace MyProject.Models
{
    public partial class EmployeesTbl
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public DateTime? StartDate { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
}
