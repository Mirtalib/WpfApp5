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
using WpfApp5.Models;
using WpfApp5.User_Control;

namespace WpfApp5.Veiw
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            Product product = new(12, "new", 123, DateTime.Now);
            Product product2 = new(12, "new", 123, DateTime.Now);

            InitializeComponent();
            UC_Product uC_Product = new UC_Product();
            uC_Product.product = product;
            UC_Product uC_Product2 = new();
            uC_Product2.product = product2;
            


            pnlProducts.Children.Add(uC_Product);
            pnlProducts.Children.Add(uC_Product2);

        }

        private void btnShoping_Click(object sender, RoutedEventArgs e)
        {

            List<UC_Product> uc_Products = new List<UC_Product>();

            UC_Product? product;
            
            foreach (var item in pnlProducts.Children)
            {
                product = item as UC_Product;
                if (product is null)
                    return;
                switch (product.isAdd)
                {
                    case true:
                        uc_Products.Add(product);
                        break;
                    default:
                        break;
                }
            }
            ShopProduct shopProduct = new ShopProduct(uc_Products);
            shopProduct.ShowDialog();
        }

        private void btnFavorites_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
