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
            this.indietroButton = new System.Windows.Forms.Button();
            this.sociButton = new System.Windows.Forms.Button();
            this.modificaFornitore = new System.Windows.Forms.ComboBox();
            this.modificaDestinatario = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.modificaServizio = new System.Windows.Forms.TextBox();
            this.modificaOre = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.modificaData = new System.Windows.Forms.MonthCalendar();
            this.label11 = new System.Windows.Forms.Label();
            this.modifica = new System.Windows.Forms.Button();
            this.modificaZona = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.eliminaButton = new System.Windows.Forms.Button();
            this.ordinaCre = new System.Windows.Forms.Button();
            this.ordinaDec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.oreBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modificaOre)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(641, 439);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // indietroButton
            // 
            this.indietroButton.Location = new System.Drawing.Point(819, 5);
            this.indietroButton.Name = "indietroButton";
            this.indietroButton.Size = new System.Drawing.Size(95, 20);
            this.indietroButton.TabIndex = 15;
            this.indietroButton.Text = "Indietro";
            this.indietroButton.UseVisualStyleBackColor = true;
            this.indietroButton.Click += new System.EventHandler(this.indietroButton_Click);
            // 
            // sociButton
            // 
            this.sociButton.Location = new System.Drawing.Point(12, 583);
            this.sociButton.Name = "sociButton";
            this.sociButton.Size = new System.Drawing.Size(95, 30);
            this.sociButton.TabIndex = 16;
            this.sociButton.Text = "Soci";
            this.sociButton.UseVisualStyleBackColor = true;
            this.sociButton.Click += new System.EventHandler(this.sociButton_Click);
            // 
            // modificaFornitore
            // 
            this.modificaFornitore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modificaFornitore.Enabled = false;
            this.modificaFornitore.FormattingEnabled = true;
            this.modificaFornitore.Location = new System.Drawing.Point(665, 320);
            this.modificaFornitore.Name = "modificaFornitore";
            this.modificaFornitore.Size = new System.Drawing.Size(115, 21);
            this.modificaFornitore.TabIndex = 17;
            // 
            // modificaDestinatario
            // 
            this.modificaDestinatario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modificaDestinatario.Enabled = false;
            this.modificaDestinatario.FormattingEnabled = true;
            this.modificaDestinatario.Location = new System.Drawing.Point(786, 320);
            this.modificaDestinatario.Name = "modificaDestinatario";
            this.modificaDestinatario.Size = new System.Drawing.Size(106, 21);
            this.modificaDestinatario.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(676, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Fornitore";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(783, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Destinatario";
            // 
            // modificaServizio
            // 
            this.modificaServizio.Location = new System.Drawing.Point(665, 360);
            this.modificaServizio.Name = "modificaServizio";
            this.modificaServizio.Size = new System.Drawing.Size(115, 20);
            this.modificaServizio.TabIndex = 21;
            // 
            // modificaOre
            // 
            this.modificaOre.DecimalPlaces = 1;
            this.modificaOre.Location = new System.Drawing.Point(786, 360);
            this.modificaOre.Name = "modificaOre";
            this.modificaOre.Size = new System.Drawing.Size(106, 20);
            this.modificaOre.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(662, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tipo di servizio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(786, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Numero ore";
            // 
            // modificaData
            // 
            this.modificaData.Location = new System.Drawing.Point(665, 434);
            this.modificaData.MaxSelectionCount = 1;
            this.modificaData.Name = "modificaData";
            this.modificaData.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(770, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Data";
            // 
            // modifica
            // 
            this.modifica.Location = new System.Drawing.Point(665, 599);
            this.modifica.Name = "modifica";
            this.modifica.Size = new System.Drawing.Size(227, 43);
            this.modifica.TabIndex = 27;
            this.modifica.Text = "Modifica";
            this.modifica.UseVisualStyleBackColor = true;
            this.modifica.Click += new System.EventHandler(this.modifica_Click);
            // 
            // modificaZona
            // 
            this.modificaZona.Location = new System.Drawing.Point(665, 398);
            this.modificaZona.Name = "modificaZona";
            this.modificaZona.Size = new System.Drawing.Size(227, 20);
            this.modificaZona.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(768, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Zona";
            // 
            // eliminaButton
            // 
            this.eliminaButton.Location = new System.Drawing.Point(426, 508);
            this.eliminaButton.Name = "eliminaButton";
            this.eliminaButton.Size = new System.Drawing.Size(227, 43);
            this.eliminaButton.TabIndex = 30;
            this.eliminaButton.Text = "Elimina";
            this.eliminaButton.UseVisualStyleBackColor = true;
            this.eliminaButton.Click += new System.EventHandler(this.eliminaButton_Click);
            // 
            // ordinaCre
            // 
            this.ordinaCre.Location = new System.Drawing.Point(12, 508);
            this.ordinaCre.Name = "ordinaCre";
            this.ordinaCre.Size = new System.Drawing.Size(181, 43);
            this.ordinaCre.TabIndex = 31;
            this.ordinaCre.Text = "Ordina per ore (Crescente)";
            this.ordinaCre.UseVisualStyleBackColor = true;
            this.ordinaCre.Click += new System.EventHandler(this.ordinaCre_Click);
            // 
            // ordinaDec
            // 
            this.ordinaDec.Location = new System.Drawing.Point(222, 508);
            this.ordinaDec.Name = "ordinaDec";
            this.ordinaDec.Size = new System.Drawing.Size(181, 43);
            this.ordinaDec.TabIndex = 32;
            this.ordinaDec.Text = "Ordina per ore (Decrescente)";
            this.ordinaDec.UseVisualStyleBackColor = true;
            this.ordinaDec.Click += new System.EventHandler(this.ordinaDec_Click);
            // 
            // PrestazioniView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 654);
            this.Controls.Add(this.ordinaDec);
            this.Controls.Add(this.ordinaCre);
            this.Controls.Add(this.eliminaButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.modificaZona);
            this.Controls.Add(this.modifica);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.modificaData);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.modificaOre);
            this.Controls.Add(this.modificaServizio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.modificaDestinatario);
            this.Controls.Add(this.modificaFornitore);
            this.Controls.Add(this.sociButton);
            this.Controls.Add(this.indietroButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.modificaOre)).EndInit();
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
        private System.Windows.Forms.Button indietroButton;
        private System.Windows.Forms.Button sociButton;
        internal System.Windows.Forms.ComboBox modificaFornitore;
        private System.Windows.Forms.ComboBox modificaDestinatario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox modificaServizio;
        private System.Windows.Forms.NumericUpDown modificaOre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MonthCalendar modificaData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button modifica;
        private System.Windows.Forms.TextBox modificaZona;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button eliminaButton;
        private System.Windows.Forms.Button ordinaCre;
        private System.Windows.Forms.Button ordinaDec;
    }
}