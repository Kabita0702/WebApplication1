using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.EmployeeData;
using WebApplication1.Models;
using WebApplication1.StudentData;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IList<Employee> GetEmployeesDetails()
        {
            return EmployeeDetails.employees;
        }
        [HttpGet("{id}")]
        public Employee GetEmployee(int id)
        {
            var employee = EmployeeDetails.employees.FirstOrDefault(x => x.Id == id);
            if (employee == null)
            {
                throw new Exception();
            }
            return employee;
        }
        [HttpGet("Student")]
        public IList<Student> GetStudentDetails()
        {
            return StudentData.StudentDetails.studentdata;
        }
        [HttpGet("Student/{id}")]
        public Student GetStudent(int id)
        {
            var student = StudentDetails.studentdata.FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                throw new Exception();
            }
            return student;
        }
    }
}


