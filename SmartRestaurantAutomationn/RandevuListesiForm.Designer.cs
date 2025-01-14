namespace SmartRestaurantAutomationn
{
    partial class RezervasyonListesiForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridControlRezervasyonlar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ListeyiYenile = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRezervasyonlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(99, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "RANDEVU LİSTESİ";
            // 
            // gridControlRezervasyonlar
            // 
            this.gridControlRezervasyonlar.Location = new System.Drawing.Point(80, 139);
            this.gridControlRezervasyonlar.MainView = this.gridView1;
            this.gridControlRezervasyonlar.Name = "gridControlRezervasyonlar";
            this.gridControlRezervasyonlar.Size = new System.Drawing.Size(366, 400);
            this.gridControlRezervasyonlar.TabIndex = 2;
            this.gridControlRezervasyonlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlRezervasyonlar;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 700;
            // 
            // ListeyiYenile
            // 
            this.ListeyiYenile.Location = new System.Drawing.Point(197, 577);
            this.ListeyiYenile.Name = "ListeyiYenile";
            this.ListeyiYenile.Size = new System.Drawing.Size(115, 49);
            this.ListeyiYenile.TabIndex = 3;
            this.ListeyiYenile.Text = "Listeyi Yenile";
            // 
            // RezervasyonListesiForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Thistle;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 717);
            this.Controls.Add(this.ListeyiYenile);
            this.Controls.Add(this.gridControlRezervasyonlar);
            this.Controls.Add(this.label1);
            this.Name = "RezervasyonListesiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RandevuListesiForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRezervasyonlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControlRezervasyonlar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton ListeyiYenile;
    }
}