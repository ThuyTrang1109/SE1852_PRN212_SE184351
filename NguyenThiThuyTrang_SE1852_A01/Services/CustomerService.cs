using BusinessObjects;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository iCustomerRepository;
        public Customer checkLogin(string phone)
        {
            return iCustomerRepository.checkLogin(phone);
        }

        public bool AddCustomer(Customer u)
        {
            return iCustomerRepository.AddCustomer(u);
        }

        public bool UpdateCustomer(Customer u)
        {
            return iCustomerRepository.UpdateCustomer(u);
        }

        public bool DeleteCustomer(int id)
        {
            return iCustomerRepository.DeleteCustomer(id);
        }

        public List<Customer> GetCustomer()
        {
            return iCustomerRepository.GetCustomer();
        }

        public void InitializeDataset()
        {
            iCustomerRepository.InitializeDataset();
        }
    }
}
