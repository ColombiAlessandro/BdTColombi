namespace ColombiBdT
{
    partial class PrestazioniView
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.aggiungiButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.servizioBox = new System.Windows.Forms.TextBox();
            this.destinatarioBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oreBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataBox = new System.Windows.Forms.MonthCalendar();
            this.fornitoreBox = new System.Windows.Forms.ComboBox();
            this.zonaBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oreBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(641, 375);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // aggiungiButton
            // 
            this.aggiungiButton.Location = new System.Drawing.Point(665, 250);
            this.aggiungiButton.Name = "aggiungiButton";
            this.aggiungiButton.Size = new System.Drawing.Size(227, 43);
            this.aggiungiButton.TabIndex = 1;
            this.aggiungiButton.Text = "Aggiungi";
            this.aggiungiButton.UseVisualStyleBackColor = true;
            this.aggiungiButton.Click += new System.EventHandler(this.aggiungiButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo di servizio";
            // 
            // servizioBox
            // 
            this.servizioBox.Location = new System.Drawing.Point(12, 36);
            this.servizioBox.Name = "servizioBox";
            this.servizioBox.Size = new System.Drawing.Size(149, 20);
            this.servizioBox.TabIndex = 3;
            // 
            // destinatarioBox
            // 
            this.destinatarioBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinatarioBox.FormattingEnabled = true;
            this.destinatarioBox.Location = new System.Drawing.Point(385, 36);
            this.destinatarioBox.Name = "destinatarioBox";
            this.destinatarioBox.Size = new System.Drawing.Size(146, 21);
            this.destinatarioBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destinatario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fornitore";
            // 
            // oreBox
            // 
            this.oreBox.DecimalPlaces = 1;
            this.oreBox.Location = new System.Drawing.Point(560, 37);
            this.oreBox.Name = "oreBox";
            this.oreBox.Size = new System.Drawing.Size(93, 20);
            this.oreBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Numero ore";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(770, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data";
            // 
            // dataBox
            // 
            this.dataBox.Location = new System.Drawing.Point(665, 37);
            this.dataBox.MaxSelectionCount = 1;
            this.dataBox.Name = "dataBox";
            this.dataBox.TabIndex = 11;
            // 
            // fornitoreBox
            // 
            this.fornitoreBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fornitoreBox.FormattingEnabled = true;
            this.fornitoreBox.Location = new System.Drawing.Point(212, 35);
            this.fornitoreBox.Name = "fornitoreBox";
            this.fornitoreBox.Size = new System.Drawing.Size(144, 21);
            this.fornitoreBox.TabIndex = 12;
            this.fornitoreBox.SelectedIndexChanged += new System.EventHandler(this.fornitoreBox_SelectedIndexChanged);
            // 
            // zonaBox
            // 
            this.zonaBox.Location = new System.Drawing.Point(665, 224);
            this.zonaBox.Name = "zonaBox";
            this.zonaBox.Size = new System.Drawing.Size(227, 20);
            this.zonaBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(770, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Zona";
            // 
            // PrestazioniView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 556);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zonaBox);
            this.Controls.Add(this.fornitoreBox);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oreBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.destinatarioBox);
            this.Controls.Add(this.servizioBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aggiungiButton);
            this.Controls.Add(this.listView1);
            this.Name = "PrestazioniView";
            this.Text = "PrestazioniView";
            this.Load += new System.EventHandler(this.PrestazioniView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oreBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button aggiungiButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox servizioBox;
        private System.Windows.Forms.ComboBox destinatarioBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown oreBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar dataBox;
        internal System.Windows.Forms.ComboBox fornitoreBox;
        private System.Windows.Forms.TextBox zonaBox;
        private System.Windows.Forms.Label label6;
    }
}