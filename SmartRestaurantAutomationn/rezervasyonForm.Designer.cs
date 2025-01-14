namespace SmartRestaurantAutomationn
{
    partial class RezervasyonForm
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
            this.btnRezerveEt = new DevExpress.XtraEditors.SimpleButton();
            this.btnRezerveSil = new DevExpress.XtraEditors.SimpleButton();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.txtSelectedMasa = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanelMasalar1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timeEditRezerveSaat = new DevExpress.XtraEditors.TimeEdit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelectedMasa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditRezerveSaat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "REZERVASYON ";
            // 
            // btnRezerveEt
            // 
            this.btnRezerveEt.Location = new System.Drawing.Point(43, 444);
            this.btnRezerveEt.Name = "btnRezerveEt";
            this.btnRezerveEt.Size = new System.Drawing.Size(103, 50);
            this.btnRezerveEt.TabIndex = 4;
            this.btnRezerveEt.Text = "REZERVE ET";
            this.btnRezerveEt.Click += new System.EventHandler(this.btnRezerveEt_Click_1);
            // 
            // btnRezerveSil
            // 
            this.btnRezerveSil.Location = new System.Drawing.Point(159, 444);
            this.btnRezerveSil.Name = "btnRezerveSil";
            this.btnRezerveSil.Size = new System.Drawing.Size(103, 50);
            this.btnRezerveSil.TabIndex = 5;
            this.btnRezerveSil.Text = "REZERVE SİL";
            this.btnRezerveSil.Click += new System.EventHandler(this.btnRezerveSil_Click_1);
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(43, 276);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(202, 96);
            this.memoEdit1.TabIndex = 7;
            // 
            // txtSelectedMasa
            // 
            this.txtSelectedMasa.Location = new System.Drawing.Point(43, 155);
            this.txtSelectedMasa.Name = "txtSelectedMasa";
            this.txtSelectedMasa.Size = new System.Drawing.Size(202, 22);
            this.txtSelectedMasa.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Seçilen Masa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seçilen Saat";
            // 
            // flowLayoutPanelMasalar1
            // 
            this.flowLayoutPanelMasalar1.Location = new System.Drawing.Point(425, 90);
            this.flowLayoutPanelMasalar1.Name = "flowLayoutPanelMasalar1";
            this.flowLayoutPanelMasalar1.Size = new System.Drawing.Size(269, 404);
            this.flowLayoutPanelMasalar1.TabIndex = 12;
            // 
            // timeEditRezerveSaat
            // 
            this.timeEditRezerveSaat.EditValue = new System.DateTime(2025, 1, 7, 0, 0, 0, 0);
            this.timeEditRezerveSaat.Location = new System.Drawing.Point(43, 226);
            this.timeEditRezerveSaat.Name = "timeEditRezerveSaat";
            this.timeEditRezerveSaat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEditRezerveSaat.Size = new System.Drawing.Size(125, 24);
            this.timeEditRezerveSaat.TabIndex = 13;
            // 
            // RezervasyonForm
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 706);
            this.Controls.Add(this.timeEditRezerveSaat);
            this.Controls.Add(this.flowLayoutPanelMasalar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSelectedMasa);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.btnRezerveSil);
            this.Controls.Add(this.btnRezerveEt);
            this.Controls.Add(this.label1);
            this.Name = "RezervasyonForm";
            this.Text = "rezervasyonForm";
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelectedMasa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditRezerveSaat.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnRezerveEt;
        private DevExpress.XtraEditors.SimpleButton btnRezerveSil;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.TextEdit txtSelectedMasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMasalar1;
        private DevExpress.XtraEditors.TimeEdit timeEditRezerveSaat;
    }
}