using Microsoft.EntityFrameworkCore;
using PraktikaLitvinov.Classes;
using PraktikaLitvinov.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var login = LoginBox.Text;
            var password = Pass.Text;

            var context = new AppDbContext();

            var user = context.Users.SingleOrDefault(x => (x.Login == login || x.Email == login) && x.Password == password);
            if (user is null)
            {
                ErrorBox.Text = "Неправильный логин или пароль";
                return;
            }
            MessageBox.Show("Вы успешно вошли в аккаунт!");
            int id = user.ID;
            Hi hi = new Hi(id);
            hi.Show();
            this.Hide();
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PasswordBox.Visibility = Visibility.Collapsed;
            Pass.Text = PasswordBox.Password;
            Pass.Visibility = Visibility.Visible;
            PasswordHiddenBtn.Visibility = Visibility.Collapsed;
            PasswordOpenBtn.Visibility = Visibility.Visible;
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            PasswordBox.Visibility = Visibility.Visible;
            PasswordBox.Password = Pass.Text;
            Pass.Visibility = Visibility.Collapsed;
            PasswordHiddenBtn.Visibility = Visibility.Visible;
            PasswordOpenBtn.Visibility = Visibility.Collapsed;
        }
        
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
