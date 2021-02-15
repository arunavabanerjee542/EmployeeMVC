﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementMVC.Models
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {
        private AppDbContext _context;

        public SqlEmployeeRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public Employee Add(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee Delete(int? id)
        {
            Employee employee =_context.Employees.Find(id);
            if (employee != null)
            {
                _context.Remove(employee);
                _context.SaveChanges();
                return employee;
            }
            return null;

        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _context.Employees;
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employees.Find(id);
        }

        public Employee Update(Employee employeeChanges)
        {
            var employee =_context.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return employeeChanges;

        }
    }
}
