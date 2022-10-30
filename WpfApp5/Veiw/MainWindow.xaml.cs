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
            InitializeComponent();
            UC_Product uC_Product = new(product);
            UC_Product uC_Product2 = new(product);
            UC_Product uC_Product3 = new(product);
            UC_Product uC_Product4 = new(product);
            UC_Product uC_Product5 = new(product);


            listBoxUserControl1.Items.Add(uC_Product);
          
            listBoxUserControl1.Items.Add(uC_Product2);
            listBoxUserControl1.Items.Add(uC_Product3);
            listBoxUserControl1.Items.Add(uC_Product4);
            listBoxUserControl1.Items.Add(uC_Product5);
        }
    }
}
