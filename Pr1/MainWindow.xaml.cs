using Pr1.PR1PractikaDataSetTableAdapters;
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
using Pr1.PR1PractikaDataSetTableAdapters;

namespace Pr1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BurgersTableAdapter burgers = new BurgersTableAdapter();
        CustomersTableAdapter customers = new CustomersTableAdapter();
        OrdersTableAdapter orders = new OrdersTableAdapter();   
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Page1();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Page2();
        }

       

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Page3();
        }
    }
}
