using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewHUD.Content = new FirstPage();
            
            /*Profiles User = new Profiles();
            User.login = "user";
            User.password = "user_password";

            Profiles Admin = new Profiles();
            Admin.login = "admin";
            Admin.password = "admin_password";
            List<Profiles> profiles = new List<Profiles>();
            profiles.Add(Admin);
            profiles.Add(User);

            string json = JsonConvert.SerializeObject(profiles);
            File.WriteAllText("C:\\Users\\Matvey\\Desktop\\Account.json", json);*/
        }
    }
}
