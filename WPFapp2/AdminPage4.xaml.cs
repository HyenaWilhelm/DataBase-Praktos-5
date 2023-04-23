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

namespace WPFapp2
{
    /// <summary>
    /// Логика взаимодействия для AdminPage4.xaml
    /// </summary>
    public partial class AdminPage4 : Page
    {
        public AdminPage4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).ViewHUD.Content = new FirstPage();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).ViewHUD.Content = new AdminPage2();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).ViewHUD.Content = new AdminPage3();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).ViewHUD.Content = new AdminPage4();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }
    }
}
