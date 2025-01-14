namespace SmartRestaurantAutomationn
{
    partial class salesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.hzlıSatisTileItem = new DevExpress.XtraEditors.TileItem();
            this.yemekTileItem = new DevExpress.XtraEditors.TileItem();
            this.tatlıTileItem = new DevExpress.XtraEditors.TileItem();
            this.icecekTileItem = new DevExpress.XtraEditors.TileItem();
            this.anasayfaTileItem = new DevExpress.XtraEditors.TileItem();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sepetlistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMasa = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.Groups.Add(this.tileGroup3);
            this.tileControl1.ItemCheckMode = DevExpress.XtraEditors.TileItemCheckMode.Multiple;
            this.tileControl1.Location = new System.Drawing.Point(34, 44);
            this.tileControl1.MaxId = 21;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(870, 113);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.hzlıSatisTileItem);
            this.tileGroup3.Items.Add(this.yemekTileItem);
            this.tileGroup3.Items.Add(this.tatlıTileItem);
            this.tileGroup3.Items.Add(this.icecekTileItem);
            this.tileGroup3.Items.Add(this.anasayfaTileItem);
            this.tileGroup3.Name = "tileGroup3";
            // 
            // hzlıSatisTileItem
            // 
            tileItemElement1.Text = "HIZLI  SATIŞ";
            this.hzlıSatisTileItem.Elements.Add(tileItemElement1);
            this.hzlıSatisTileItem.Id = 16;
            this.hzlıSatisTileItem.ItemSize = DevExpress.XtraEditors.TileItemSize.Large;
            this.hzlıSatisTileItem.Name = "hzlıSatisTileItem";
            this.hzlıSatisTileItem.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.hzlıSatisTileItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.hizliSatisTileItem_ItemClick);
            // 
            // yemekTileItem
            // 
            tileItemElement2.Text = "YEMEKLER";
            this.yemekTileItem.Elements.Add(tileItemElement2);
            this.yemekTileItem.Id = 17;
            this.yemekTileItem.ItemSize = DevExpress.XtraEditors.TileItemSize.Large;
            this.yemekTileItem.Name = "yemekTileItem";
            this.yemekTileItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.yemekTileItem_ItemClick);
            // 
            // tatlıTileItem
            // 
            tileItemElement3.Text = "TATLI / PASTA";
            this.tatlıTileItem.Elements.Add(tileItemElement3);
            this.tatlıTileItem.Id = 18;
            this.tatlıTileItem.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tatlıTileItem.Name = "tatlıTileItem";
            this.tatlıTileItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tatliTileItem_ItemClick);
            // 
            // icecekTileItem
            // 
            tileItemElement4.Text = "İÇECEKLER";
            this.icecekTileItem.Elements.Add(tileItemElement4);
            this.icecekTileItem.Id = 19;
            this.icecekTileItem.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.icecekTileItem.Name = "icecekTileItem";
            this.icecekTileItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.icecekTileItem_ItemClick);
            // 
            // anasayfaTileItem
            // 
            tileItemElement5.Text = "ANASAYFA";
            this.anasayfaTileItem.Elements.Add(tileItemElement5);
            this.anasayfaTileItem.Id = 20;
            this.anasayfaTileItem.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.anasayfaTileItem.Name = "anasayfaTileItem";
            this.anasayfaTileItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.anasayfaTileItem_ItemClick);
            // 
            // tileGroup1
            // 
            this.tileGroup1.Name = "tileGroup1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(34, 174);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(870, 481);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // sepetlistBox
            // 
            this.sepetlistBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sepetlistBox.FormattingEnabled = true;
            this.sepetlistBox.ItemHeight = 16;
            this.sepetlistBox.Location = new System.Drawing.Point(929, 170);
            this.sepetlistBox.Name = "sepetlistBox";
            this.sepetlistBox.Size = new System.Drawing.Size(326, 372);
            this.sepetlistBox.TabIndex = 2;
            this.sepetlistBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.sepetlistBox_DrawItem);
            this.sepetlistBox.SelectedIndexChanged += new System.EventHandler(this.sepetlistBox_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1033, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "SEPET";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Name = "tileGroup2";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal.Location = new System.Drawing.Point(931, 636);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(230, 38);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Toplam : 0 TL";
            // 
            // lblMasa
            // 
            this.lblMasa.AutoSize = true;
            this.lblMasa.Location = new System.Drawing.Point(935, 129);
            this.lblMasa.Name = "lblMasa";
            this.lblMasa.Size = new System.Drawing.Size(0, 16);
            this.lblMasa.TabIndex = 5;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1170, 129);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 35);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // salesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1283, 706);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblMasa);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sepetlistBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tileControl1);
            this.Name = "salesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "salesForm";
            this.Load += new System.EventHandler(this.salesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox sepetlistBox;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem hzlıSatisTileItem;
        private DevExpress.XtraEditors.TileItem yemekTileItem;
        private DevExpress.XtraEditors.TileItem tatlıTileItem;
        private DevExpress.XtraEditors.TileItem icecekTileItem;
        private System.Windows.Forms.Label lblTotal;
        private DevExpress.XtraEditors.TileItem anasayfaTileItem;
        private System.Windows.Forms.Label lblMasa;
        private System.Windows.Forms.Button btnSil;
    }
}
