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

namespace KsaweryApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExcelToJSON_PL_Click(object sender, RoutedEventArgs e)
        {
            gridMenu.Visibility = Visibility.Collapsed;
            gridExcelToJSONPL.Visibility = Visibility.Visible;
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            gridMenu.Visibility = Visibility.Visible;
            gridExcelToJSONPL.Visibility = Visibility.Collapsed;
        }

        private void btnExcelToJSON_ENG_Click(object sender, RoutedEventArgs e)
        {
            gridMenu.Visibility = Visibility.Collapsed;
            gridExcelToJSONENG.Visibility = Visibility.Visible;
        }
        private void btnBack2_Click(object sender, RoutedEventArgs e)
        {
            gridMenu.Visibility = Visibility.Visible;
            gridExcelToJSONENG.Visibility = Visibility.Collapsed;
        }
    }
}
