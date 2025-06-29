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
using BusinessObjects;
using TranTienDatWPF.ViewModels.Admin;
using CustomerBO = BusinessObjects.Customer;

namespace TranTienDatWPF.Views.Admin
{
    /// <summary>
    /// Interaction logic for AddOrderWindow.xaml
    /// </summary>
    public partial class AddOrderWindow : Window
    {
        private AddOrderViewModel viewModel;

        public Order NewOrder { get; set; }
        public AddOrderWindow()
        {
            InitializeComponent();
            viewModel = new AddOrderViewModel();
            cbCustomer.ItemsSource = viewModel.Customers;
            cbProduct.ItemsSource = viewModel.Products;
            dgOrderDetails.ItemsSource = viewModel.OrderDetails;
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            if (cbProduct.SelectedItem is Product selectedProduct &&
                int.TryParse(txtQuantity.Text, out int quantity) &&
                quantity > 0)
            {
                viewModel.AddToOrder(selectedProduct, quantity);
                dgOrderDetails.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng hợp lệ.");
            }
        }

        private void BtnConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (cbCustomer.SelectedItem is CustomerBO selectedCustomer)
            {
                NewOrder = new Order
                {
                    OrderID = new Random().Next(1000, 9999),
                    CustomerID = selectedCustomer.CustomerID,
                    EmployeeID = 1, // Hoặc thay bằng Employee đang đăng nhập
                    OrderDate = DateTime.Now,
                    OrderDetails = viewModel.OrderDetails.Select(d => new OrderDetail
                    {
                        ProductID = d.ProductID,
                        UnitPrice = d.UnitPrice,
                        Quantity = d.Quantity,
                        Discount = 0
                    }).ToList()
                };

                DialogResult = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
