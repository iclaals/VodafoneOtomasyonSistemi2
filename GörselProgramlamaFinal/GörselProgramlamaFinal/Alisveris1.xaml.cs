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
    /// Alisverisler.xaml etkileşim mantığı
    /// </summary>
    public partial class Alisveris1 : Window
    {
        VodafoneDbEntities vodafone = new VodafoneDbEntities();

        public void UrunListele()
        {
            dgUrun.ItemsSource = vodafone.Alisverisler.ToList();
        }

        public void Temizle()
        {
            txtMarka.Text = txtModel.Text = txtRenk.Text = txtFiyat.Text = "";
        }

        public Alisveris1()
        {
            InitializeComponent();
            UrunListele();
        }       
        private void dgUrun_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>
            {
                txtMarka,
                txtModel,             
                txtRenk,
                txtFiyat,
                txtId
            };

            

            foreach (var selectedCell in dgUrun.SelectedCells)
            {
                var selectedColumn = selectedCell.Column;
                var selectedCellContent = selectedCell.Column.GetCellContent(selectedCell.Item);
                var selectedValue = (selectedCellContent as TextBlock)?.Text;

                if(!string.IsNullOrEmpty(selectedValue))
                {
                    var columnIndex = selectedColumn.DisplayIndex;

                    if(columnIndex < textBoxes.Count)
                    {
                        textBoxes[columnIndex].Text = selectedValue;
                    }
                }
            }
        }

        private void btnEkle_Click_1(object sender, RoutedEventArgs e)
        {
            Alisveris urun = new Alisveris();
            urun.Marka = txtMarka.Text;
            urun.Model = txtModel.Text;
            urun.Renk = txtRenk.Text;
            urun.Fiyat = int.Parse(txtFiyat.Text);
            vodafone.Alisverisler.Add(urun);
            vodafone.SaveChanges();
            MessageBox.Show("Ürün Bilgileri Kaydoldu");
            UrunListele();
            Temizle();
        }

        private void btnSil_Click_1(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı",
                MessageBoxButton.YesNo, MessageBoxImage.Warning)
                == MessageBoxResult.Yes)
            {
                Alisveris sil = dgUrun.SelectedItem as Alisveris;
                vodafone.Alisverisler.Remove(vodafone.Alisverisler.First(x => x.UrunId == sil.UrunId));
                MessageBox.Show("Ürün Bilgileri Silindi");
                vodafone.SaveChanges();
                UrunListele();
                Temizle();
            }
        }


        private void btnGuncelle_Click_1(object sender, RoutedEventArgs e)
        {
            int id;
            if (int.TryParse(txtId.Text, out id))
            {
                var upd = vodafone.Alisverisler.Where(x => x.UrunId == id).FirstOrDefault();
                upd.Marka = txtMarka.Text;
                upd.Model = txtModel.Text;
                upd.Renk = txtRenk.Text;
                upd.Fiyat = int.Parse(txtFiyat.Text);
                vodafone.SaveChanges();
                MessageBox.Show("Ürün Bilgileri Güncellendi");
                UrunListele();
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

        private void txtId_TextChanged(object sender, TextChangedEventArgs e)
        {
            int urunId;
            if (int.TryParse(txtId.Text, out urunId))
            {               
                var alisveris = vodafone.Alisverisler.FirstOrDefault(a => a.UrunId == urunId);

                if (alisveris != null)
                {                   
                    txtId.Text = urunId.ToString();                    
                    UrunListele();
                    Temizle();
                }
                else
                {                   
                    txtId.Text = string.Empty;
                }
            }
            else
            {                
                txtId.Text = string.Empty;
            }
        }
    }
}
