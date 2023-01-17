using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RESTAPIDemo.ApiContext;
using RESTAPIDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPIDemo.Repositories
{
    public class EmployeeRepositoryDb : IEmployeeRepository
    {

        private readonly AppDbContext _appDbContext;

        private readonly ILogger<EmployeeRepositoryDb> _logger;

        public EmployeeRepositoryDb(AppDbContext apiDbContext,ILogger<EmployeeRepositoryDb>logger)
        {
            _appDbContext = apiDbContext;

            _logger = logger;
        }

        public Employee AddEmployee(Employee employee)
        {
            employee.Id = new Guid();

            _appDbContext.Add(employee);

            _appDbContext.SaveChanges();

            return employee;
          
        }

        public void DeleteEmployee(Employee employee)
        {
            _appDbContext.tblemployees.Remove(employee);

            _appDbContext.SaveChanges();
        }

        public Employee EditEmployee(Employee employee)
        {
            var existingemployee = _appDbContext.tblemployees.Find(employee.Id);

            if (existingemployee != null)
            {
                existingemployee.FullName = employee.FullName;
                existingemployee.Email = employee.Email;
                existingemployee.Phone = employee.Phone;
                existingemployee.Salary = employee.Salary;
                existingemployee.Department = employee.Department;
                existingemployee.DateofJoin = employee.DateofJoin;
                existingemployee.IsActive = employee.IsActive;

                _appDbContext.tblemployees.Update(employee);

                _appDbContext.SaveChanges();
            }

            return employee;
        }

        public Employee GetEmployeeById(Guid Id)
        {
          var employee = _appDbContext.tblemployees.Find(Id);

          return employee;

        }

        public List<Employee> GetEmployees()
        {
           
            

               return _appDbContext.tblemployees.ToList();
            

           

        }
    }
}
