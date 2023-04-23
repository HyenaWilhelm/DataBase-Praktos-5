using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
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
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        private string user_login = "user_login";
        private string user_password = "user_password";
        private string admin_login = "adminlogin";
        private string admin_password = "adminlogin";

        public FirstPage()
        {
            /*List<string> list = new List<string>();*/

            InitializeComponent();
            /*string text = File.ReadAllText("C:\\Users\\Matvey\\Desktop\\Account.json");
            List<Profiles> profiles = JsonConvert.DeserializeObject<List<Profiles>>(text);*/

        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            if ( LoginCheck.Text == user_login || PasswordCheck.Text == user_password ) 
            {
                (Application.Current.MainWindow as MainWindow).ViewHUD.Content = new UserPage();
            }
            else if (LoginCheck.Text == admin_login || PasswordCheck.Text == admin_password )
            {
                (Application.Current.MainWindow as MainWindow).ViewHUD.Content = new AdminPage1();
            }
            else
            {
                LogFail.Text = "Вы ввели неправильный логин или пароль";
            }
        }
    }
}
