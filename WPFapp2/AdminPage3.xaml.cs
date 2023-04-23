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
using WPFapp2.shool_dbDataSetTableAdapters;

namespace WPFapp2
{
    /// <summary>
    /// Логика взаимодействия для AdminPage3.xaml
    /// </summary>
    public partial class AdminPage3 : Page
    {
        public AdminPage3()
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*if (CbxPageChange.Text == "1A")
            {
                (Application.Current.MainWindow as MainWindow).ViewHUD.Content = new TimetablePage1();.
            }

            else if (CbxPageChange.Text == "1Б")
            {
                (Application.Current.MainWindow as MainWindow).ViewHUD.Content = new UserPage();
            }*/
        }
    }
}
