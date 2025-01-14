using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SmartRestaurantAutomationn
{
    public partial class RaporForm : XtraForm
    {
        private DatabaseConnector db; // Daha önce tanımladığınız DatabaseConnector sınıfını çağırıyoruz

        public RaporForm()
        {
            InitializeComponent();
            db = new DatabaseConnector(); // Veritabanı bağlantısını başlatıyoruz
        }

        private void RaporForm_Load(object sender, EventArgs e)
        {
            ListeyiYenile(); // Form yüklendiğinde raporları göster
        }

        private void btnGunSonuRaporu_Click(object sender, EventArgs e)
        {
            try
            {
                decimal toplamSatis = 0;
                decimal toplamMasraf = 0;

                // Toplam satış sorgusu
                string satisQuery = "SELECT SUM(ToplamTutar) FROM odemeBilgisi";
                using (MySqlCommand cmd = new MySqlCommand(satisQuery, db.Connection))
                {
                    object result = cmd.ExecuteScalar();
                    toplamSatis = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                }

                // Toplam masraf sorgusu
                string masrafQuery = "SELECT SUM(Tutar) FROM masrafGirisi";
                using (MySqlCommand cmd = new MySqlCommand(masrafQuery, db.Connection))
                {
                    object result = cmd.ExecuteScalar();
                    toplamMasraf = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                }

                // Net kar hesaplama
                decimal netKar = toplamSatis - toplamMasraf;

                // Veritabanına rapor kaydetme
                string raporKaydetQuery = "INSERT INTO Rapor (Tarih, ToplamSatis, ToplamMasraf, NetKar) VALUES (@Tarih, @ToplamSatis, @ToplamMasraf, @NetKar)";
                using (MySqlCommand cmd = new MySqlCommand(raporKaydetQuery, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@Tarih", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@ToplamSatis", toplamSatis);
                    cmd.Parameters.AddWithValue("@ToplamMasraf", toplamMasraf);
                    cmd.Parameters.AddWithValue("@NetKar", netKar);
                    cmd.ExecuteNonQuery();
                }

                XtraMessageBox.Show($"Rapor başarıyla oluşturuldu:\nToplam Satış: {toplamSatis} TL\nToplam Masraf: {toplamMasraf} TL\nNet Kar: {netKar} TL",
                                    "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Raporları yeniden yükle
                ListeyiYenile();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Rapor oluşturulurken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListeyiYenile()
        {
            try
            {
                string query = "SELECT * FROM Rapor ORDER BY Tarih DESC";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.Connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // GridControl'e veri bağlama
                    gridControlRapor.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Raporlar yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Ana sayfa formunu aç
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();

            // Bu formu gizle (isteğe bağlı)
            this.Hide();
        }
    }
}
