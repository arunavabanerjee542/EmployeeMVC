using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementMVC.Models
{
    public class Employee
    {

        public int  id { get; set; }
        public string name { get; set; }
        public Department Department { get; set; }
       // public string PhotoPath { get; set; }

    }
}
