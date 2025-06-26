using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccess
{
    public class CustomerDAO
    {
        static List<Customer> customer = new List<Customer>();

        public void InitializeDataset()
        {
            if (customer.Count == 0)
            {
                customer.Add(new Customer
                {
                    CustomerId = 1, CompanyName = "ACME Corp", ContactName = "Alice", ContactTitle = "Manager",
                    Address = "123 Main St", Phone = "123456789"
                });
                customer.Add(new Customer
                {
                    CustomerId = 2, CompanyName = "Globex Inc", ContactName = "Bob", ContactTitle = "Director",
                    Address = "456 Elm St", Phone = "987654321"
                });
            }
        }

        public List<Customer> GetCustomer()
        {
            return customer;
        }

        public Customer checkLogin(string phone)
        {
            return customer.FirstOrDefault(e => e.Phone == phone);
        }

        public bool AddCustomer(Customer u)
        {
            Customer cm = customer.FirstOrDefault(x => x.CustomerId == u.CustomerId);
            if (cm != null)
                return false;//thêm mới thất bại
            customer.Add(u);//thêm mới thành công
            return true;
        }

        public bool UpdateCustomer(Customer u)
        {
            Customer cm = customer.FirstOrDefault(x => x.CustomerId == u.CustomerId);
            if (cm == null)
                return false;//sửa thất bại (không tìm thấy)
            cm.CompanyName = u.CompanyName;
            cm.ContactName = u.ContactName;
            cm.ContactTitle = u.ContactTitle;
            cm.Address = u.Address;
            cm.Phone = u.Phone;
            return true;
        }

        public bool DeleteCustomer(int id)
        {
            Customer cm = customer.FirstOrDefault(x => x.CustomerId == id);
            if (cm == null)
                return false;//xóa thất bại (không tìm thấy)
            customer.Remove(cm);
            return true;
        }
    }
}
