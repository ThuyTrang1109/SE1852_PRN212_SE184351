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

namespace Presentation
{
    /// <summary>
    /// Interaction logic for EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        public EmployeeWindow()
        {
            InitializeComponent();
        }
        private void ManageCustomers_Click(object sender, RoutedEventArgs e)
        {
            var customerWindow = new CustomerManagementWindow();
            customerWindow.Show();
        }

        private void ManageProducts_Click(object sender, RoutedEventArgs e)
        {
            var productWindow = new ProductManagementWindow();
            productWindow.Show();
        }

        private void CreateOrders_Click(object sender, RoutedEventArgs e)
        {
            var orderWindow = new OrderManagementWindow();
            orderWindow.Show();
        }

        private void GenerateReports_Click(object sender, RoutedEventArgs e)
        {
            var reportWindow = new ReportsWindow();
            reportWindow.Show();
        }

    }
}
