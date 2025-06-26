using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderRepository
    {
        public void InitializeDataset();
        public List<Order> GetOrder();
        public Order? GetById(int id);
        public List<Order> GetByCustomer(int customerId);
        public bool AddOrder(Order o);
        public bool Update(Order o);
        public bool Delete(int id);
        public List<Order> GetOrdersForCustomer(int customerId);
    }
}
