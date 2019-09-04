using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee.Models
{
    enum typeEmployee
    {


    }


    public class Employee
    {
        public int EmployeeID { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }

        public string Birthday { get; set; }

        public string Recomendation { get; set; }

    }
}