using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SmartRestaurantAutomationn
{
    public partial class MasrafGirisiForm : Form
    {
        private DatabaseConnector db;

        public MasrafGirisiForm()
        {
            InitializeComponent();
            db = new DatabaseConnector(); // Veritabanı bağlantısı başlatılıyor
        }

        

        private void ListeyiYenile()
        {
            try
            {
                string query = "SELECT Aciklama, Tutar, Tarih FROM masrafGirisi ORDER BY Tarih DESC";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.Connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    gridControlMasraflar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Masraflar yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnMasrafKaydet_Click_1(object sender, EventArgs e)
        {
            string aciklama = txtAciklama.Text;
            decimal tutar = spinTutar.Value;

            if (string.IsNullOrWhiteSpace(aciklama) || tutar <= 0)
            {
                XtraMessageBox.Show("Geçerli bir açıklama ve tutar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = "INSERT INTO masrafGirisi (Aciklama, Tutar, Tarih) VALUES (@Aciklama, @Tutar, @Tarih)";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@Aciklama", aciklama);
                    cmd.Parameters.AddWithValue("@Tutar", tutar);
                    cmd.Parameters.AddWithValue("@Tarih", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }

                XtraMessageBox.Show("Masraf başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListeyiYenile();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Masraf kaydedilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MasrafGirisiForm_Load(object sender, EventArgs e)
        {

        }

        private void gridControlMasraflar_Click(object sender, EventArgs e)
        {

        }
    }
}
