using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementMVC.Models
{
    public static class EmployeeService
    {
        private static List<Employee> _employeeList = new List<Employee>();

        /*
        public EmployeeService()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){id = 1,name="Ram",Department=Department.SoftwareDevelopement},
                  new Employee(){id = 2,name="Rama",Department=Department.Sales}

            };
        }
        */

        public static void Add(Employee employee)
        {
            _employeeList.Add(employee);
        }

        public static List<Employee> GetEmployeeList()
        {
            return _employeeList;
        }



    }
}
