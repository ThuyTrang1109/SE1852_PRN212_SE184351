using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IOrderDetailService
    {
        public void InitializeDataset();
        public List<OrderDetail> GetOrderDetail();
        public List<OrderDetail> GetByOrder(int orderId);
        public bool AddOrderDetail(OrderDetail d);
        public bool UpdateOrderDetail(OrderDetail d);
        public void DeleteOrderDetail(int orderId, int productId);
    }
}
