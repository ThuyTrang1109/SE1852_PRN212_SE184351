using DataAccess;
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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private CustomerDAO customerDAO;
        private EmployeeDAO employeeDAO;

        public LoginWindow()
        {
            InitializeComponent();
            customerDAO = new CustomerDAO();
            employeeDAO = new EmployeeDAO();
            customerDAO.InitializeDataset();
            employeeDAO.InitializeDataset();
        }

        // Khi chọn Employee, hiển thị trường username và password
        private void rbEmployee_Checked(object sender, RoutedEventArgs e)
        {
            txtUsername.Visibility = Visibility.Visible; // Hiển thị trường Username
            txtPhone.Visibility = Visibility.Collapsed; // Ẩn Phone
            txtPassword.Visibility = Visibility.Visible; // Hiển thị trường Password
        }

        // Khi chọn Customer, hiển thị trường phone
        private void rbCustomer_Checked(object sender, RoutedEventArgs e)
        {
            txtPhone.Visibility = Visibility.Visible; // Hiển thị trường Phone
            txtUsername.Visibility = Visibility.Collapsed; // Ẩn Username
            txtPassword.Visibility = Visibility.Collapsed; // Ẩn Password
        }

        // Xử lý sự kiện đăng nhập
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;
            string phone = txtPhone.Text;

            // Nếu chọn Employee
            if (rbEmployee.IsChecked == true)
            {
                var employee = employeeDAO.Authenticate(username, password);
                if (employee != null)
                {
                    MessageBox.Show($"Welcome {employee.Name} ({employee.JobTitle})", "Login Successful", MessageBoxButton.OK, MessageBoxImage.Information);
                    // Điều hướng đến cửa sổ Employee
                    EmployeeWindow employeeWindow = new EmployeeWindow();
                    employeeWindow.Show();
                    this.Close();  // Đóng cửa sổ login
                    return;
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            // Nếu chọn Customer
            if (rbCustomer.IsChecked == true)
            {
                var customer = customerDAO.checkLogin(phone);
                if (customer != null)
                {
                    MessageBox.Show($"Welcome {customer.ContactName} from {customer.CompanyName}", "Login Successful", MessageBoxButton.OK, MessageBoxImage.Information);
                    // Điều hướng đến cửa sổ Customer
                    CustomerWindow customerWindow = new CustomerWindow(customer.CustomerId);
                    customerWindow.Show();
                    this.Close();  // Đóng cửa sổ login
                    return;
                }
                else
                {
                    MessageBox.Show("Invalid phone number", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        // Hủy bỏ và thoát
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
