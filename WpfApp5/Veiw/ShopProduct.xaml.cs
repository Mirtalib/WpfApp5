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
using WpfApp5.User_Control;

namespace WpfApp5.Veiw
{
    public partial class ShopProduct : Window
    {
        public List<UC_Product> uC_Product { get; set; }
        public ShopProduct(List<UC_Product> _uC_Product)
        {
            InitializeComponent();

            uC_Product = _uC_Product;

            if (uC_Product is not null)
            {
                foreach (var item in uC_Product)
                    listBoxProduct.Items.Add(item);
            }

        }
    }
}
