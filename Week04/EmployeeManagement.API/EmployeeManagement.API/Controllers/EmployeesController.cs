using EmployeeManagement.API.Data;
using EmployeeManagement.API.Dtos;
using EmployeeManagement.API.DTOs;
using EmployeeManagement.API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly App_DbContext dbContext;

        public EmployeesController(App_DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // get with defined the column
        [HttpGet]
        public IActionResult GetAllEmployees() 
        {
            var AllEmployees = dbContext.employee_data.ToList();
            return Ok(AllEmployees);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetEmployeesById(int id)
        {
            var Employee = dbContext.employee_data.Find(id);
            if (Employee is null) 
            {
                return NotFound();
            }
            return Ok(Employee);
        }

        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDTO addEmployeeDTO) 
        {
            var employeeEntity = new Employee()
            {
                Name = addEmployeeDTO.Name,
                Email = addEmployeeDTO.Email,
                DepartmentId = addEmployeeDTO.DepartmentId,
                JobPositionID = addEmployeeDTO.JobPositionID
            };

            dbContext.employee_data.Add(employeeEntity);
            dbContext.SaveChanges();

            return Ok(employeeEntity);
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult UpdateData(int id,UpdateDataDTO updateDataDTO)
        {
            var employee = dbContext.employee_data.Find(id);
            if (employee is null)
            {
                return NotFound();
            }
            employee.Name = updateDataDTO.Name;
            employee.Email = updateDataDTO.Email;
            employee.DepartmentId = updateDataDTO.DepartmentId;
            employee.JobPositionID = updateDataDTO.JobPositionID;

            dbContext.SaveChanges();

            return Ok(employee);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeleteData(int id)
        {
            var employee = dbContext.employee_data.Find(id);
            if (employee is null)
            {
                return NotFound();
            }
            dbContext.employee_data.Remove(employee);

            dbContext.SaveChanges();

            return Ok(employee);
        }
    }
}
