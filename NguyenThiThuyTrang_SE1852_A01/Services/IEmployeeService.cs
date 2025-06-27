using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IEmployeeService
    {
        public void InitializeDataset();
        public List<Employee> GetEmployees();
        public Employee? Authenticate(string userName, string password);
    }
}
