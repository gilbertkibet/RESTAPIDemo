using RESTAPIDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPIDemo.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                Id=Guid.NewGuid(),
                FullName="Gilbert Kibet",
                Email="KibetGilly354@gmail.com",
                Phone=123456,
                Salary=23445,
                Department="Rand",
                DateofJoin=DateTime.Now,
                IsActive=true
            },

             new Employee()
            {
                Id=Guid.NewGuid(),
                FullName="Gilbert Kibet",
                Email="KibetGilly354@gmail.com",
                Phone=123456,
                Salary=23445,
                Department="Rand",
                DateofJoin=DateTime.Now,
                IsActive=true
            },
                 new Employee()
            {
                Id=Guid.NewGuid(),
                FullName="Gilbert Kibet",
                Email="KibetGilly354@gmail.com",
                Phone=123456,
                Salary=23445,
                Department="Rand",
                DateofJoin=DateTime.Now,
                IsActive=true
            }
        };

        public Employee AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();

            employees.Add(employee);

            return (employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public Employee EditEmployee(Employee employee)
        {
            var existingemployee = GetEmployeeById(employee.Id);

            existingemployee.FullName = employee.FullName;
            existingemployee.Email = employee.Email;
            existingemployee.Phone = employee.Phone;
            existingemployee.Salary = employee.Salary;
            existingemployee.Department = employee.Department;
            existingemployee.DateofJoin = employee.DateofJoin;
            existingemployee.IsActive = employee.IsActive;

            return (existingemployee);
        }

        public Employee GetEmployeeById(Guid Id)
        {
            return employees.SingleOrDefault(x => x.Id == Id);
        }

        public List<Employee> GetEmployees()
        {
        return employees;

        }
    }
}
