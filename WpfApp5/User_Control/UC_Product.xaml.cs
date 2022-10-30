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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp5.Models;
using WpfApp5.Veiw;

namespace WpfApp5.User_Control
{
    /// <summary>
    /// Interaction logic for UC_Product.xaml
    /// </summary>
    public partial class UC_Product : UserControl
    {
        Product product1 = null;
        public UC_Product(Product product)
        {
            InitializeComponent();
            product1 = product;


            txtBoxIDProduct.Text = product.Id.ToString();
            txtBoxNameProduct.Text = product.Name;
            txtBoxPriceProduct.Text = product.Price.ToString();
            txtBoxProductionDate.Text = product.DateTime.ToLongDateString();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            EditProduct editProduct = new();

            editProduct.product = product1;

            editProduct.ShowDialog();

        }
    }
}
