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

namespace PraktikaLitvinov.Windows
{
    /// <summary>
    /// Логика взаимодействия для Hi.xaml
    /// </summary>
    public partial class Hi : Window
    {
        public int _id;
        public Hi(int id)
        {
            InitializeComponent();

            _id = id;

            int find = id;

            var context = new AppDbContext();

            var user = context.Users.SingleOrDefault(x => x.ID == id);

            string Finde = user.Login;

            bro.Text = Finde;
            


        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow avt = new MainWindow();
            avt.Show();
            this.Hide();
        }
    }
}
