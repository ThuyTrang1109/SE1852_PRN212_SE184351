using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using BusinessObjects;
using DataAccess;
using Presentation; // Thêm using cho ViewModels

namespace Presentation
{
    /// <summary>
    /// Interaction logic for ReportsWindow.xaml
    /// </summary>
    public partial class ReportsWindow : Window
    {
        private OrderDAO orderDAO;
        private CustomerDAO customerDAO;
        private EmployeeDAO employeeDAO;
        private List<Order> orders;
        private List<Customer> customers;
        private List<Employee> employees;

        public ReportsWindow()
        {
            InitializeComponent();
            orderDAO = new OrderDAO();
            customerDAO = new CustomerDAO();
            employeeDAO = new EmployeeDAO();
            orderDAO.InitializeDataset();
            customerDAO.InitializeDataset();
            employeeDAO.InitializeDataset();
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            DateTime? from = dpFrom.SelectedDate;
            DateTime? to = dpTo.SelectedDate;
            if (from == null || to == null)
            {
                MessageBox.Show("Vui lòng chọn đủ khoảng thời gian!");
                return;
            }
            orders = orderDAO.GetOrder()
                .Where(o => o.OrderDate >= from && o.OrderDate <= to)
                .OrderByDescending(o => o.OrderDate)
                .ToList();
            customers = customerDAO.GetCustomer();
            employees = employeeDAO.GetEmployees();
            var reportViews = orders.Select(o => new ReportOrderView
            {
                OrderId = o.OrderId,
                CustomerName = customers.FirstOrDefault(c => c.CustomerId == o.CustomerId)?.ContactName ?? "",
                EmployeeName = employees.FirstOrDefault(e => e.EmployeeId == o.EmployeeId)?.Name ?? "",
                OrderDate = o.OrderDate
            }).ToList();
            dgReport.ItemsSource = null;
            dgReport.ItemsSource = reportViews;
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
