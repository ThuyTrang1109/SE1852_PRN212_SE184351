using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICustomerRepository
    {
        public void InitializeDataset();
        public List<Customer> GetCustomer();
        public Customer checkLogin(string phone);
        public bool AddCustomer(Customer u);
        public bool UpdateCustomer(Customer u);
        public bool DeleteCustomer(int id);
    }
}
