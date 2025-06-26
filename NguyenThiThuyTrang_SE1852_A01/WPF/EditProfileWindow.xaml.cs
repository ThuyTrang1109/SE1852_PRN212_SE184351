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
    /// Interaction logic for EditProfileWindow.xaml
    /// </summary>
    public partial class EditProfileWindow : Window
    {
        private int customerId;
        private DataAccess.CustomerDAO customerDAO;
        private BusinessObjects.Customer currentCustomer;

        public EditProfileWindow(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
            customerDAO = new DataAccess.CustomerDAO();
            customerDAO.InitializeDataset();
            LoadCustomerInfo();
        }

        private void LoadCustomerInfo()
        {
            currentCustomer = customerDAO.GetCustomer().FirstOrDefault(c => c.CustomerId == customerId);
            if (currentCustomer != null)
            {
                txtContactName.Text = currentCustomer.ContactName;
                txtCompanyName.Text = currentCustomer.CompanyName;
                txtAddress.Text = currentCustomer.Address;
                txtPhone.Text = currentCustomer.Phone;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (currentCustomer != null)
            {
                currentCustomer.ContactName = txtContactName.Text;
                currentCustomer.CompanyName = txtCompanyName.Text;
                currentCustomer.Address = txtAddress.Text;
                currentCustomer.Phone = txtPhone.Text;
                if (customerDAO.UpdateCustomer(currentCustomer))
                {
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
