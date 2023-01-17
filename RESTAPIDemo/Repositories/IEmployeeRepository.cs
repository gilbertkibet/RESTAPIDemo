using RESTAPIDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPIDemo.Repositories
{
     public interface IEmployeeRepository
    {

         List<Employee> GetEmployees();

        Employee GetEmployeeById(Guid Id);

        Employee AddEmployee(Employee employee);

        void DeleteEmployee(Employee employee);

        Employee EditEmployee(Employee employee);

    }
}
