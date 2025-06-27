using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace Services
{
    public interface ICustomerService
    {
        public void InitializeDataset();
        public List<Customer> GetCustomer();
        public Customer checkLogin(string phone);
        public bool AddCustomer(Customer u);
        public bool UpdateCustomer(Customer u);
        public bool DeleteCustomer(int id);
    }
}
