using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTAPIDemo.Entities;
using RESTAPIDemo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPIDemo.Controllers
{
    [Route("api/[controller]")]

    [ApiController]

    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        #region crud operations action methods
        [HttpGet]

        public async Task< IActionResult> GetEmployees()
        {
            return Ok( await _employeeRepository.GetEmployees());
            
        }

        [HttpGet("{id}")]

        public IActionResult GetEmployeeById(Guid id)
        {
            var employee = _employeeRepository.GetEmployeeById(id);

            if (employee != null)
            {
                return Ok(employee);
            }
            return StatusCode(404,$"Employee of id:{id} is not found");
        }

        [HttpPost]
        public IActionResult PostEmployee(Employee employee)
        {
            _employeeRepository.AddEmployee(employee);

            return StatusCode(200,employee);
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteEmployee(Guid id)
        {
            var employee = _employeeRepository.GetEmployeeById(id);

            if (employee != null)
            {
                _employeeRepository.DeleteEmployee(employee);

                return StatusCode(200);
            }
            return StatusCode(404);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(Guid id,Employee employee)
        {
            var _employee = _employeeRepository.GetEmployeeById(id);

            if (_employee != null)
            {
                employee.Id = _employee.Id;

                _employeeRepository.EditEmployee(employee);

                return StatusCode(200);
            }
            return Ok (employee);
        }
        #endregion
    }

}
