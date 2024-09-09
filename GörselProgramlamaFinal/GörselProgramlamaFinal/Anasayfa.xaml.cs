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

namespace GörselProgramlamaFinal
{
    /// <summary>
    /// Anasayfa.xaml etkileşim mantığı
    /// </summary>
    public partial class Anasayfa : Window
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btnHat_Click(object sender, RoutedEventArgs e)
        {
            Hat hat = new Hat();
            hat.Show();
            this.Hide();
        }

        private void btnModem_Click(object sender, RoutedEventArgs e)
        {
            Modem modem = new Modem();
            modem.Show();
            this.Hide();
        }

        private void btnAlisverisler_Click(object sender, RoutedEventArgs e)
        {
            Alisveris1 Alisverisler1 = new Alisveris1();
            Alisverisler1.Show();
            this.Hide();
        }
    }
}
