using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace MyProject.IServices
{
   public interface IEmployeeService
    {
        IEnumerable<EmployeesTbl> GetEmployee();

        IEnumerable<StreetsTbl> GetStreets();
       
        EmployeesTbl GetEmployeeById(string id);
       // EmployeesTbl AddEmployee(EmployeesTbl employee);
      //  EmployeesTbl UpdateEmployee(EmployeesTbl employee);
        //EmployeesTbl DeleteEmployee(int id);
        HttpResponseMessage AddImage(FileToUpload img);
        IEnumerable<EmployeesTbl> GetPartofEmployee(int currentCount, int PrevOrNext);
    }
}
