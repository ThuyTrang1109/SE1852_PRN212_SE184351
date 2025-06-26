using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        OrderDetailDAO orderDetailDAO = new OrderDetailDAO();
        public bool AddOrderDetail(OrderDetail d)
        {
            return orderDetailDAO.AddOrderDetail(d);
        }

        public void DeleteOrderDetail(int orderId, int productId)
        {
            orderDetailDAO.DeleteOrderDetail(orderId, productId);
        }

        public List<OrderDetail> GetByOrder(int orderId)
        {
            return orderDetailDAO.GetByOrder(orderId);
        }

        public List<OrderDetail> GetOrderDetail()
        {
            return orderDetailDAO.GetOrderDetail();
        }

        public void InitializeDataset()
        {
            orderDetailDAO.InitializeDataset();
        }

        public bool UpdateOrderDetail(OrderDetail d)
        {
            return orderDetailDAO.UpdateOrderDetail(d);
        }
    }
}
