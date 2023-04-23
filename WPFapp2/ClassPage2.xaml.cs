using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для ClassPage2.xaml
    /// </summary>
    public partial class ClassPage2 : Page
    {
        Class_first_BTableAdapter adapter = new Class_first_BTableAdapter();
        public ClassPage2()
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
            adapter.InsertQuery(MyTbx.Text);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            object id = (ClassInfo.SelectedItem as DataRowView).Row[0];
            adapter.DeleteQuery(Convert.ToInt32(id));
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            object id2 = (ClassInfo.SelectedItem as DataRowView).Row[0];
            adapter.UpdateQuery(MyTbx.Text, Convert.ToInt32(id2));
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).ViewHUD.Content = new ClassPage1();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).ViewHUD.Content = new ClassPage2();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).ViewHUD.Content = new ClassPage3();
        }
    }
}
