
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DataAccess;
using BusinessObjects;

namespace Presentation
{
    /// <summary>
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        private DataAccess.OrderDAO orderDAO;
        private DataAccess.OrderDetailDAO orderDetailDAO;
        private int currentCustomerId;

        public CustomerWindow(int customerId)
        {
            InitializeComponent();
            orderDAO = new DataAccess.OrderDAO();
            orderDetailDAO = new DataAccess.OrderDetailDAO();
            orderDAO.InitializeDataset();
            orderDetailDAO.InitializeDataset();
            currentCustomerId = customerId;
            LoadOrderHistory();
        }

        private void LoadOrderHistory()
        {
            var orders = orderDAO.GetOrder().Where(o => o.CustomerId == currentCustomerId).ToList();
            // Lấy toàn bộ chi tiết đơn hàng bằng cách duyệt từng đơn
            var allDetails = new List<BusinessObjects.OrderDetail>();
            foreach (var o in orders)
            {
                var details = orderDetailDAO.GetByOrder(o.OrderId);
                if (details != null)
                    allDetails.AddRange(details);
            }
            var orderViews = orders.Select(o => new
            {
                OrderId = o.OrderId,
                OrderDate = o.OrderDate,
                TotalAmount = allDetails.Where(d => d.OrderId == o.OrderId).Sum(d => d.UnitPrice * d.Quantity * (1 - (decimal)d.Discount)),
                Status = "Hoàn tất" // Có thể thay đổi nếu có trạng thái thực tế
            }).ToList();
            dgOrderHistory.ItemsSource = orderViews;
        }

        private void btnEditProfile_Click(object sender, RoutedEventArgs e)
        {
            var editProfileWindow = new EditProfileWindow(currentCustomerId);
            editProfileWindow.ShowDialog();
        }
    }
}
