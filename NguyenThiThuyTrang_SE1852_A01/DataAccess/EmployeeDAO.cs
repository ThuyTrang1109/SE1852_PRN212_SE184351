using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess
{
    public class EmployeeDAO
    {
        static List<Employee> employees = new List<Employee>();

        public void InitializeDataset()
        {
            employees.Add(new Employee { EmployeeId = 1,Name = "Administrator",UserName = "admin",Password = "admin",JobTitle = "Admin"});
            employees.Add(new Employee { EmployeeId = 2, Name = "Staff Jane", UserName = "jane", Password = "1234", JobTitle = "Sales" });
        }
        

        public Employee? Authenticate(string userName, string password) =>
            employees.FirstOrDefault(e => e.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase)
                                      && e.Password == password);

        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
