using Microsoft.EntityFrameworkCore;
using PraktikaLitvinov.Classes;
using PraktikaLitvinov.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

namespace PraktikaLitvinov
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();

            reg.Show();

            this.Hide();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Vhod_Click(object sender, RoutedEventArgs e)
        {
           /* var email = log.Text;
            var login = log.Text;
            var password = pas.Text;
            var context = new AppDbContext();

            var user = context.Users.SingleOrDefault(x => x.Login == login || x.Login == email && x.Password == password);
            if (user is null)
            {
                MessageBox.Show("Неправильный логин или пароль!");
                return;
            }
            MessageBox.Show("вы успешно вошли в аккаунт"); */
        }
    }
}
