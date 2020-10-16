using System;
using System.Collections.Generic;
using System.Data;
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

        public MainWindow()
        {
            InitializeComponent();
            PageViewer.Navigate(new Page());
           

        }

        
        private void btn_news_Click(object sender, RoutedEventArgs e)
        {
            PageViewer.Navigate(new Page3());
        }

        private void btn_black_Click(object sender, RoutedEventArgs e)
        {
            PageViewer.Navigate(new Page2());
        }

        private void btn_himn_Click(object sender, RoutedEventArgs e)
        {
            PageViewer.Navigate(new Page1());
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(1);
        }
    }
}
