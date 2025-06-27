using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO
    {
        static List<Order> orders = new List<Order>();

        public void InitializeDataset()
        {
            if (orders.Count == 0)
            {
                orders.Add(new Order
                {
                    OrderId = 1,
                    CustomerId = 1,
                    EmployeeId = 1,
                    OrderDate = DateTime.Now.AddDays(-5)
                });
                orders.Add(new Order
                {
                    OrderId = 2,
                    CustomerId = 2,
                    EmployeeId = 2,
                    OrderDate = DateTime.Now.AddDays(-2)
                });
            }
        }

        public List<Order> GetOrder()
        {
            return orders;
        }

        public Order? GetById(int id) =>
            orders.FirstOrDefault(o => o.OrderId == id);

        public List<Order> GetByCustomer(int customerId) =>
            orders.Where(o => o.CustomerId == customerId).ToList();

        public bool AddOrder(Order o)
        {
            Order od = orders.FirstOrDefault(x => x.OrderId == o.OrderId);
            if (od != null)
                return false;//thêm mới thất bại
            orders.Add(o);//thêm mới thành công
            return true;
        }

        public bool Update(Order o)
        {
            Order od = orders.FirstOrDefault(x => x.OrderId == o.OrderId);
            if (od == null)
                return false; // Không tìm thấy thì thất bại
            od.CustomerId = o.CustomerId;
            od.EmployeeId = o.EmployeeId;
            od.OrderDate = o.OrderDate;
            return true;
        }

        public bool Delete(int id)
        {
            Order od = orders.FirstOrDefault(x => x.OrderId == id);
            if (od == null)
                return false; // Không tìm thấy thì thất bại
            orders.Remove(od);
            return true;
        }
        public List<Order> GetOrdersForCustomer(int customerId)
        {
            return orders.Where(o => o.CustomerId == customerId).ToList();
        }
    }
}
