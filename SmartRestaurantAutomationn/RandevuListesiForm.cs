using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;

namespace SmartRestaurantAutomationn
{
    public partial class RezervasyonListesiForm : XtraForm
    {
        private DatabaseConnector db;

        public RezervasyonListesiForm()
        {
            InitializeComponent();
            db = new DatabaseConnector();
            LoadRezervasyonlar();
        }

        // Rezervasyonları GridControl'e yükler
        private void LoadRezervasyonlar()
        {
            string query = "SELECT MasaNo, RezervasyonSaati, Notlar FROM Rezervasyonlar";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        gridControlRezervasyonlar.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Rezervasyonlar yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Listeyi yenile butonu
        private void btnListeYenile_Click(object sender, EventArgs e)
        {
            LoadRezervasyonlar();
        }
    }
}
