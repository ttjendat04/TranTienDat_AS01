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
using WpfApp.ViewModels;

namespace WpfApp
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

        /*private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            vm.Search(txtSearch.Text);
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            var popup = new AddCustomerWindow();
            if (popup.ShowDialog() == true && popup.NewCustomer != null)
            {
                vm.AddCustomer(popup.NewCustomer);
            }
        }*/
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



    }
}