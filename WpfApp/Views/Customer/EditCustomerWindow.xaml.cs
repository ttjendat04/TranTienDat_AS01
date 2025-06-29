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
    /// Interaction logic for EditCustomerWindow.xaml
    /// </summary>
    public partial class EditCustomerWindow : Window
    {
        public CustomerBO Customer { get; private set; }
        public EditCustomerWindow(CustomerBO existingCustomer)
        {
            InitializeComponent();
            Customer = existingCustomer;

            txtCompanyName.Text = Customer.CompanyName;
            txtContactName.Text = Customer.ContactName;
            txtContactTitle.Text = Customer.ContactTitle;
            txtAddress.Text = Customer.Address;
        }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            Customer.CompanyName = txtCompanyName.Text;
            Customer.ContactName = txtContactName.Text;
            Customer.ContactTitle = txtContactTitle.Text;
            Customer.Address = txtAddress.Text;

            DialogResult = true;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
