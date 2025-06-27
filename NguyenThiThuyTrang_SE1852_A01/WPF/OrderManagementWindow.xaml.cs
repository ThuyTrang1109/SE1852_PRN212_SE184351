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
using BusinessObjects;
using DataAccess;
using Presentation; // Thêm using cho ViewModels

namespace Presentation
{
    /// <summary>
    /// Interaction logic for OrderManagementWindow.xaml
    /// </summary>
    public partial class OrderManagementWindow : Window
    {
        private OrderDAO orderDAO;
        private OrderDetailDAO orderDetailDAO;
        private CustomerDAO customerDAO;
        private EmployeeDAO employeeDAO;
        private ProductDAO productDAO;
        private List<Order> orders;
        private List<OrderDetail> orderDetails;
        private List<Customer> customers;
        private List<Employee> employees;
        private List<Product> products;

        public OrderManagementWindow()
        {
            InitializeComponent();
            orderDAO = new OrderDAO();
            orderDetailDAO = new OrderDetailDAO();
            customerDAO = new CustomerDAO();
            employeeDAO = new EmployeeDAO();
            productDAO = new ProductDAO();
            orderDAO.InitializeDataset();
            orderDetailDAO.InitializeDataset();
            customerDAO.InitializeDataset();
            employeeDAO.InitializeDataset();
            productDAO.InitializeDataset();
            LoadOrders();
            // Nạp dữ liệu cho ComboBox khách hàng, nhân viên, sản phẩm (không lặp)
            cbCustomer.ItemsSource = customerDAO.GetCustomer().DistinctBy(c => c.CustomerId).ToList();
            cbEmployee.ItemsSource = employeeDAO.GetEmployees().DistinctBy(e => e.EmployeeId).ToList();
            cbProduct.ItemsSource = productDAO.GetProducts().DistinctBy(p => p.ProductId).ToList();
            cbCustomer.SelectedIndex = 0;
            cbEmployee.SelectedIndex = 0;
            cbProduct.SelectedIndex = 0;
        }

        private void LoadOrders()
        {
            orders = orderDAO.GetOrder();
            customers = customerDAO.GetCustomer();
            employees = employeeDAO.GetEmployees();
            var orderViews = orders.Select(o => new OrderView
            {
                OrderId = o.OrderId,
                CustomerName = customers.FirstOrDefault(c => c.CustomerId == o.CustomerId)?.ContactName ?? "",
                EmployeeName = employees.FirstOrDefault(e => e.EmployeeId == o.EmployeeId)?.Name ?? "",
                OrderDate = o.OrderDate // giữ nguyên kiểu DateTime
            }).ToList();
            dgOrders.ItemsSource = null;
            dgOrders.ItemsSource = orderViews;
            dgOrderDetails.ItemsSource = null;
        }

        private void dgOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgOrders.SelectedItem is OrderView orderView)
            {
                var order = orders.FirstOrDefault(o => o.OrderId == orderView.OrderId);
                if (order != null)
                {
                    products = productDAO.GetProducts();
                    orderDetails = orderDetailDAO.GetByOrder(order.OrderId);
                    var detailViews = orderDetails.Select(d => new OrderDetailView
                    {
                        ProductName = products.FirstOrDefault(p => p.ProductId == d.ProductId)?.ProductName ?? "",
                        UnitPrice = d.UnitPrice,
                        Quantity = d.Quantity,
                        Discount = d.Discount
                    }).ToList();
                    dgOrderDetails.ItemsSource = null;
                    dgOrderDetails.ItemsSource = detailViews;
                }
            }
        }

        private void btnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Tạo Order mới
                int newOrderId = orders.Count > 0 ? orders.Max(o => o.OrderId) + 1 : 1;
                int customerId = cbCustomer.SelectedValue != null ? (int)cbCustomer.SelectedValue : 0;
                int employeeId = cbEmployee.SelectedValue != null ? (int)cbEmployee.SelectedValue : 0;
                DateTime orderDate = dpOrderDate.SelectedDate ?? DateTime.Now;
                var order = new Order
                {
                    OrderId = newOrderId,
                    CustomerId = customerId,
                    EmployeeId = employeeId,
                    OrderDate = orderDate
                };
                if (!orderDAO.AddOrder(order))
                {
                    MessageBox.Show("Thêm đơn hàng thất bại (ID đã tồn tại)");
                    return;
                }
                // Thêm OrderDetail
                int productId = cbProduct.SelectedValue != null ? (int)cbProduct.SelectedValue : 0;
                short quantity = short.TryParse(txtQuantity.Text, out var qty) ? qty : (short)0;
                decimal unitPrice = decimal.TryParse(txtUnitPrice.Text, out var price) ? price : 0;
                float discount = float.TryParse(txtDiscount.Text, out var disc) ? disc : 0f;
                var detail = new OrderDetail
                {
                    OrderId = newOrderId,
                    ProductId = productId,
                    Quantity = quantity, // sửa về kiểu short
                    UnitPrice = unitPrice,
                    Discount = discount
                };
                if (!orderDetailDAO.AddOrderDetail(detail))
                {
                    MessageBox.Show("Thêm chi tiết đơn hàng thất bại (trùng sản phẩm)");
                    return;
                }
                MessageBox.Show("Tạo đơn hàng thành công!");
                LoadOrders();
                // Làm mới các trường nhập liệu
                cbCustomer.SelectedIndex = 0;
                cbEmployee.SelectedIndex = 0;
                cbProduct.SelectedIndex = 0;
                dpOrderDate.SelectedDate = null;
                txtQuantity.Text = "";
                txtUnitPrice.Text = "";
                txtDiscount.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tạo đơn hàng: {ex.Message}");
            }
        }

        private void MenuOrder_Click(object sender, RoutedEventArgs e)
        {
            var win = new OrderManagementWindow();
            win.Show();
            this.Close();
        }
        private void MenuReport_Click(object sender, RoutedEventArgs e)
        {
            var win = new ReportsWindow();
            win.Show();
            this.Close();
        }
        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
