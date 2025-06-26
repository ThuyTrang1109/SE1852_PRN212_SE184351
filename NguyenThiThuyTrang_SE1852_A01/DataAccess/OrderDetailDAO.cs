using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        static List<OrderDetail> details = new List<OrderDetail>();

        public void InitializeDataset()
        {
            details.Add(new OrderDetail
            {
                OrderId = 1,
                ProductId = 1,
                UnitPrice = 200,
                Quantity = 2,
                Discount = 0.1f
            });
            details.Add(new OrderDetail
            {
                OrderId = 1,
                ProductId = 2,
                UnitPrice = 240,
                Quantity = 3,
                Discount = 0f
            });
            details.Add(new OrderDetail
            {
                OrderId = 2,
                ProductId = 3,
                UnitPrice = 100,
                Quantity = 1,
                Discount = 0.05f
            });

        }
        

        public List<OrderDetail> GetOrderDetail()
        {
            return details;
        }

        public List<OrderDetail> GetByOrder(int orderId) =>
            details.Where(d => d.OrderId == orderId).ToList();
        
        public bool AddOrderDetail(OrderDetail d)
        {
            OrderDetail ol = details.FirstOrDefault(x => x.OrderId == d.OrderId && x.ProductId == d.ProductId);
            if (ol != null)
                return false;
            details.Add(d);
            return true;
        }
        
        public bool UpdateOrderDetail(OrderDetail d)
        {
            OrderDetail ol = details.FirstOrDefault(x => x.OrderId == d.OrderId && x.ProductId == d.ProductId);
            if (ol != null)
                return false;
            ol.UnitPrice = d.UnitPrice;
            ol.Quantity = d.Quantity;
            ol.Discount = d.Discount;
            return true;
        }

        public void DeleteOrderDetail(int orderId, int productId)
        {
            var existing = details.FirstOrDefault(x =>
                x.OrderId == orderId &&
                x.ProductId == productId);
            if (existing != null)
                details.Remove(existing);
        }
    }
}
