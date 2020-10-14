using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using System.Windows.Threading;


namespace Кокорин_и_Сухачев
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PageViewer.Navigate(new Page1());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PageViewer.Navigate(new Page2());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PageViewer.Navigate(new Page3());
        }





    }
}
