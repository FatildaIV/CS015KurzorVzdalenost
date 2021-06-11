namespace CS015KurzorVzdalenost
{
    partial class VzdalenostForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.vzdalenostLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vzdalenostLabel
            // 
            this.vzdalenostLabel.AutoSize = true;
            this.vzdalenostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vzdalenostLabel.Location = new System.Drawing.Point(12, 9);
            this.vzdalenostLabel.Name = "vzdalenostLabel";
            this.vzdalenostLabel.Size = new System.Drawing.Size(144, 26);
            this.vzdalenostLabel.TabIndex = 0;
            this.vzdalenostLabel.Text = "Vzdálenost: ?";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 415);
            this.progressBar.Maximum = 10000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(775, 23);
            this.progressBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(208, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Challenge: Ujeď s kurzorem 10 000 cm.";
            // 
            // VzdalenostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.vzdalenostLabel);
            this.Name = "VzdalenostForm";
            this.Text = "CS015KurzorVzdalenost (Karel Hofman)";
            this.MouseEnter += new System.EventHandler(this.VzdalenostForm_MouseEnter);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VzdalenostForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vzdalenostLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
    }
}

