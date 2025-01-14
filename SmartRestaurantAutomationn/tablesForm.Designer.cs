namespace SmartRestaurantAutomationn
{
    partial class tablesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMasalar
            // 
            this.flowLayoutPanelMasalar.Location = new System.Drawing.Point(59, 92);
            this.flowLayoutPanelMasalar.Name = "flowLayoutPanelMasalar";
            this.flowLayoutPanelMasalar.Size = new System.Drawing.Size(1042, 473);
            this.flowLayoutPanelMasalar.TabIndex = 0;
            this.flowLayoutPanelMasalar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelMasalar_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(512, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "MASALAR";
            // 
            // tablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1183, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelMasalar);
            this.Name = "tablesForm";
            this.Text = "tablesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMasalar;
        private System.Windows.Forms.Label label1;
    }
}