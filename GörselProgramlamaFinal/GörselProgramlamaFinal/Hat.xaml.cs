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
    /// Hat.xaml etkileşim mantığı
    /// </summary>
    public partial class Hat : Window
    {
        VodafoneDbEntities vodafone = new VodafoneDbEntities();
        public void HatListele()
        {
            dgHat.ItemsSource = vodafone.Hatlar.ToList();
        }

        public void Temizle()
        {
            txtAd.Text = txtSoyad.Text = txtKimlik.Text = txtSehir.Text = "";
        }

        public Hat()
        {
            InitializeComponent();
            HatListele();
        }

        private void dgHat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>
            {
                txtId,
                txtAd,
                txtSoyad,
                txtKimlik,
                txtSehir
             
            };

            foreach (var textBox in textBoxes)
            {
                textBox.Clear();
            }

            foreach (var selectedCell in dgHat.SelectedCells)
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
            Hats hatlar = new Hats();
            hatlar.Ad = txtAd.Text;
            hatlar.Soyad = txtSoyad.Text;
            hatlar.Kimlik = int.Parse(txtKimlik.Text);
            hatlar.Sehir = txtSehir.Text;
            vodafone.Hatlar.Add(hatlar);
            vodafone.SaveChanges();
            MessageBox.Show("Hat Başvuru Bilgileri Kaydoldu");
            HatListele();
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
                Hats sil = dgHat.SelectedItem as Hats;
                vodafone.Hatlar.Remove(vodafone.Hatlar.First(x => x.HatId == sil.HatId));
                MessageBox.Show("Hat Başvuru Bilgileri Silindi");
                vodafone.SaveChanges();
                HatListele();
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
                var upd = vodafone.Hatlar.Where(x => x.HatId == id).FirstOrDefault();
                upd.Ad = txtAd.Text;
                upd.Soyad = txtSoyad.Text;
                upd.Kimlik = int.Parse(txtKimlik.Text);
                upd.Sehir = txtSehir.Text;
                vodafone.SaveChanges();
                MessageBox.Show("Hat Bilgileri Güncellendi");
                HatListele();
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
