namespace SmartRestaurantAutomationn
{
    partial class odemeForm
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
            this.flowLayoutPanelMasalar = new System.Windows.Forms.FlowLayoutPanel();
            this.listBoxSiparisler = new System.Windows.Forms.ListBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.comboBoxOdemeSecenek = new System.Windows.Forms.ComboBox();
            this.simpleBtnAnasayfa = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButtonTamamla = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMasalar
            // 
            this.flowLayoutPanelMasalar.Location = new System.Drawing.Point(48, 72);
            this.flowLayoutPanelMasalar.Name = "flowLayoutPanelMasalar";
            this.flowLayoutPanelMasalar.Size = new System.Drawing.Size(275, 557);
            this.flowLayoutPanelMasalar.TabIndex = 0;
            // 
            // listBoxSiparisler
            // 
            this.listBoxSiparisler.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxSiparisler.FormattingEnabled = true;
            this.listBoxSiparisler.ItemHeight = 16;
            this.listBoxSiparisler.Location = new System.Drawing.Point(372, 119);
            this.listBoxSiparisler.Name = "listBoxSiparisler";
            this.listBoxSiparisler.Size = new System.Drawing.Size(476, 228);
            this.listBoxSiparisler.TabIndex = 1;
            this.listBoxSiparisler.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxSiparisler_DrawItem);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTotal.Location = new System.Drawing.Point(464, 365);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(154, 22);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "Ödenecek Tutar";
            // 
            // comboBoxOdemeSecenek
            // 
            this.comboBoxOdemeSecenek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOdemeSecenek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxOdemeSecenek.FormattingEnabled = true;
            this.comboBoxOdemeSecenek.Location = new System.Drawing.Point(468, 458);
            this.comboBoxOdemeSecenek.Name = "comboBoxOdemeSecenek";
            this.comboBoxOdemeSecenek.Size = new System.Drawing.Size(180, 30);
            this.comboBoxOdemeSecenek.TabIndex = 3;
            // 
            // simpleBtnAnasayfa
            // 
            this.simpleBtnAnasayfa.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleBtnAnasayfa.Appearance.Options.UseFont = true;
            this.simpleBtnAnasayfa.Location = new System.Drawing.Point(983, 62);
            this.simpleBtnAnasayfa.Margin = new System.Windows.Forms.Padding(4);
            this.simpleBtnAnasayfa.Name = "simpleBtnAnasayfa";
            this.simpleBtnAnasayfa.Size = new System.Drawing.Size(125, 99);
            this.simpleBtnAnasayfa.TabIndex = 7;
            this.simpleBtnAnasayfa.Text = "Anasayfa";
            this.simpleBtnAnasayfa.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(437, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "ÖDEME SAYFASI";
            // 
            // simpleButtonTamamla
            // 
            this.simpleButtonTamamla.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButtonTamamla.Appearance.Options.UseFont = true;
            this.simpleButtonTamamla.Location = new System.Drawing.Point(468, 533);
            this.simpleButtonTamamla.Name = "simpleButtonTamamla";
            this.simpleButtonTamamla.Size = new System.Drawing.Size(194, 53);
            this.simpleButtonTamamla.TabIndex = 9;
            this.simpleButtonTamamla.Text = "Ödemeyi Tamamla";
            this.simpleButtonTamamla.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(464, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ödeme Yöntemi Seçin: ";
            // 
            // odemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1142, 641);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.simpleButtonTamamla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleBtnAnasayfa);
            this.Controls.Add(this.comboBoxOdemeSecenek);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.listBoxSiparisler);
            this.Controls.Add(this.flowLayoutPanelMasalar);
            this.Name = "odemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "odemeForm";
            this.Load += new System.EventHandler(this.odemeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMasalar;
        public System.Windows.Forms.ListBox listBoxSiparisler;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ComboBox comboBoxOdemeSecenek;
        private DevExpress.XtraEditors.SimpleButton simpleBtnAnasayfa;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonTamamla;
        private System.Windows.Forms.Label label2;
    }
}