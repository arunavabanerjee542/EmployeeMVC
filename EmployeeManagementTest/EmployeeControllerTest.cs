using EmployeeManagementMVC.Controllers;
using EmployeeManagementMVC.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace EmployeeManagementTest
{
    public class EmployeeControllerTest
    {
        [Fact]
        public void AddEmployee_WhenCalled_AddsEmployeeToDb()
        {
            //Arrange
            var repo = new Mock<IEmployeeRepository>();
            var controller = new EmployeeController(repo.Object);
            var emp = new Employee();

            //Act
            controller.AddEmployee(emp);

            //Assert
            repo.Verify(repo => repo.Add(emp));


        }

        [Fact]
        public void DeleteEmployee_WhenCalled_DeletesEmployeeFromDb()
        {
            //Arrange
            var repo = new Mock<IEmployeeRepository>();
            var controller = new EmployeeController(repo.Object);
            var empid = new EmployeeId();

            //Act
            controller.DeleteEmployee(empid);

            //Assert
            repo.Verify(repo => repo.Delete(empid.id));


        }

    }
}
