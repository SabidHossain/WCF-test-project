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

namespace WcfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ASITService1.ASITServiceClient abc = new ASITService1.ASITServiceClient();
       
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            string x = abc.GetData(10);

            string y = abc.ASITGetData(1);

            string z = abc.SabidGetData(20);

            txtbx1.Text = x;
        }
    }
}
