using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string? EmployeeFirstName { get; set; }
        public string? EmployeeLastName { get; set; }
        public double? EmployeeSalary { get; set; }
        public DateTime? EmployeeDate { get; set; } = DateTime.Now;

    }
}
