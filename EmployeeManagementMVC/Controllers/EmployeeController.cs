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
       // private EmployeeService employeeService;

        
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ShowDetails()
        {
             IEnumerable<Employee> empList = EmployeeService.GetEmployeeList();

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
            Console.WriteLine(employee.name + " "+employee.name +  " " +employee.Department);
            EmployeeService.Add(employee);
            return RedirectToAction("ShowDetails");
           // return Content ( employee.id + " " + employee.name + " " + employee.Department);


        }










    }
}
