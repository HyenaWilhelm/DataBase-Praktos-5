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
    /// Логика взаимодействия для UserMainWin.xaml
    /// </summary>
    public partial class UserMainWin : Page
    {
        SchoolTableAdapter school = new SchoolTableAdapter();
        public UserMainWin()
        {
            InitializeComponent();
            SchoolInfo.ItemsSource = school.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
