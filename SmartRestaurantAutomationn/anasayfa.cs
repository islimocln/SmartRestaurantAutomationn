using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartRestaurantAutomationn
{
    public partial class anasayfa : Form
    {
        salesForm sales = new salesForm();
        public anasayfa()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void masrafGrsiBtn_Click(object sender, EventArgs e)
        {
            MasrafGirisiForm masrafGirisiForm = new MasrafGirisiForm();
            masrafGirisiForm.Show();
            this.Hide(); // Ana sayfayı gizle
        }

        private void satisBtn_Click(object sender, EventArgs e)
        {
            // Parametresiz salesForm açılıyor

            sales.Show();
            this.Hide();
        }

        private void masalarBtn_Click(object sender, EventArgs e)
        {
            // tablesForm açılıyor
            tablesForm tablesForm = new tablesForm();
            tablesForm.Show();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Uygulamayı tamamen kapat
                Application.Exit();
            }
        }

        private void odemeBtn_Click(object sender, EventArgs e)
        {

            // Yeni bir ödeme formu oluştur
            odemeForm odeme = new odemeForm();
            odeme.Show(); // Ödeme formunu aç
            this.Hide(); // Ana sayfayı gizle
        }

        private void rezervasyonBtn_Click(object sender, EventArgs e)
        {
            RezervasyonForm rezervasyonForm = new RezervasyonForm();
            rezervasyonForm.Show();
        }

        private void rezervsynListBtn_Click(object sender, EventArgs e)
        {
            RezervasyonListesiForm rezervasyonListesiForm = new RezervasyonListesiForm();
            rezervasyonListesiForm.ShowDialog(); // Modal olarak açılır, kullanıcı bu formu kapatana kadar diğer formlara geçemez
        }

        private void raporlarBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog(); // Modal olarak açılır, şifre kontrolü yapılmadan devam edilemez
                                    // Rapor formunu oluştur ve göster
          
           
        }
    }
   }


