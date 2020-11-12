

using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MyProject.IServices;
using MyProject.Models;
using MyProject.Services;

namespace MyProject.Controllers
{

    [EnableCors("MyPolicy")]
    [ApiController]
    [Route("api/Employee")]


    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employee)
        {
            employeeService = employee;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee/GetEmployee")]
        public IEnumerable<EmployeesTbl> GetEmployee()
        {
            return employeeService.GetEmployee();
        }

        //[HttpPost]
        //[Route("[action]")]
        //[Route("api/Employee/AddEmployee")]
        //public EmployeesTbl AddEmployee(EmployeesTbl employee)
        //{
        //    return employeeService.AddEmployee(employee);
        //}
        //[HttpPut]
        //[Route("[action]")]
        //[Route("api/Employee/EditEmployee")]
        //public EmployeesTbl EditEmployee(EmployeesTbl employee)
        //{
        //    return employeeService.UpdateEmployee(employee);
        //}

        [HttpPost]
        [Route("[action]")]
        [Route("api/Employee/AddImage")]
        public HttpResponseMessage AddImage([FromBody] FileToUpload img)
        {
            HttpResponseMessage response;
            response = employeeService.AddImage(img);
            return response;
        }
        //[HttpDelete]
        //[Route("[action]")]
        //[Route("api/Employee/DeleteEmployee")]
        //public EmployeesTbl DeleteEmployee(int id)
        //{
        //    return employeeService.DeleteEmployee(id);
        //}
        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee/GetEmployeeId")]
        public EmployeesTbl GetEmployeeId(string id)
        {

            return employeeService.GetEmployeeById(id);

        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee/GetStreets")]
        public IEnumerable<StreetsTbl> GetStreets()
        {

            return employeeService.GetStreets();
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee/GetPartofEmployee")]
        public IEnumerable<EmployeesTbl> GetPartofEmployee(int currentCount, int PrevOrNext)
        {
            return employeeService.GetPartofEmployee(currentCount, PrevOrNext);
        }

    }
}
