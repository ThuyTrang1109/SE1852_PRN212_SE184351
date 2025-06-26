using System.Windows;
using BusinessObjects;
using Microsoft.Extensions.DependencyInjection;
using Services;

namespace ProductManagement;

public partial class LoginWindow : Window
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IAccountService _accountService;
    public LoginWindow(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        _accountService = _serviceProvider.GetRequiredService<IAccountService>();
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, RoutedEventArgs e)
    {
        AccountMember account = _accountService.GetAccountById(txtUser.Text);
        if (account != null && account.MemberPassword.Equals(txtPass.Password) && account.MemberRole == 1)
        {
            this.Hide();
            MainWindow mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
            this.Close();
        }
        else
        {
            MessageBox.Show("You are not permission!");
        }
    }

    private void btnCancel_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
}