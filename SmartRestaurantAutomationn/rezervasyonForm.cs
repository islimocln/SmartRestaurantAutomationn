using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;

namespace SmartRestaurantAutomationn
{
    public partial class RezervasyonForm : XtraForm
    {
        private DatabaseConnector db;

        public RezervasyonForm()
        {
            InitializeComponent();
            db = new DatabaseConnector();
            LoadMasalar();
            LoadReservations();
        }

        private void LoadMasalar()
        {
            flowLayoutPanelMasalar1.Controls.Clear();

            for (int i = 1; i <= 20; i++) // 20 masa
            {
                SimpleButton masaButton = new SimpleButton
                {
                    Text = $"{i}",
                    Width = 50,
                    Height = 50,
                    Appearance = { BackColor = Color.LightGreen, Font = new Font("Arial", 10, FontStyle.Bold) },
                    Tag = i // Masa numarasını saklar
                };

                masaButton.Click += MasaButton_Click; // Tıklama olayını bağla
                flowLayoutPanelMasalar1.Controls.Add(masaButton);
                Console.WriteLine($"Masa {i} eklendi."); // Debug için
            }
          

            Console.WriteLine($"Toplam {flowLayoutPanelMasalar1.Controls.Count} masa yüklendi."); // Buton sayısını kontrol et
        }

        private void LoadReservations()
        {
            string query = "SELECT MasaNo, RezervasyonSaati FROM Rezervasyonlar";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int masaNo = reader.GetInt32("MasaNo");
                            string saat = reader.GetDateTime("RezervasyonSaati").ToString("HH:mm");

                            // Masa düğmesini bul ve güncelle
                            foreach (SimpleButton btn in flowLayoutPanelMasalar1.Controls)
                            {
                                if ((int)btn.Tag == masaNo)
                                {
                                    btn.Appearance.BackColor = Color.Red;
                                    btn.Text = $"{masaNo}\n{saat}"; // Masa numarası ve saat
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Rezervasyonlar yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MasaButton_Click(object sender, EventArgs e)
        {
            SimpleButton clickedButton = sender as SimpleButton;
            int masaNo = (int)clickedButton.Tag;

            // Eğer masa rezerve ise bilgi göster
            if (clickedButton.Appearance.BackColor == Color.Red)
            {
                XtraMessageBox.Show($"Masa {masaNo} zaten rezerve edilmiş.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtSelectedMasa.Text = masaNo.ToString(); // Seçilen masa metin kutusuna yazılır
            }
        }

       

        private void btnRezerveEt_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSelectedMasa.Text))
            {
                XtraMessageBox.Show("Lütfen bir masa seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int masaNo = int.Parse(txtSelectedMasa.Text);
            DateTime rezervasyonSaati = timeEditRezerveSaat.Time;

            try
            {
                string query = "INSERT INTO Rezervasyonlar (MasaNo, RezervasyonSaati) VALUES (@MasaNo, @RezervasyonSaati)";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@MasaNo", masaNo);
                    cmd.Parameters.AddWithValue("@RezervasyonSaati", rezervasyonSaati);
                    cmd.ExecuteNonQuery();
                }

                // Masa rengini kırmızı yap ve üzerine saat ekle
                foreach (SimpleButton btn in flowLayoutPanelMasalar1.Controls)
                {
                    if ((int)btn.Tag == masaNo)
                    {
                        btn.Appearance.BackColor = Color.Red;
                        btn.Text = $"{masaNo}\n{rezervasyonSaati:HH:mm}";
                        break;
                    }
                }

                XtraMessageBox.Show("Rezervasyon başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Rezervasyon eklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRezerveSil_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtSelectedMasa.Text))
            {
                XtraMessageBox.Show("Lütfen bir masa seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int masaNo = int.Parse(txtSelectedMasa.Text);

            try
            {
                string query = "DELETE FROM Rezervasyonlar WHERE MasaNo = @MasaNo";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@MasaNo", masaNo);
                    cmd.ExecuteNonQuery();
                }

                // Masa rengini yeşil yap ve metni sıfırla
                foreach (SimpleButton btn in flowLayoutPanelMasalar1.Controls)
                {
                    if ((int)btn.Tag == masaNo)
                    {
                        btn.Appearance.BackColor = Color.LightGreen;
                        btn.Text = masaNo.ToString();
                        break;
                    }
                }

                XtraMessageBox.Show("Rezervasyon başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Rezervasyon silinirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

