using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls;
using BusinessObjects;
using Microsoft.Extensions.DependencyInjection;
using Repositories.Payload.Response;
using Services;

namespace ProductManagement;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IProductService _productService;
    private readonly ICategoryService _categoryService;
    
    public MainWindow(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        _productService = _serviceProvider.GetRequiredService<IProductService>();
        _categoryService = _serviceProvider.GetRequiredService<ICategoryService>();
        InitializeComponent();
    }

    public void LoadCategoryList()
    {
        try
        {
            var categoryList = _categoryService.GetCategories();
            cboCategory.ItemsSource = categoryList;
            cboCategory.DisplayMemberPath = "CategoryName";
            cboCategory.SelectedValuePath = "CategoryId";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error on load list of categories");
        }
    }

    public void LoadProductList()
    {
        try
        {
            var productList = _productService.GetProducts();
            /*
            Console.WriteLine(productList);
            */
            dgData.ItemsSource = new List<ProductResponse>(productList);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            MessageBox.Show(ex.Message, "Error on load list of products");
        }
        finally
        {
            ResetInput();
        }
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        LoadCategoryList();
        LoadProductList(); 
    }

    private void btnCreate_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            Product product = new Product();
            List<ProductResponse> productList = _productService.GetProducts();
            product.ProductId = productList[productList.Count-1].ProductId + 1;
            product.ProductName = txtProductName.Text;
            product.UnitPrice = Decimal.Parse(txtPrice.Text);
            product.UnitsInStock = short.Parse(txtUnitsInStock.Text);
            product.CategoryId = Int32.Parse(cboCategory.SelectedValue.ToString() ?? string.Empty);
            _productService.SaveProduct(product);
            LoadProductList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        
    }

    private void dgData_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (dgData.SelectedValue is ProductResponse productResponse)
        {
            Console.WriteLine(productResponse.ProductId);
            string id = productResponse.ProductId.ToString();
            Product product = _productService.GetProductById(Int32.Parse(id));
            txtProductID.Text = product.ProductId.ToString();
            txtProductName.Text = product.ProductName;
            txtPrice.Text = product.UnitPrice.ToString();
            txtUnitsInStock.Text = product.UnitsInStock.ToString();
            cboCategory.SelectedValue = product.CategoryId;
        }
        
    }

    private void btnClose_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }

    private void btnUpdate_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            if (txtProductID.Text.Length > 0)
            {
                Product product = new Product();
                product.ProductId = Int32.Parse(txtProductID.Text);
                product.ProductName = txtProductName.Text;
                product.UnitPrice = Decimal.Parse(txtPrice.Text);
                product.UnitsInStock = short.Parse(txtUnitsInStock.Text);
                product.CategoryId = Int32.Parse(cboCategory.SelectedValue.ToString());
                _productService.UpdateProduct(product);
                LoadProductList();
            }
            else
            {
                MessageBox.Show("You must select a Product!");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btnDelete_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            if (txtProductID.Text.Length > 0)
            {
                Product product = new Product();
                product.ProductId = Int32.Parse(txtProductID.Text);
                product.ProductName = txtProductName.Text;
                product.UnitPrice = Decimal.Parse(txtPrice.Text);
                product.UnitsInStock = short.Parse(txtUnitsInStock.Text);
                product.CategoryId = Int32.Parse(cboCategory.SelectedValue.ToString());
                _productService.DeleteProduct(product);
                LoadProductList();
            }
            else
            {
                MessageBox.Show("You must select a Product!");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private void ResetInput()
    {
        txtProductID.Text = string.Empty;
        txtProductName.Text = string.Empty;
        txtPrice.Text = "";
        txtUnitsInStock.Text = "";
        cboCategory.SelectedValue = 0;
    }

}