using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;

namespace Services
{
    internal class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository iEmployeeRepository;
        public Employee? Authenticate(string userName, string password)
        {
            return iEmployeeRepository.Authenticate(userName, password);
        }

        public List<Employee> GetEmployees()
        {
            return iEmployeeRepository.GetEmployees();
        }

        public void InitializeDataset()
        {
            iEmployeeRepository.InitializeDataset();
        }
    }
}
