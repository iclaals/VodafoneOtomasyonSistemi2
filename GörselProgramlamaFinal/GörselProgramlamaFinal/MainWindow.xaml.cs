using GörselProgramlamaFinal.Model;
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

namespace GörselProgramlamaFinal
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            VodafoneDbEntities vodafone = new VodafoneDbEntities();

            string usr = txt_username.Text;
            string ps = txt_password.Password.ToString();
            var bul = vodafone.Logins.FirstOrDefault(user => user.username == usr && user.password == ps);
            if (bul != null)
            {
                Anasayfa ana = new Anasayfa();
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parola hatalı!");
            }
        }
    }
}
