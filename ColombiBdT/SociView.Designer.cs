
namespace ColombiBdT
{
    partial class SociView
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.segreteria = new System.Windows.Forms.CheckBox();
            this.aggiungiButton = new System.Windows.Forms.Button();
            this.nomeBox = new System.Windows.Forms.TextBox();
            this.cognomeBox = new System.Windows.Forms.TextBox();
            this.numeroBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.modificaButton = new System.Windows.Forms.Button();
            this.modificaNome = new System.Windows.Forms.TextBox();
            this.modificaCognome = new System.Windows.Forms.TextBox();
            this.modificaTelefono = new System.Windows.Forms.TextBox();
            this.modificaSegreteria = new System.Windows.Forms.CheckBox();
            this.modificaDebito = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.eliminaButton = new System.Windows.Forms.Button();
            this.sociSeg = new System.Windows.Forms.Button();
            this.sociDeb = new System.Windows.Forms.Button();
            this.sociNSeg = new System.Windows.Forms.Button();
            this.sociNDeb = new System.Windows.Forms.Button();
            this.visualizzaTot = new System.Windows.Forms.Button();
            this.indietroButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modificaDebito)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 5;
            // 
            // segreteria
            // 
            this.segreteria.AutoSize = true;
            this.segreteria.Location = new System.Drawing.Point(384, 41);
            this.segreteria.Name = "segreteria";
            this.segreteria.Size = new System.Drawing.Size(74, 17);
            this.segreteria.TabIndex = 6;
            this.segreteria.Text = "Segreteria";
            this.segreteria.UseVisualStyleBackColor = true;
            // 
            // aggiungiButton
            // 
            this.aggiungiButton.Location = new System.Drawing.Point(487, 14);
            this.aggiungiButton.Name = "aggiungiButton";
            this.aggiungiButton.Size = new System.Drawing.Size(122, 47);
            this.aggiungiButton.TabIndex = 7;
            this.aggiungiButton.Text = "Aggiungi";
            this.aggiungiButton.UseVisualStyleBackColor = true;
            this.aggiungiButton.Click += new System.EventHandler(this.aggiungiButton_Click);
            // 
            // nomeBox
            // 
            this.nomeBox.Location = new System.Drawing.Point(12, 41);
            this.nomeBox.Name = "nomeBox";
            this.nomeBox.Size = new System.Drawing.Size(117, 20);
            this.nomeBox.TabIndex = 8;
            // 
            // cognomeBox
            // 
            this.cognomeBox.Location = new System.Drawing.Point(135, 41);
            this.cognomeBox.Name = "cognomeBox";
            this.cognomeBox.Size = new System.Drawing.Size(117, 20);
            this.cognomeBox.TabIndex = 9;
            // 
            // numeroBox
            // 
            this.numeroBox.Location = new System.Drawing.Point(258, 41);
            this.numeroBox.Name = "numeroBox";
            this.numeroBox.Size = new System.Drawing.Size(117, 20);
            this.numeroBox.TabIndex = 10;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(446, 293);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // modificaButton
            // 
            this.modificaButton.Location = new System.Drawing.Point(487, 67);
            this.modificaButton.Name = "modificaButton";
            this.modificaButton.Size = new System.Drawing.Size(122, 47);
            this.modificaButton.TabIndex = 14;
            this.modificaButton.Text = "Modifica";
            this.modificaButton.UseVisualStyleBackColor = true;
            this.modificaButton.Click += new System.EventHandler(this.modificaButton_Click);
            // 
            // modificaNome
            // 
            this.modificaNome.Location = new System.Drawing.Point(487, 143);
            this.modificaNome.Name = "modificaNome";
            this.modificaNome.Size = new System.Drawing.Size(100, 20);
            this.modificaNome.TabIndex = 15;
            // 
            // modificaCognome
            // 
            this.modificaCognome.Location = new System.Drawing.Point(487, 186);
            this.modificaCognome.Name = "modificaCognome";
            this.modificaCognome.Size = new System.Drawing.Size(100, 20);
            this.modificaCognome.TabIndex = 16;
            // 
            // modificaTelefono
            // 
            this.modificaTelefono.Location = new System.Drawing.Point(487, 225);
            this.modificaTelefono.Name = "modificaTelefono";
            this.modificaTelefono.Size = new System.Drawing.Size(100, 20);
            this.modificaTelefono.TabIndex = 17;
            // 
            // modificaSegreteria
            // 
            this.modificaSegreteria.AutoSize = true;
            this.modificaSegreteria.Location = new System.Drawing.Point(487, 290);
            this.modificaSegreteria.Name = "modificaSegreteria";
            this.modificaSegreteria.Size = new System.Drawing.Size(74, 17);
            this.modificaSegreteria.TabIndex = 18;
            this.modificaSegreteria.Text = "Segreteria";
            this.modificaSegreteria.UseVisualStyleBackColor = true;
            // 
            // modificaDebito
            // 
            this.modificaDebito.DecimalPlaces = 1;
            this.modificaDebito.Location = new System.Drawing.Point(487, 264);
            this.modificaDebito.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            -2147483648});
            this.modificaDebito.Name = "modificaDebito";
            this.modificaDebito.Size = new System.Drawing.Size(100, 20);
            this.modificaDebito.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Cogome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Telefono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(484, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Debito ore";
            // 
            // eliminaButton
            // 
            this.eliminaButton.Location = new System.Drawing.Point(487, 313);
            this.eliminaButton.Name = "eliminaButton";
            this.eliminaButton.Size = new System.Drawing.Size(122, 47);
            this.eliminaButton.TabIndex = 24;
            this.eliminaButton.Text = "Elimina";
            this.eliminaButton.UseVisualStyleBackColor = true;
            this.eliminaButton.Click += new System.EventHandler(this.eliminaButton_Click);
            // 
            // sociSeg
            // 
            this.sociSeg.Location = new System.Drawing.Point(12, 366);
            this.sociSeg.Name = "sociSeg";
            this.sociSeg.Size = new System.Drawing.Size(182, 34);
            this.sociSeg.TabIndex = 25;
            this.sociSeg.Text = "Visualizza soci della segreteria";
            this.sociSeg.UseVisualStyleBackColor = true;
            this.sociSeg.Click += new System.EventHandler(this.sociSeg_Click_1);
            // 
            // sociDeb
            // 
            this.sociDeb.Location = new System.Drawing.Point(276, 366);
            this.sociDeb.Name = "sociDeb";
            this.sociDeb.Size = new System.Drawing.Size(182, 34);
            this.sociDeb.TabIndex = 26;
            this.sociDeb.Text = "Visualizza soci indebitati";
            this.sociDeb.UseVisualStyleBackColor = true;
            this.sociDeb.Click += new System.EventHandler(this.sociDeb_Click);
            // 
            // sociNSeg
            // 
            this.sociNSeg.Location = new System.Drawing.Point(12, 406);
            this.sociNSeg.Name = "sociNSeg";
            this.sociNSeg.Size = new System.Drawing.Size(182, 34);
            this.sociNSeg.TabIndex = 27;
            this.sociNSeg.Text = "Visualizza soci non della segreteria";
            this.sociNSeg.UseVisualStyleBackColor = true;
            this.sociNSeg.Click += new System.EventHandler(this.sociNSeg_Click);
            // 
            // sociNDeb
            // 
            this.sociNDeb.Location = new System.Drawing.Point(276, 406);
            this.sociNDeb.Name = "sociNDeb";
            this.sociNDeb.Size = new System.Drawing.Size(182, 34);
            this.sociNDeb.TabIndex = 28;
            this.sociNDeb.Text = "Visualizza soci in positivo";
            this.sociNDeb.UseVisualStyleBackColor = true;
            this.sociNDeb.Click += new System.EventHandler(this.sociNDeb_Click);
            // 
            // visualizzaTot
            // 
            this.visualizzaTot.Location = new System.Drawing.Point(487, 382);
            this.visualizzaTot.Name = "visualizzaTot";
            this.visualizzaTot.Size = new System.Drawing.Size(122, 44);
            this.visualizzaTot.TabIndex = 29;
            this.visualizzaTot.Text = "Visualizza tutti";
            this.visualizzaTot.UseVisualStyleBackColor = true;
            this.visualizzaTot.Click += new System.EventHandler(this.visualizzaTot_Click);
            // 
            // indietroButton
            // 
            this.indietroButton.Location = new System.Drawing.Point(12, 3);
            this.indietroButton.Name = "indietroButton";
            this.indietroButton.Size = new System.Drawing.Size(75, 23);
            this.indietroButton.TabIndex = 30;
            this.indietroButton.Text = "Indietro";
            this.indietroButton.UseVisualStyleBackColor = true;
            this.indietroButton.Click += new System.EventHandler(this.indietroButton_Click);
            // 
            // SociView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.indietroButton);
            this.Controls.Add(this.visualizzaTot);
            this.Controls.Add(this.sociNDeb);
            this.Controls.Add(this.sociNSeg);
            this.Controls.Add(this.sociDeb);
            this.Controls.Add(this.sociSeg);
            this.Controls.Add(this.eliminaButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.modificaDebito);
            this.Controls.Add(this.modificaSegreteria);
            this.Controls.Add(this.modificaTelefono);
            this.Controls.Add(this.modificaCognome);
            this.Controls.Add(this.modificaNome);
            this.Controls.Add(this.modificaButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.numeroBox);
            this.Controls.Add(this.cognomeBox);
            this.Controls.Add(this.nomeBox);
            this.Controls.Add(this.aggiungiButton);
            this.Controls.Add(this.segreteria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SociView";
            this.Load += new System.EventHandler(this.SociView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modificaDebito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox segreteria;
        private System.Windows.Forms.Button aggiungiButton;
        private System.Windows.Forms.TextBox nomeBox;
        private System.Windows.Forms.TextBox cognomeBox;
        private System.Windows.Forms.TextBox numeroBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button modificaButton;
        private System.Windows.Forms.TextBox modificaNome;
        private System.Windows.Forms.TextBox modificaCognome;
        private System.Windows.Forms.TextBox modificaTelefono;
        private System.Windows.Forms.CheckBox modificaSegreteria;
        private System.Windows.Forms.NumericUpDown modificaDebito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button eliminaButton;
        private System.Windows.Forms.Button sociSeg;
        private System.Windows.Forms.Button sociDeb;
        private System.Windows.Forms.Button sociNSeg;
        private System.Windows.Forms.Button sociNDeb;
        private System.Windows.Forms.Button visualizzaTot;
        private System.Windows.Forms.Button indietroButton;
    }
}