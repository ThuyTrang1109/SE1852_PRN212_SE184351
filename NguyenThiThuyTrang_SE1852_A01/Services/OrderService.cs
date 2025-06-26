using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;

namespace Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository iOrderRepository;
        public bool AddOrder(Order o)
        {
            return iOrderRepository.AddOrder(o);
        }

        public bool Delete(int id)
        {
            return iOrderRepository.Delete(id);
        }

        public List<Order> GetByCustomer(int customerId)
        {
            return iOrderRepository.GetByCustomer(customerId);
        }

        public Order? GetById(int id)
        {
            return iOrderRepository.GetById(id);
        }

        public List<Order> GetOrder()
        {
            return iOrderRepository.GetOrder();
        }

        public List<Order> GetOrdersForCustomer(int customerId)
        {
            return iOrderRepository.GetOrdersForCustomer(customerId);
        }

        public void InitializeDataset()
        {
            iOrderRepository.InitializeDataset();
        }

        public bool Update(Order o)
        {
            return iOrderRepository.Update(o);
        }
    }
}
