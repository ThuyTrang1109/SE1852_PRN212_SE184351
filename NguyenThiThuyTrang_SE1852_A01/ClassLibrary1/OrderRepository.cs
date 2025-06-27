using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        OrderDAO orderDAO = new OrderDAO();
        public bool AddOrder(Order o)
        {
            return orderDAO.AddOrder(o);
        }

        public bool Delete(int id)
        {
            return orderDAO.Delete(id);
        }

        public List<Order> GetOrdersForCustomer(int customerId)
        {
            return orderDAO.GetOrdersForCustomer(customerId);
        }

        public List<Order> GetByCustomer(int customerId)
        {
            return orderDAO.GetByCustomer(customerId);
        }

        public Order? GetById(int id)
        {
            return orderDAO.GetById(id);
        }

        public List<Order> GetOrder()
        {
            return orderDAO.GetOrder();
        }

        public void InitializeDataset()
        {
            orderDAO.InitializeDataset();
        }

        public bool Update(Order o)
        {
            return orderDAO.Update(o);
        }
    }
}
