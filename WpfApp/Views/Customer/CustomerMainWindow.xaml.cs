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

namespace TranTienDatWPF.Views.Customer
{
    /// <summary>
    /// Interaction logic for CustomerMainWindow.xaml
    /// </summary>
    public partial class CustomerMainWindow : Window
    {
        private readonly CustomerBO _customer;
        public CustomerMainWindow(CustomerBO customer)
        {
            InitializeComponent();
            _customer = customer;
            txtWelcome.Text = $"Xin chào, {_customer.ContactName}!";
        }
    }
}
