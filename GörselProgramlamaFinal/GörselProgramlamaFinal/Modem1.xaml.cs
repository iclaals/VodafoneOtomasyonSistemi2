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
using System.Windows.Shapes;

namespace GörselProgramlamaFinal
{
    /// <summary>
    /// Modem.xaml etkileşim mantığı
    /// </summary>
    public partial class Modem : Window
    {
        VodafoneDbEntities vodafone = new VodafoneDbEntities();

        public void ModemListele()
        {
            dgModem.ItemsSource = vodafone.Modemler.ToList();
        }

        public void Temizle()
        {
            txtAd.Text = txtSoyad.Text = txtKimlik.Text = txtSehir.Text = "";
        }

        public Modem()
        {
            InitializeComponent();
            ModemListele();
        }

        private void dgModem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>
            {
                txtAd,
                txtSoyad,
                txtKimlik,
                txtSehir,
                txtId
            };

            foreach (var textBox in textBoxes)
            {
                textBox.Clear();
            }

            foreach (var selectedCell in dgModem.SelectedCells)
            {
                var selectedColumn = selectedCell.Column;
                var selectedCellContent = selectedCell.Column.GetCellContent(selectedCell.Item);
                var selectedValue = (selectedCellContent as TextBlock)?.Text;

                if (!string.IsNullOrEmpty(selectedValue))
                {
                    var columnIndex = selectedColumn.DisplayIndex;

                    if (columnIndex < textBoxes.Count)
                    {
                        textBoxes[columnIndex].Text = selectedValue;
                    }
                }
            }
        }

        private void btnEkle_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEkle_Click_1(object sender, RoutedEventArgs e)
        {
            Modems modemler = new Modems();
            modemler.Ad = txtAd.Text;
            modemler.Soyad = txtSoyad.Text;
            modemler.Kimlik = int.Parse(txtKimlik.Text);
            modemler.Sehir = txtSehir.Text;
            vodafone.Modemler.Add(modemler);
            vodafone.SaveChanges();
            MessageBox.Show("Ev İnterneti Başvuru Bilgileri Kaydoldu");
            ModemListele();
            Temizle();
        }

        private void btnSil_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSil_Click_1(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı",
                MessageBoxButton.YesNo, MessageBoxImage.Warning)
                == MessageBoxResult.Yes)
            {
                Modems sil = dgModem.SelectedItem as Modems;
                vodafone.Modemler.Remove(vodafone.Modemler.First(x => x.ModemId == sil.ModemId));
                MessageBox.Show("Ev İnterneti Başvuru Bilgileri Silindi");
                vodafone.SaveChanges();
                ModemListele();
                Temizle();
            }
        }

        private void btnGuncelle_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnGuncelle_Click_1(object sender, RoutedEventArgs e)
        {
            int id;
            if (int.TryParse(txtId.Text, out id))
            {
                var upd = vodafone.Modemler.Where(x => x.ModemId == id).FirstOrDefault();
                upd.Ad = txtAd.Text;
                upd.Soyad = txtSoyad.Text;
                upd.Kimlik = int.Parse(txtKimlik.Text);
                upd.Sehir = txtSehir.Text;
                vodafone.SaveChanges();
                MessageBox.Show("Modem Bilgileri Güncellendi");
                ModemListele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Geçersiz ID girişi!");
            }
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnHome_Click_1(object sender, RoutedEventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }
    }
}
