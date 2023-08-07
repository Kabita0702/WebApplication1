using WebApplication1.Models;

namespace WebApplication1.EmployeeData
{
    public class EmployeeDetails
    {
        public static IList<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                Id = 1,EmpName="Kabita",EmpAddress="Jamshedpur",EmpDepartment="Automation"
            },
            new Employee()
            {
                 Id = 2,EmpName="Mansi",EmpAddress="Ranchi",EmpDepartment="Automation"
            },
        };
    }
}
