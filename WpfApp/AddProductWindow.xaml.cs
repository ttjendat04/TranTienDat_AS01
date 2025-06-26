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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {
        public Product? NewProduct { get; set; }
        public AddProductWindow()
        {
            InitializeComponent();
        }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            NewProduct = new Product
            {
                ProductID = new Random().Next(1000, 9999),
                ProductName = txtProductName.Text,
                UnitPrice = decimal.TryParse(txtPrice.Text, out var price) ? price : 0,
                UnitsInStock = int.TryParse(txtStock.Text, out var stock) ? stock : 0
            };

            DialogResult = true;
            Close();
        }
    }
}
