namespace SmartRestaurantAutomationn
{
    partial class anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.anaSayfaBaslik = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.odemeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.rezervsynListBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cikisBtn = new DevExpress.XtraEditors.SimpleButton();
            this.raporlarBtn = new DevExpress.XtraEditors.SimpleButton();
            this.rezervasyonBtn = new DevExpress.XtraEditors.SimpleButton();
            this.masalarBtn = new DevExpress.XtraEditors.SimpleButton();
            this.masrafGrsiBtn = new DevExpress.XtraEditors.SimpleButton();
            this.satisBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // anaSayfaBaslik
            // 
            this.anaSayfaBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anaSayfaBaslik.Appearance.Options.UseFont = true;
            this.anaSayfaBaslik.AutoEllipsis = true;
            this.anaSayfaBaslik.Location = new System.Drawing.Point(418, 19);
            this.anaSayfaBaslik.Margin = new System.Windows.Forms.Padding(5);
            this.anaSayfaBaslik.Name = "anaSayfaBaslik";
            this.anaSayfaBaslik.Size = new System.Drawing.Size(425, 28);
            this.anaSayfaBaslik.TabIndex = 0;
            this.anaSayfaBaslik.Text = "SMART RESTAURANT AUTOMATION ";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.odemeBtn);
            this.panelControl1.Controls.Add(this.rezervsynListBtn);
            this.panelControl1.Controls.Add(this.cikisBtn);
            this.panelControl1.Controls.Add(this.raporlarBtn);
            this.panelControl1.Controls.Add(this.rezervasyonBtn);
            this.panelControl1.Controls.Add(this.masalarBtn);
            this.panelControl1.Controls.Add(this.masrafGrsiBtn);
            this.panelControl1.Controls.Add(this.satisBtn);
            this.panelControl1.Location = new System.Drawing.Point(-67, -29);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(2015, 1004);
            this.panelControl1.TabIndex = 1;
            // 
            // odemeBtn
            // 
            this.odemeBtn.Appearance.BackColor = System.Drawing.Color.SlateBlue;
            this.odemeBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odemeBtn.Appearance.Options.UseBackColor = true;
            this.odemeBtn.Appearance.Options.UseFont = true;
            this.odemeBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("odemeBtn.ImageOptions.SvgImage")));
            this.odemeBtn.Location = new System.Drawing.Point(913, 492);
            this.odemeBtn.Margin = new System.Windows.Forms.Padding(5);
            this.odemeBtn.Name = "odemeBtn";
            this.odemeBtn.Size = new System.Drawing.Size(320, 149);
            this.odemeBtn.TabIndex = 7;
            this.odemeBtn.Text = "Ödeme";
            this.odemeBtn.Click += new System.EventHandler(this.odemeBtn_Click);
            // 
            // rezervsynListBtn
            // 
            this.rezervsynListBtn.Appearance.BackColor = System.Drawing.Color.DarkCyan;
            this.rezervsynListBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rezervsynListBtn.Appearance.Options.UseBackColor = true;
            this.rezervsynListBtn.Appearance.Options.UseFont = true;
            this.rezervsynListBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("rezervsynListBtn.ImageOptions.SvgImage")));
            this.rezervsynListBtn.Location = new System.Drawing.Point(578, 492);
            this.rezervsynListBtn.Margin = new System.Windows.Forms.Padding(5);
            this.rezervsynListBtn.Name = "rezervsynListBtn";
            this.rezervsynListBtn.Size = new System.Drawing.Size(325, 149);
            this.rezervsynListBtn.TabIndex = 6;
            this.rezervsynListBtn.Text = "Rezervasyon listesi";
            this.rezervsynListBtn.Click += new System.EventHandler(this.rezervsynListBtn_Click);
            // 
            // cikisBtn
            // 
            this.cikisBtn.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.cikisBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisBtn.Appearance.Options.UseBackColor = true;
            this.cikisBtn.Appearance.Options.UseFont = true;
            this.cikisBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cikisBtn.ImageOptions.SvgImage")));
            this.cikisBtn.Location = new System.Drawing.Point(1243, 60);
            this.cikisBtn.Margin = new System.Windows.Forms.Padding(5);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(194, 238);
            this.cikisBtn.TabIndex = 5;
            this.cikisBtn.Text = "Çıkış";
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // raporlarBtn
            // 
            this.raporlarBtn.Appearance.BackColor = System.Drawing.Color.Red;
            this.raporlarBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.raporlarBtn.Appearance.Options.UseBackColor = true;
            this.raporlarBtn.Appearance.Options.UseFont = true;
            this.raporlarBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("raporlarBtn.ImageOptions.SvgImage")));
            this.raporlarBtn.Location = new System.Drawing.Point(987, 308);
            this.raporlarBtn.Margin = new System.Windows.Forms.Padding(5);
            this.raporlarBtn.Name = "raporlarBtn";
            this.raporlarBtn.Size = new System.Drawing.Size(246, 174);
            this.raporlarBtn.TabIndex = 4;
            this.raporlarBtn.Text = "Raporlar";
            this.raporlarBtn.Click += new System.EventHandler(this.raporlarBtn_Click);
            // 
            // rezervasyonBtn
            // 
            this.rezervasyonBtn.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.rezervasyonBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rezervasyonBtn.Appearance.Options.UseBackColor = true;
            this.rezervasyonBtn.Appearance.Options.UseFont = true;
            this.rezervasyonBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("rezervasyonBtn.ImageOptions.SvgImage")));
            this.rezervasyonBtn.Location = new System.Drawing.Point(578, 308);
            this.rezervasyonBtn.Margin = new System.Windows.Forms.Padding(5);
            this.rezervasyonBtn.Name = "rezervasyonBtn";
            this.rezervasyonBtn.Size = new System.Drawing.Size(399, 174);
            this.rezervasyonBtn.TabIndex = 3;
            this.rezervasyonBtn.Text = "Rezervasyon";
            this.rezervasyonBtn.Click += new System.EventHandler(this.rezervasyonBtn_Click);
            // 
            // masalarBtn
            // 
            this.masalarBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.masalarBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masalarBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.masalarBtn.Appearance.Options.UseBackColor = true;
            this.masalarBtn.Appearance.Options.UseFont = true;
            this.masalarBtn.Appearance.Options.UseForeColor = true;
            this.masalarBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("masalarBtn.ImageOptions.SvgImage")));
            this.masalarBtn.Location = new System.Drawing.Point(578, 60);
            this.masalarBtn.Margin = new System.Windows.Forms.Padding(5);
            this.masalarBtn.Name = "masalarBtn";
            this.masalarBtn.Size = new System.Drawing.Size(655, 238);
            this.masalarBtn.TabIndex = 2;
            this.masalarBtn.Text = "Masalar";
            this.masalarBtn.Click += new System.EventHandler(this.masalarBtn_Click);
            // 
            // masrafGrsiBtn
            // 
            this.masrafGrsiBtn.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.masrafGrsiBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masrafGrsiBtn.Appearance.Options.UseBackColor = true;
            this.masrafGrsiBtn.Appearance.Options.UseFont = true;
            this.masrafGrsiBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("masrafGrsiBtn.ImageOptions.SvgImage")));
            this.masrafGrsiBtn.Location = new System.Drawing.Point(81, 492);
            this.masrafGrsiBtn.Margin = new System.Windows.Forms.Padding(5);
            this.masrafGrsiBtn.Name = "masrafGrsiBtn";
            this.masrafGrsiBtn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.masrafGrsiBtn.Size = new System.Drawing.Size(487, 149);
            this.masrafGrsiBtn.TabIndex = 1;
            this.masrafGrsiBtn.Text = "Masraf Girişi";
            this.masrafGrsiBtn.Click += new System.EventHandler(this.masrafGrsiBtn_Click);
            // 
            // satisBtn
            // 
            this.satisBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.satisBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisBtn.Appearance.Options.UseBackColor = true;
            this.satisBtn.Appearance.Options.UseFont = true;
            this.satisBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.satisBtn.AppearanceHovered.Options.UseBackColor = true;
            this.satisBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("satisBtn.ImageOptions.SvgImage")));
            this.satisBtn.Location = new System.Drawing.Point(81, 60);
            this.satisBtn.Margin = new System.Windows.Forms.Padding(5);
            this.satisBtn.Name = "satisBtn";
            this.satisBtn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.satisBtn.Size = new System.Drawing.Size(487, 422);
            this.satisBtn.TabIndex = 0;
            this.satisBtn.Text = "Satış";
            this.satisBtn.Click += new System.EventHandler(this.satisBtn_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 693);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.anaSayfaBaslik);
            this.Name = "anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl anaSayfaBaslik;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton satisBtn;
        private DevExpress.XtraEditors.SimpleButton raporlarBtn;
        private DevExpress.XtraEditors.SimpleButton rezervasyonBtn;
        private DevExpress.XtraEditors.SimpleButton masalarBtn;
        private DevExpress.XtraEditors.SimpleButton masrafGrsiBtn;
        private DevExpress.XtraEditors.SimpleButton odemeBtn;
        private DevExpress.XtraEditors.SimpleButton rezervsynListBtn;
        private DevExpress.XtraEditors.SimpleButton cikisBtn;
    }
}

