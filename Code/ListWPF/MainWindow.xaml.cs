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

namespace ListWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> dsDuLieu = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnThem_Click(object sender, RoutedEventArgs e)
        {
            //x là giá trị muốn đưa vào cuối danh sách
            int x = int.Parse(txtGiaTri.Text);
            //thêm x vào ds
            dsDuLieu.Add(x);
            HienThiDanhDanh();
            txtGiaTri.Text = "";
        }
        //Hàm hiển thị danh sách lên giao diện
        void HienThiDanhDanh()
        {
            lstDuLieu.Items.Clear();
            for (int i = 0; i < dsDuLieu.Count; i++)
            {
                int x = dsDuLieu[i];
                lstDuLieu.Items.Add(x);
            }
        }

        private void BtnChen_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtGiatriChen.Text);
            int vt = int.Parse(txtViTriChen.Text);
            dsDuLieu.Insert(vt,x);
            HienThiDanhDanh();
            txtViTriChen.Text = "";
            txtGiatriChen.Text = "";
        }

        private void BtnSapXepTang_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Sort();
            HienThiDanhDanh();
        }

        private void BtnSapXepGiam_Click(object sender, RoutedEventArgs e)
        {
            //Sáp xếp tăng dần
            dsDuLieu.Sort();
            //đảo lại danh sách
            dsDuLieu.Reverse();
            HienThiDanhDanh();
        }

        private void BtnXoa1PhanTu_Click(object sender, RoutedEventArgs e)
        {
            if (lstDuLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn phần tử mới xóa được", "Thông báo lỗi", MessageBoxButton.OK);
                return;
            }
            dsDuLieu.RemoveAt(lstDuLieu.SelectedIndex);
            HienThiDanhDanh();
        }

        private void BtnXoaNhieuPhanTu_Click(object sender, RoutedEventArgs e)
        {
            if (lstDuLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn phần tử mới xóa được",
                    "Thông báo lỗi", MessageBoxButton.OK);
                return;
            }

            while (lstDuLieu.SelectedItems.Count>0)
            {
                int data = (int)lstDuLieu.SelectedItems[0];
                dsDuLieu.Remove(data);
                lstDuLieu.Items.Remove(data);
            }
        }

        private void BtnXoaToanBoPhanTu_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Clear();
            HienThiDanhDanh();
        }

    }
}