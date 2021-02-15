using EmployeeManagementMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ShowDetails()
        {
            //IEnumerable<Employee> empList = EmployeeService.GetEmployeeList();

            IEnumerable<Employee> empList = _employeeRepository.GetAllEmployee();
            return View(empList);

        }

        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            //Console.WriteLine(employee.name + " "+employee.name +  " " +employee.Department);
            //  EmployeeService.Add(employee);
            var emp =  _employeeRepository.Add(employee);
            return RedirectToAction("ShowDetails");
           // return Content ( employee.id + " " + employee.name + " " + employee.Department);


        }

        [HttpGet]
        public IActionResult DeleteEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteEmployee(EmployeeId employeeId)
        {
           var emp = _employeeRepository.Delete(employeeId.id);

          if (emp != null)
                return RedirectToAction("ShowDetails");

           else
             return View();
                      
        }

    }
}
