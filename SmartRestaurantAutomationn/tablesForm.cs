// tablesForm.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartRestaurantAutomationn
{
    public partial class tablesForm : Form
    {
        public tablesForm()
        {
            InitializeComponent();
            LoadMasalar();
        }

        private void LoadMasalar()
        {
            flowLayoutPanelMasalar.Controls.Clear();

            // 20 masa butonu oluştur
            for (int i = 1; i <= 20; i++)
            {
                Button masaButton = new Button
                {
                    Text = $"Masa {i}",
                    Width = 100,
                    Height = 100,
                    Tag = i,
                    BackColor = Program.MasaSiparisler.ContainsKey(i) ? System.Drawing.Color.Red : System.Drawing.Color.Green
                };

                // Masa butonuna tıklama olayı bağlanır
                masaButton.Click += MasaButton_Click;

                // FlowLayoutPanel'e buton eklenir
                flowLayoutPanelMasalar.Controls.Add(masaButton);
            }
        }

        private void MasaButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            Program.SelectedTableId = (int)clickedButton.Tag; // Tıklanan masanın numarasını al

            salesForm salesForm = new salesForm();
            salesForm.Show();
            this.Hide();
        }

        private void flowLayoutPanelMasalar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

    // Program sınıfını güncelleyerek MasaSiparisler sözlüğünü ekliyoruz
   