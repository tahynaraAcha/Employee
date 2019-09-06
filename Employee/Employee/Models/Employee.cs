using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Employee.Models
{


    public class Employee
    {
        [key]
        public int EmployeeID { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]

        public int Salary { get; set; }
        [Required]

        public string Birthday { get; set; }
        [Required]

        public string Recomendation { get; set; }

        public class Models
        {
            public class Employee
            {
            }
        }
    }
}