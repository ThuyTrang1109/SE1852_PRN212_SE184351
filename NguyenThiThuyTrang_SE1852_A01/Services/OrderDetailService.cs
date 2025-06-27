using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;

namespace Services
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepository iOrderDetailRepository;
        public bool AddOrderDetail(OrderDetail d)
        {
            return iOrderDetailRepository.AddOrderDetail(d);
        }

        public void DeleteOrderDetail(int orderId, int productId)
        {
            iOrderDetailRepository.DeleteOrderDetail(orderId, productId);
        }

        public List<OrderDetail> GetByOrder(int orderId)
        {
            return iOrderDetailRepository.GetByOrder(orderId);
        }

        public List<OrderDetail> GetOrderDetail()
        {
            return iOrderDetailRepository.GetOrderDetail();
        }

        public void InitializeDataset()
        {
            iOrderDetailRepository.InitializeDataset();
        }

        public bool UpdateOrderDetail(OrderDetail d)
        {
            return iOrderDetailRepository.UpdateOrderDetail(d);
        }
    }
}
