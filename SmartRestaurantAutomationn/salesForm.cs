using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SmartRestaurantAutomationn
{
    public partial class salesForm : Form
    {
        private Button btnKaydet;
        private Button btnOdeme;

        // Hızlı satış ürünleri
        private Dictionary<string, decimal> hizliSatisUrunleri = new Dictionary<string, decimal>
        {
            { "Kola", 15 }, { "Çay", 10 }, { "Hamburger", 50 }, { "Pizza", 60 },
            { "Kahve", 25 }, { "Su", 5 }, { "Kurabiye", 20 }, { "Türk Kahvesi", 30 },
            { "Bazlama Tost", 35 }, { "Latte", 40 }, { "Mercimek çorba", 20 }
        };

        // Yemek ürünleri
        private Dictionary<string, decimal> yemekUrunleri = new Dictionary<string, decimal>
        {
            { "Mercimek Çorbası", 100 }, { "Domates Çorbası", 100 }, { "Salata", 150 },
            { "Kebap", 250 }, { "Köfte Kızartma", 250 }, { "Pizza", 200 },
            { "İskender", 250 }, { "Pilav", 150 }, { "Mantı", 200 },
            { "Makarna", 175 }, { "Hamburger", 175 }, { "Lahmacun", 200 },
            { "Pide", 200 }, { "Tavuk", 175 },{"Su Böreği",100}
        };

        // Tatlı ürünleri
        private Dictionary<string, decimal> tatliUrunleri = new Dictionary<string, decimal>
        {
            { "Cheesecake", 170 }, { "Baklava", 250 }, { "Sütlaç", 170 },
            { "Waffle", 170 }, { "Tiramisu", 170 }, { "Profiterol", 170 },
            { "kar Topu", 170 }, { "Muhallebi", 170 }, { "Kruvasan", 200 },
            { "San Sebastian", 170 }, { "Künefe", 200 }, { "Meyve Tabağı", 150 },
             { "Latte Pasta", 170 }, { "Çikolata topu", 150 }, { "Fıstık Rüyası", 170 }

        };

        // İçecek ürünleri
        private Dictionary<string, decimal> icecekUrunleri = new Dictionary<string, decimal>
        {
            { "Kış Çayı", 45 }, { "Çay", 30 }, { "Limonata", 60 },
            { "Sıcak Çikolata", 100 }, { "Ice Latte", 100 }, { "Macchiato", 100 },
            { "Ice Americano", 100 }, { "Milkshake", 100 }, { "Filtre Kahve", 100 },
            { "Portakal Suyu", 70 }, { "Mojito", 110 }, { "Türk Kahvesi", 75 },
             { "Antep Fıstıklı Latte", 110 }, { "Hibiscus", 110 }, { "Ayran", 60 }

        };

        private decimal toplamTutar = 0;

        public salesForm()
        {
            InitializeComponent();
        }

        private void salesForm_Load(object sender, EventArgs e)
        {
            // Masa bilgisi kontrolü
            if (Program.SelectedTableId == 0) // Masa seçilmemiş
            {
                lblMasa.Visible = false; // Masa bilgisi gizlenir

                // Ödeme butonunu toplamın üstüne ekle
                if (btnOdeme == null)
                {
                    btnOdeme = new Button
                    {
                        Text = "Ödeme",
                        Width = 120,
                        Height = 40,
                        Location = new System.Drawing.Point(lblTotal.Location.X, lblTotal.Location.Y - 50), // Toplamın üstünde
                        BackColor = System.Drawing.Color.LightBlue,
                        Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
                    };
                    btnOdeme.Click += BtnOdeme_Click; // Tıklama olayını bağla
                    this.Controls.Add(btnOdeme); // Form'a butonu ekle
                }
            }
            else // Masa seçilmiş
            {
                lblMasa.Text = $"Masa {Program.SelectedTableId}";
                lblMasa.Visible = true; // Masa bilgisi gösterilir

                // Dinamik olarak "Kaydet" butonunu oluştur
                if (btnKaydet == null)
                {
                    btnKaydet = new Button
                    {
                        Text = "Kaydet",
                        Width = 120,
                        Height = 40,
                        Location = new System.Drawing.Point(sepetlistBox.Location.X, sepetlistBox.Location.Y + sepetlistBox.Height + 10),
                        BackColor = System.Drawing.Color.LightGreen,
                        Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
                    };
                    btnKaydet.Click += DinamikBtnKaydet_Click; // Tıklama olayını bağla
                    this.Controls.Add(btnKaydet); // Form'a butonu ekle
                }

                // Dinamik olarak "Ödeme" butonunu oluştur
                if (btnOdeme == null)
                {
                    btnOdeme = new Button
                    {
                        Text = "Ödeme",
                        Width = 120,
                        Height = 40,
                        Location = new System.Drawing.Point(btnKaydet.Location.X + btnKaydet.Width + 10, btnKaydet.Location.Y),
                        BackColor = System.Drawing.Color.LightBlue,
                        Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
                    };
                    btnOdeme.Click += BtnOdeme_Click; // Tıklama olayını bağla
                    this.Controls.Add(btnOdeme); // Form'a butonu ekle
                }
                else
                {
                    btnOdeme.Text = "Ödeme"; // Her durumda butonun metni "Ödeme" olarak ayarlanır
                }
            }

            // Varsayılan olarak hızlı satış ürünlerini yükle
            LoadHizliSatis();
        }

        private void BtnOdeme_Click(object sender, EventArgs e)
        {
            // Ödeme ekranını aç
            odemeForm odeme = new odemeForm();

            // Sepetteki ürünleri ödeme ekranına aktar
            foreach (var item in sepetlistBox.Items)
            {
                odeme.AddToListBox(item.ToString()); // AddToListBox metodu ödeme formunda tanımlanmalı
            }

            // Toplam tutarı ödeme ekranına aktar
            odeme.SetTotalAmount(lblTotal.Text);

            odeme.Show(); // Ödeme formunu göster
            this.Hide(); // Satış formunu gizle
        }

        private void LoadHizliSatis()
        {
            LoadProducts(hizliSatisUrunleri);
        }

        private void LoadYemekler()
        {
            LoadProducts(yemekUrunleri);
        }

        private void LoadTatli()
        {
            LoadProducts(tatliUrunleri);
        }

        private void LoadIcecekler()
        {
            LoadProducts(icecekUrunleri);
        }

        private void LoadProducts(Dictionary<string, decimal> products)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var urun in products)
            {
                Button btn = new Button
                {
                    Text = $"{urun.Key}\n{urun.Value} TL",
                    Width = 120,
                    Height = 100
                };
                btn.Click += (s, e) => AddToCart(urun.Key, urun.Value);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void AddToCart(string urun, decimal fiyat)
        {
            sepetlistBox.Items.Add($"{urun} - {fiyat} TL");
            toplamTutar += fiyat;
            lblTotal.Text = $"Toplam: {toplamTutar} TL";
        }

        private void DinamikBtnKaydet_Click(object sender, EventArgs e)
        {
            if (Program.SelectedTableId == 0)
            {
                MessageBox.Show("Lütfen önce bir masa seçin!");
                return;
            }

            DatabaseConnector db = new DatabaseConnector();

            try
            {
                string insertOrderQuery = "INSERT INTO orders (MasaNo, TotalAmount, OrderDate) VALUES (@MasaNo, @TotalAmount, @OrderDate);";
                MySqlCommand cmdOrder = new MySqlCommand(insertOrderQuery, db.Connection);
                cmdOrder.Parameters.AddWithValue("@MasaNo", Program.SelectedTableId);
                cmdOrder.Parameters.AddWithValue("@TotalAmount", toplamTutar);
                cmdOrder.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                cmdOrder.ExecuteNonQuery();

                long orderId = cmdOrder.LastInsertedId;

                string insertDetailQuery = "INSERT INTO orderdetails (OrderID, UrunAdi, Adet, Fiyat) VALUES (@OrderID, @UrunAdi, @Adet, @Fiyat);";
                foreach (var item in sepetlistBox.Items)
                {
                    string[] urunBilgisi = item.ToString().Split('-');
                    string urunAdi = urunBilgisi[0].Trim();
                    decimal urunFiyat = decimal.Parse(urunBilgisi[1].Replace("TL", "").Trim());

                    MySqlCommand cmdDetail = new MySqlCommand(insertDetailQuery, db.Connection);
                    cmdDetail.Parameters.AddWithValue("@OrderID", orderId);
                    cmdDetail.Parameters.AddWithValue("@UrunAdi", urunAdi);
                    cmdDetail.Parameters.AddWithValue("@Adet", 1);
                    cmdDetail.Parameters.AddWithValue("@Fiyat", urunFiyat);
                    cmdDetail.ExecuteNonQuery();
                }

                MessageBox.Show($"Masa {Program.SelectedTableId} siparişleri başarıyla kaydedildi!");

                sepetlistBox.Items.Clear();
                toplamTutar = 0;
                lblTotal.Text = "Toplam: 0 TL";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sipariş kaydedilirken bir hata oluştu: {ex.Message}");
            }
            finally
            {
                db.Connection.Close();
            }
        }

        private void hizliSatisTileItem_ItemClick(object sender, EventArgs e)
        {
            LoadHizliSatis();
        }

        private void yemekTileItem_ItemClick(object sender, EventArgs e)
        {
            LoadYemekler();
        }

        private void tatliTileItem_ItemClick(object sender, EventArgs e)
        {
            LoadTatli();
        }

        private void icecekTileItem_ItemClick(object sender, EventArgs e)
        {
            LoadIcecekler();
        }

        private void sepetlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void anasayfaTileItem_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            // Ana sayfa formunu aç
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();

            // Bu formu gizle (isteğe bağlı)
            this.Hide();
        }

        private void sepetlistBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void sepetlistBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                // Yazı tipi ve boyutunu ayarla
                Font font = new Font("Arial", 12, FontStyle.Bold);
                e.Graphics.DrawString(sepetlistBox.Items[e.Index].ToString(), font, Brushes.Black, e.Bounds);
            }
            e.DrawFocusRectangle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (sepetlistBox.SelectedIndex != -1) // Eğer bir ürün seçiliyse
            {
                sepetlistBox.Items.RemoveAt(sepetlistBox.SelectedIndex); // Seçilen ürünü kaldır
                UpdateTotalAmount(); // Toplam tutarı güncelle
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz ürünü seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Toplam tutarı güncellemek için bir fonksiyon
        private void UpdateTotalAmount()
        {
            decimal toplamTutar = 0;

            foreach (var item in sepetlistBox.Items)
            {
                string[] urunBilgisi = item.ToString().Split('-');
                decimal fiyat = decimal.Parse(urunBilgisi[1].Replace("TL", "").Trim());
                toplamTutar += fiyat;
            }

            lblTotal.Text = $"Toplam: {toplamTutar} TL";
        }
    }
}
