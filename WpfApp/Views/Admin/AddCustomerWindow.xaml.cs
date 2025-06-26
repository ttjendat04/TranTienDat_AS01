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


namespace TranTienDatWPF.Views.Admin

{
    /// <summary>
    /// Interaction logic for AddCustomerWindow.xaml
    /// </summary>
    public partial class AddCustomerWindow : Window
    {
        public CustomerBO? NewCustomer { get; set; }
        public AddCustomerWindow(CustomerBO? existing = null)
        {
            InitializeComponent();

            if (existing != null)
            {
                txtCompanyName.Text = existing.CompanyName;
                txtContactName.Text = existing.ContactName;
                txtContactTitle.Text = existing.ContactTitle;
                txtAddress.Text = existing.Address;
                txtPhone.Text = existing.Phone;
                NewCustomer = existing;
            }
        }


       
        

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (NewCustomer == null)
            {
                NewCustomer = new CustomerBO
                {
                    CustomerID = new Random().Next(1000, 9999)
                };
            }

            // Dù là thêm hay sửa thì cập nhật lại các trường
            NewCustomer.CompanyName = txtCompanyName.Text;
            NewCustomer.ContactName = txtContactName.Text;
            NewCustomer.ContactTitle = txtContactTitle.Text;
            NewCustomer.Address = txtAddress.Text;
            NewCustomer.Phone = txtPhone.Text;

            DialogResult = true;
            Close();
        }
    }
}
