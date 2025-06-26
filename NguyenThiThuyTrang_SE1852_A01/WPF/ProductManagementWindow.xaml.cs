using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using BusinessObjects;
using DataAccess;

namespace Presentation
{
    public class ProductView
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public string SupplierName { get; set; }
        public string QuantityPerUnit { get; set; }
        public int? UnitsOnOrder { get; set; }
        public int? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }

    /// <summary>
    /// Interaction logic for ProductManagementWindow.xaml
    /// </summary>
    public partial class ProductManagementWindow : Window
    {
        private ProductDAO productDAO;
        private CategoryDAO categoryDAO;
        private List<Product> products;
        private List<Category> categories;

        public ProductManagementWindow()
        {
            InitializeComponent();
            productDAO = new ProductDAO();
            categoryDAO = new CategoryDAO();
            productDAO.InitializeDataset();
            categoryDAO.InitializeDataset();
            LoadProducts();
            LoadCategories();
        }

        private void LoadProducts()
        {
            products = productDAO.GetProducts();
            categories = categoryDAO.GetCategory();
            var productViews = products.Select(p => new ProductView
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                CategoryName = categories.FirstOrDefault(c => c.CategoryId == p.CategoryId)?.CategoryName ?? "",
                UnitPrice = p.UnitPrice,
                UnitsInStock = p.UnitsInStock,
                SupplierName = p.SupplierId.HasValue ? $"NCC {p.SupplierId}" : "",
                QuantityPerUnit = p.QuantityPerUnit,
                UnitsOnOrder = p.UnitsOnOrder,
                ReorderLevel = p.ReorderLevel,
                Discontinued = p.Discontinued
            }).ToList();
            dgProducts.ItemsSource = null;
            dgProducts.ItemsSource = productViews;
        }

        private void LoadCategories()
        {
            categories = categoryDAO.GetCategory();
            cbCategory.ItemsSource = categories;
        }

        // Đúng tên hàm handler cho XAML
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int newId = products.Count > 0 ? products.Max(p => p.ProductId) + 1 : 1;
                var product = new Product
                {
                    ProductId = newId,
                    ProductName = txtProductName.Text,
                    UnitPrice = decimal.TryParse(txtUnitPrice.Text, out var price) ? price : 0,
                    UnitsInStock = int.TryParse(txtUnitsInStock.Text, out var stock) ? stock : 0,
                    SupplierId = int.TryParse(txtSupplierId.Text, out var supplierId) ? supplierId : (int?)null,
                    CategoryId = cbCategory.SelectedValue is int catId ? catId : (int?)null,
                    QuantityPerUnit = txtQuantityPerUnit.Text,
                    UnitsOnOrder = int.TryParse(txtUnitsOnOrder.Text, out var unitsOnOrder) ? unitsOnOrder : 0,
                    ReorderLevel = int.TryParse(txtReorderLevel.Text, out var reorderLevel) ? reorderLevel : 0,
                    Discontinued = chkDiscontinued.IsChecked == true
                };
                var result = productDAO.SaveProduct(product);
                if (result)
                {
                    MessageBox.Show("Thêm sản phẩm thành công.");
                    LoadProducts();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("ID đã tồn tại hoặc thêm thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm sản phẩm: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (int.TryParse(txtProductId.Text, out int id))
                {
                    var product = new Product
                    {
                        ProductId = id,
                        ProductName = txtProductName.Text,
                        UnitPrice = decimal.TryParse(txtUnitPrice.Text, out var price) ? price : 0,
                        UnitsInStock = int.TryParse(txtUnitsInStock.Text, out var stock) ? stock : 0,
                        SupplierId = int.TryParse(txtSupplierId.Text, out var supplierId) ? supplierId : (int?)null,
                        CategoryId = cbCategory.SelectedValue is int catId ? catId : (int?)null,
                        QuantityPerUnit = txtQuantityPerUnit.Text,
                        UnitsOnOrder = int.TryParse(txtUnitsOnOrder.Text, out var unitsOnOrder) ? unitsOnOrder : 0,
                        ReorderLevel = int.TryParse(txtReorderLevel.Text, out var reorderLevel) ? reorderLevel : 0,
                        Discontinued = chkDiscontinued.IsChecked == true
                    };
                    var result = productDAO.UpdateProduct(product);
                    if (result)
                    {
                        MessageBox.Show("Cập nhật sản phẩm thành công.");
                        LoadProducts();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm để cập nhật.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật sản phẩm: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (int.TryParse(txtProductId.Text, out int id))
                {
                    var result = productDAO.DeleteProduct(id);
                    if (result)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công.");
                        LoadProducts();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm để xóa.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa sản phẩm: {ex.Message}");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtProductId.Text = "";
            txtProductName.Text = "";
            txtUnitPrice.Text = "";
            txtUnitsInStock.Text = "";
            if (FindName("txtSupplierId") is TextBox txtSupplierId)
                txtSupplierId.Text = "";
            if (FindName("cbCategory") is ComboBox cbCategory)
                cbCategory.SelectedIndex = -1;
            txtQuantityPerUnit.Text = "";
            txtUnitsOnOrder.Text = "";
            txtReorderLevel.Text = "";
            chkDiscontinued.IsChecked = false;
            dgProducts.SelectedIndex = -1;
        }

        private void dgProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgProducts.SelectedItem is ProductView view)
            {
                var product = products.FirstOrDefault(p => p.ProductId == view.ProductId);
                if (product != null)
                {
                    txtProductId.Text = product.ProductId.ToString();
                    txtProductName.Text = product.ProductName;
                    txtUnitPrice.Text = product.UnitPrice.ToString();
                    txtUnitsInStock.Text = product.UnitsInStock.ToString();
                    if (FindName("txtSupplierId") is TextBox txtSupplierId)
                        txtSupplierId.Text = product.SupplierId?.ToString() ?? "";
                    if (FindName("cbCategory") is ComboBox cbCategory)
                        cbCategory.SelectedValue = product.CategoryId;
                    txtQuantityPerUnit.Text = product.QuantityPerUnit;
                    txtUnitsOnOrder.Text = product.UnitsOnOrder.ToString();
                    txtReorderLevel.Text = product.ReorderLevel.ToString();
                    chkDiscontinued.IsChecked = product.Discontinued;
                }
            }
        }

        // Thêm chức năng tìm kiếm và quay về menu
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadProducts();
            }
            else
            {
                var result = productDAO.SearchByName(keyword);
                dgProducts.ItemsSource = null;
                dgProducts.ItemsSource = result;
            }
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // hoặc mở MainWindow nếu có
        }
    }
}
