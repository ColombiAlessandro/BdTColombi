
namespace ColombiBdT
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.sociButton = new System.Windows.Forms.Button();
            this.prestazioniButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sociButton
            // 
            this.sociButton.Location = new System.Drawing.Point(12, 188);
            this.sociButton.Name = "sociButton";
            this.sociButton.Size = new System.Drawing.Size(101, 38);
            this.sociButton.TabIndex = 0;
            this.sociButton.Text = "Soci ";
            this.sociButton.UseVisualStyleBackColor = true;
            this.sociButton.Click += new System.EventHandler(this.sociButton_Click);
            // 
            // prestazioniButton
            // 
            this.prestazioniButton.Location = new System.Drawing.Point(209, 188);
            this.prestazioniButton.Name = "prestazioniButton";
            this.prestazioniButton.Size = new System.Drawing.Size(101, 38);
            this.prestazioniButton.TabIndex = 1;
            this.prestazioniButton.Text = "Prestazioni";
            this.prestazioniButton.UseVisualStyleBackColor = true;
            this.prestazioniButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 450);
            this.Controls.Add(this.prestazioniButton);
            this.Controls.Add(this.sociButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sociButton;
        private System.Windows.Forms.Button prestazioniButton;
    }
}

