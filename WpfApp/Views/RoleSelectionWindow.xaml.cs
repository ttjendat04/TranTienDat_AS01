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
using TranTienDatWPF.Views.Customer;
using WpfApp;

namespace TranTienDatWPF
{
    /// <summary>
    /// Interaction logic for RoleSelectionWindow.xaml
    /// </summary>
    public partial class RoleSelectionWindow : Window
    {
        public RoleSelectionWindow()
        {
            InitializeComponent();
        }

        private void Customer_Click(object sender, RoutedEventArgs e)
        {
            var customerLogin = new CustomerLoginWindow();
            customerLogin.Show();
            this.Close();
        }

        private void Employee_Click(object sender, RoutedEventArgs e)
        {
            var adminLogin = new LoginWindow(); // login cho employee/admin
            adminLogin.Show();
            this.Close();
        }
    }
}
