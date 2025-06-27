using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        CustomerDAO customerDAO = new CustomerDAO();
        public Customer checkLogin(string phone)
        {
            return customerDAO.checkLogin(phone);
        }

        public bool AddCustomer(Customer u)
        {
            return customerDAO.AddCustomer(u);
        }

        public bool UpdateCustomer(Customer u)
        {
            return customerDAO.UpdateCustomer(u);
        }

        public bool DeleteCustomer(int id)
        {
            return customerDAO.DeleteCustomer(id);
        }

        public List<Customer> GetCustomer()
        {
            return customerDAO.GetCustomer();
        }

        public void InitializeDataset()
        {
            customerDAO.InitializeDataset();
        }
    }
}
