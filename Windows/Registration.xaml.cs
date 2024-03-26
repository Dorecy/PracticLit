using PraktikaLitvinov.Classes;
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
using System.Windows.Shapes;

namespace PraktikaLitvinov
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Vxod_Click(object sender, RoutedEventArgs e)
        {
            MainWindow avt = new MainWindow();

            avt.Show();

            this.Hide();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            var login = loginreg.Text;
            var pass = passwordreg.Text;
            var email = emailreg.Text;

            var context = new AppDbContext();

            var user_exists = context.Users.FirstOrDefault( x => x.Login == login);
            if (user_exists is not null) 
            {
                MessageBox.Show("Такой пользователь уже в клубе крутышек");
                return;
            }
            var user = new User { Login = login, Password = pass};
            context.Users.Add(user);
            context.SaveChanges();
            MainWindow avt = new MainWindow();

            avt.Show();

            this.Hide();
        }
    }
}
