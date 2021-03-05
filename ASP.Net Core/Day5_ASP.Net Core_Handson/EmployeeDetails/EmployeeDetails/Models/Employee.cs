using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal salary { get; set; }
        public bool permanent { get; set; }

        public Employee(int id, string name, decimal salary, bool permanent)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.permanent = permanent;

        }
    }
}
