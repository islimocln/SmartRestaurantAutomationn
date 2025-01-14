namespace SmartRestaurantAutomationn
{
    partial class RaporForm
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
            this.btnGunSonuRaporu = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlRapor = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRapor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(291, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "RAPOR";
            // 
            // btnGunSonuRaporu
            // 
            this.btnGunSonuRaporu.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGunSonuRaporu.Appearance.Options.UseFont = true;
            this.btnGunSonuRaporu.Location = new System.Drawing.Point(252, 88);
            this.btnGunSonuRaporu.Name = "btnGunSonuRaporu";
            this.btnGunSonuRaporu.Size = new System.Drawing.Size(202, 41);
            this.btnGunSonuRaporu.TabIndex = 1;
            this.btnGunSonuRaporu.Text = "Gün Sonu Raporu Oluştur";
            this.btnGunSonuRaporu.Click += new System.EventHandler(this.btnGunSonuRaporu_Click);
            // 
            // gridControlRapor
            // 
            this.gridControlRapor.Location = new System.Drawing.Point(56, 167);
            this.gridControlRapor.MainView = this.gridView1;
            this.gridControlRapor.Name = "gridControlRapor";
            this.gridControlRapor.Size = new System.Drawing.Size(600, 333);
            this.gridControlRapor.TabIndex = 2;
            this.gridControlRapor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlRapor;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 700;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(667, 35);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 51);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Anasayfa";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // RaporForm
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 553);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControlRapor);
            this.Controls.Add(this.btnGunSonuRaporu);
            this.Controls.Add(this.label1);
            this.Name = "RaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaporForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRapor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnGunSonuRaporu;
        private DevExpress.XtraGrid.GridControl gridControlRapor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}