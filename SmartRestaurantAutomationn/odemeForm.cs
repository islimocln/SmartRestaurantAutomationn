using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SmartRestaurantAutomationn
{
    public partial class odemeForm : Form
    {
        public odemeForm()
        {
            InitializeComponent();
            LoadMasalar();
        }

        // Dinamik masa butonlarını yükler
        private void LoadMasalar()
        {
            flowLayoutPanelMasalar.Controls.Clear();

            for (int i = 1; i <= 20; i++) // 20 masa için buton oluştur
            {
                Button masaButton = new Button
                {
                    Text = i.ToString(),
                    Width = 50,
                    Height = 50,
                    Tag = i // Masa numarasını sakla
                };

                masaButton.Click += MasaButton_Click; // Tıklama olayını bağla
                flowLayoutPanelMasalar.Controls.Add(masaButton);
            }
        }

        // Masa seçildiğinde çalışır
        private void MasaButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int masaId = (int)clickedButton.Tag;

            // Veritabanından masa siparişlerini çek
            List<string> siparisler = GetLastOrderDetails(masaId);

            listBoxSiparisler.Items.Clear();

            if (siparisler.Count > 0)
            {
                foreach (var siparis in siparisler)
                {
                    listBoxSiparisler.Items.Add(siparis);
                }
            }
            else
            {
                MessageBox.Show($"Masa {masaId} için kayıtlı sipariş bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private List<string> GetLastOrderDetails(int masaId)
        {
            List<string> siparisDetaylari = new List<string>();
            decimal toplamTutar = 0;

            try
            {
                DatabaseConnector db = new DatabaseConnector();
                string query = @"SELECT od.UrunAdi, od.Fiyat
                                FROM orders o
                                JOIN orderdetails od ON o.OrderID = od.OrderID
                                WHERE o.MasaNo = @MasaNo
                                ORDER BY o.OrderDate DESC;";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@MasaNo", masaId);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string urun = reader["UrunAdi"].ToString();
                    decimal fiyat = Convert.ToDecimal(reader["Fiyat"]);
                    toplamTutar += fiyat;
                    siparisDetaylari.Add($"{urun} - {fiyat} TL");
                }
                reader.Close();
                db.Connection.Close();

                // Toplam tutarı Ödenecek Tutar label'ına yazdır
                labelTotal.Text = $"Toplam: {toplamTutar} TL";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sipariş detayları alınırken bir hata oluştu: {ex.Message}");
            }

            return siparisDetaylari;
        }

        public void AddToListBox(string urun)
        {
            listBoxSiparisler.Items.Add(urun); // listBoxSiparisler, odemeForm tasarımında tanımlı bir ListBox olmalıdır.
        }

        public void SetTotalAmount(string totalAmount)
        {
            labelTotal.Text = totalAmount; // lblTotal, odemeForm tasarımında tanımlı bir Label olmalıdır.
        }

        private void listBoxSiparisler_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                // Yazı tipi ve boyutunu ayarla
                Font font = new Font("Arial", 12, FontStyle.Bold);
                e.Graphics.DrawString(listBoxSiparisler.Items[e.Index].ToString(), font, Brushes.Black, e.Bounds);
            }
            e.DrawFocusRectangle();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Anasayfa formunu aç
            anasayfa anasayfaForm = new anasayfa();
            anasayfaForm.Show();

            // Şu anki formu gizle
            this.Hide();
        }
        

        private void ComboBoxOdemeYontemi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçim değiştiğinde yapılacak işlemler
            if (comboBoxOdemeSecenek.SelectedItem != null)
            {
                string secilenOdemeYontemi = comboBoxOdemeSecenek.SelectedItem.ToString();
                if (secilenOdemeYontemi == "Nakit")
                {
                    MessageBox.Show("Nakit ödeme seçildi. Kasiyere yönlendirin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (secilenOdemeYontemi == "Kart")
                {
                    MessageBox.Show("Kart ödemesi seçildi. POS cihazını kullanın.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void odemeForm_Load(object sender, EventArgs e)
        {
            // Combobox'a ödeme seçeneklerini ekliyoruz
            comboBoxOdemeSecenek.Items.Add("Nakit");
            comboBoxOdemeSecenek.Items.Add("Kart");

            // İlk seçenek olarak boş bırakıyoruz
            comboBoxOdemeSecenek.SelectedIndex = -1;

            // Event ekleniyor
            comboBoxOdemeSecenek.SelectedIndexChanged += ComboBoxOdemeYontemi_SelectedIndexChanged;
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (comboBoxOdemeSecenek.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string odemeYontemi = comboBoxOdemeSecenek.SelectedItem.ToString();
            decimal toplamTutar = GetTotalAmount();

            if (toplamTutar == 0)
            {
                MessageBox.Show("Toplam tutar sıfır olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DatabaseConnector db = new DatabaseConnector();
                string query = @"INSERT INTO odemeBilgisi (ToplamTutar, OdemeYontemi, OdemeTarihi) 
                         VALUES (@ToplamTutar, @OdemeYontemi, @OdemeTarihi)";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ToplamTutar", toplamTutar);
                cmd.Parameters.AddWithValue("@OdemeYontemi", odemeYontemi);
                cmd.Parameters.AddWithValue("@OdemeTarihi", DateTime.Now);

                cmd.ExecuteNonQuery();
                db.Connection.Close();

                MessageBox.Show("Ödeme başarılı! Teşekkür ederiz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sipariş bilgilerini sıfırla
                listBoxSiparisler.Items.Clear();
                labelTotal.Text = "Toplam: 0 TL";
                comboBoxOdemeSecenek.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ödeme işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal GetTotalAmount()
        {
            // Toplam tutarı al
            return decimal.TryParse(labelTotal.Text.Replace("Toplam: ", "").Replace(" TL", ""), out decimal total) ? total : 0;
        }
    }
}
