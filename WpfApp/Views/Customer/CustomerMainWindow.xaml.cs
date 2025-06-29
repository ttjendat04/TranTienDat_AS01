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
using CustomerBO = BusinessObjects.Customer;
using BusinessObjects;
using TranTienDatWPF.ViewModels.Customer;

namespace TranTienDatWPF.Views.Customer
{
    /// <summary>
    /// Interaction logic for CustomerMainWindow.xaml
    /// </summary>
    public partial class CustomerMainWindow : Window
    {
        private readonly CustomerBO currentCustomer;
        private CustomerOrderViewModel viewModel;
        public CustomerMainWindow(CustomerBO customer)
        {
            InitializeComponent();
            currentCustomer = customer;
            this.Title = $"Khách hàng: {currentCustomer.ContactName}";
            dgOrderHistory.ItemsSource = new CustomerOrderViewModel(customer.CustomerID).Orders;

        }

        private void LoadOrderHistory()
        {
            var orders = DataAccessLayer.DataContext.Orders
                .Where(o => o.CustomerID == currentCustomer.CustomerID)
                .Select(o => new OrderDisplay
                {
                    OrderID = o.OrderID,
                    OrderDate = o.OrderDate,
                    TotalAmount = o.OrderDetails.Sum(d => 
                    d.UnitPrice * d.Quantity * (1 - (decimal)d.Discount))
                })
                .ToList();

            dgOrderHistory.ItemsSource = orders;
        }
        private void BtnEditProfile_Click(object sender, RoutedEventArgs e)
        {
            var editWindow = new EditCustomerWindow(currentCustomer);
            if (editWindow.ShowDialog() == true)
            {
                MessageBox.Show("Hồ sơ đã được cập nhật!");
                // Bạn có thể reload lại UI nếu cần thiết
                this.Title = $"Khách hàng: {currentCustomer.ContactName}";
            }
        }


    }
}
