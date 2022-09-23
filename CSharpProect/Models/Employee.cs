using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProect.Models
{
    class Employee
    {

        public static Employee[] AllEmployees;

        public int No { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public Department Department { get; set; }

    }
}
