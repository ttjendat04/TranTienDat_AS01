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
using BusinessObjects;
using TranTienDatWPF.Views.Admin;
using TranTienDatWPF.ViewModels.Admin;
using CustomerBO = BusinessObjects.Customer;


namespace TranTienDatWPF.Views.Admin

{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CustomerViewModel vm = new CustomerViewModel();
        private ProductViewModel pvm = new ProductViewModel();
        

        public MainWindow()
        {
            InitializeComponent();
            //dgCustomers.ItemsSource = vm.Customers;
            dgCustomers.ItemsSource = vm.Customers;
            dgProducts.ItemsSource = pvm.Products;
        }

        private void BtnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            var popup = new AddCustomerWindow();
            if (popup.ShowDialog() == true && popup.NewCustomer != null)
            {
                vm.AddCustomer(popup.NewCustomer);
            }
        }

        private void BtnSearchCustomer_Click(object sender, RoutedEventArgs e)
        {
            vm.Search(txtSearchCustomer.Text);
            dgCustomers.ItemsSource = vm.Customers;
        }
        private void BtnSearchProduct_Click(object sender, RoutedEventArgs e)
        {
            pvm.Search(txtSearchProduct.Text);
            dgProducts.ItemsSource = pvm.Products;
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            var popup = new AddProductWindow();
            if (popup.ShowDialog() == true && popup.NewProduct != null)
            {
                pvm.AddProduct(popup.NewProduct);
                dgProducts.ItemsSource = pvm.Products;
            }
        }

        private readonly OrderViewModel orderVM = new();

        private void BtnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            var newOrder = new Order
            {
                OrderID = new Random().Next(1000, 9999),
                CustomerID = 1,
                EmployeeID = 1,
                OrderDate = DateTime.Now,
                OrderDetails = new List<OrderDetail>
        {
            new OrderDetail { ProductID = 101, UnitPrice = 50, Quantity = 2, Discount = 0.1 },
            new OrderDetail { ProductID = 102, UnitPrice = 100, Quantity = 1, Discount = 0 }
        }
            };

            orderVM.AddOrder(newOrder);
            dgOrders.ItemsSource = orderVM.Orders;
        }

        private void BtnEditCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (dgCustomers.SelectedItem is CustomerBO selected)
            {
                var popup = new AddCustomerWindow(selected); // sửa cửa sổ để nhận Customer
                if (popup.ShowDialog() == true && popup.NewCustomer != null)
                {
                    vm.UpdateCustomer(popup.NewCustomer);
                    dgCustomers.ItemsSource = null;
                    dgCustomers.ItemsSource = vm.Customers;
                }
            }
        }

        private void BtnDeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (dgCustomers.SelectedItem is CustomerBO selected)
            {
                var result = MessageBox.Show($"Xóa khách hàng {selected.CompanyName}?", "Xác nhận", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    vm.DeleteCustomer(selected.CustomerID);
                }
            }
        }

        private void BtnEditProduct_Click(object sender, RoutedEventArgs e)
        {
            if (dgProducts.SelectedItem is Product selected)
            {
                var popup = new AddProductWindow(selected); // form nhận product
                if (popup.ShowDialog() == true && popup.NewProduct != null)
                {
                    pvm.UpdateProduct(popup.NewProduct);
                    dgProducts.ItemsSource = null;
                    dgProducts.ItemsSource = pvm.Products;
                }
            }
        }

        private void BtnDeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            if (dgProducts.SelectedItem is Product selected)
            {
                var result = MessageBox.Show($"Xóa sản phẩm {selected.ProductName}?", "Xác nhận", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    pvm.DeleteProduct(selected.ProductID);
                    dgProducts.ItemsSource = null;
                    dgProducts.ItemsSource = pvm.Products;
                }
            }
        }

        private void BtnGenerateReport_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Chức năng báo cáo đang được phát triển.");
        }





        private void dgCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}