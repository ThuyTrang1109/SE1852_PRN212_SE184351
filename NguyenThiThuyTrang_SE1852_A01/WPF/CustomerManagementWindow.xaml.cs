using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using BusinessObjects;
using DataAccess;

namespace Presentation
{
    public partial class CustomerManagementWindow : Window
    {
        private CustomerDAO customerDAO;
        private List<Customer> customers;

        public CustomerManagementWindow()
        {
            InitializeComponent();
            customerDAO = new CustomerDAO();
            if (customerDAO.GetCustomer().Count == 0) // Chỉ khởi tạo dữ liệu mẫu nếu chưa có dữ liệu
            {
                customerDAO.InitializeDataset();
            }
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            customers = customerDAO.GetCustomer();
            dgCustomers.ItemsSource = null;
            dgCustomers.ItemsSource = customers;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = int.TryParse(txtCustomerId.Text, out var cid) ? cid : 0;
                var customer = new Customer
                {
                    CustomerId = id,
                    CompanyName = txtCompanyName.Text,
                    ContactName = txtContactName.Text,
                    ContactTitle = txtContactTitle.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text
                };
                if (customerDAO.AddCustomer(customer))
                {
                    LoadCustomers();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("ID đã tồn tại hoặc thêm thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm khách hàng: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = int.TryParse(txtCustomerId.Text, out var cid) ? cid : 0;
                var customer = new Customer
                {
                    CustomerId = id,
                    CompanyName = txtCompanyName.Text,
                    ContactName = txtContactName.Text,
                    ContactTitle = txtContactTitle.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text
                };
                if (!customerDAO.UpdateCustomer(customer))
                {
                    MessageBox.Show("Không tìm thấy khách hàng để cập nhật.");
                }
                LoadCustomers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật khách hàng: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                return;
            try
            {
                int id = int.TryParse(txtCustomerId.Text, out var cid) ? cid : 0;
                if (!customerDAO.DeleteCustomer(id))
                {
                    MessageBox.Show("Không tìm thấy khách hàng để xóa.");
                }
                LoadCustomers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa khách hàng: {ex.Message}");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtCustomerId.Text = "";
            txtCompanyName.Text = "";
            txtContactName.Text = "";
            txtContactTitle.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            dgCustomers.SelectedIndex = -1;
        }

        private void dgCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgCustomers.SelectedItem is Customer customer)
            {
                txtCustomerId.Text = customer.CustomerId.ToString();
                txtCompanyName.Text = customer.CompanyName;
                txtContactName.Text = customer.ContactName;
                txtContactTitle.Text = customer.ContactTitle;
                txtAddress.Text = customer.Address;
                txtPhone.Text = customer.Phone;
            }
        }

        // Thêm chức năng tìm kiếm và quay về menu cho CustomerManagementWindow
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadCustomers();
            }
            else
            {
                var result = customerDAO.GetCustomer().Where(c => c.CompanyName.Contains(keyword, StringComparison.OrdinalIgnoreCase) || c.ContactName.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
                dgCustomers.ItemsSource = null;
                dgCustomers.ItemsSource = result;
            }
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // hoặc mở MainWindow nếu có
        }
    }
}
