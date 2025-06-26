using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Repositories
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        EmployeeDAO employeeDao = new EmployeeDAO();
        public Employee? Authenticate(string userName, string password)
        {
            return employeeDao.Authenticate(userName, password);
        }

        public List<Employee> GetEmployees()
        {
            return employeeDao.GetEmployees();
        }

        public void InitializeDataset()
        {
            employeeDao.InitializeDataset();
        }
    }
}
