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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void simpleButtonGiris_Click(object sender, EventArgs e)
        {
            string girilenSifre = txtPassword.Text;
            string dogruSifre = "1234"; // Doğru şifre burada tanımlanır. İsterseniz veritabanından alabilirsiniz.

            if (girilenSifre == dogruSifre)
            {
                MessageBox.Show("Giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                // Ana sayfayı bul ve kapat
                

                // Raporlar formunu aç
                RaporForm raporlarForm = new RaporForm();
                raporlarForm.Show();

                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı şifre! Tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
    }
}
