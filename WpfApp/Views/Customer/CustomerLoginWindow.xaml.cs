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
using Repositories;
using Services;
using TranTienDatWPF.Views.Customer;


namespace TranTienDatWPF.Views.Customer
{
    /// <summary>
    /// Interaction logic for CustomerLoginWindow.xaml
    /// </summary>
    public partial class CustomerLoginWindow : Window
    {
        //public Customer? LoggedInCustomer { get; set; }
        private readonly CustomerService service = new();
        public CustomerLoginWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string phone = txtPhone.Text.Trim();
            string password = txtPassword.Password.Trim();

            var customer = service.GetByPhone(phone);
            if (customer != null && customer.Password == password)
            {
                MessageBox.Show($"Chào mừng {customer.ContactName}!");

                // TODO: mở cửa sổ dành cho khách hàng
                 var customerMain = new CustomerMainWindow(customer);
                 customerMain.Show();
                 this.Close();
            }
            else
            {
                MessageBox.Show("Số điện thoại hoặc mật khẩu không đúng!", "Đăng nhập thất bại", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
