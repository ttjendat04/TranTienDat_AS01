using System.Configuration;
using System.Data;
using System.Windows;
using TranTienDatWPF.Views.Customer;

namespace TranTienDatWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Gọi cửa sổ đăng nhập của khách hàng
            var loginWindow = new CustomerLoginWindow();
            loginWindow.Show();
        }
    }

}
