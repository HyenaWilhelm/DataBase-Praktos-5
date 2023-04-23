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
    /// Логика взаимодействия для AdminPage2.xaml
    /// </summary>
    public partial class AdminPage2 : Page
    {
        TeachersTableAdapter teachers = new TeachersTableAdapter();
        public AdminPage2()
        {
            InitializeComponent();
            TeachersInfo.ItemsSource = teachers.GetData();
            TeachersInfo.DisplayMemberPath = "teachers_name";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).ViewHUD.Content = new AdminPage4();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).ViewHUD.Content = new AdminPage3();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).ViewHUD.Content = new AdminPage2();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).ViewHUD.Content = new FirstPage();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            teachers.InsertQuery(MyTbx.Text);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            object id = (TeachersInfo.SelectedItem as DataRowView).Row[0];
            teachers.DeleteQuery(Convert.ToInt32(id));
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            object id2 = (TeachersInfo.SelectedItem as DataRowView).Row[0];
            teachers.UpdateQuery(MyTbx.Text, Convert.ToInt32(id2));
        }
    }
}
