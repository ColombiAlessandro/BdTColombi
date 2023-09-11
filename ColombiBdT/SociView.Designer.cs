
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
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.soloDebiti = new System.Windows.Forms.CheckBox();
            this.soloSegreteria = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(446, 366);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 14);
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
            this.segreteria.Location = new System.Drawing.Point(384, 13);
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
            // soloDebiti
            // 
            this.soloDebiti.AutoSize = true;
            this.soloDebiti.Location = new System.Drawing.Point(469, 73);
            this.soloDebiti.Name = "soloDebiti";
            this.soloDebiti.Size = new System.Drawing.Size(147, 17);
            this.soloDebiti.TabIndex = 11;
            this.soloDebiti.Text = "Mostra solo soci indebitati";
            this.soloDebiti.UseVisualStyleBackColor = true;
            // 
            // soloSegreteria
            // 
            this.soloSegreteria.AutoSize = true;
            this.soloSegreteria.Location = new System.Drawing.Point(469, 96);
            this.soloSegreteria.Name = "soloSegreteria";
            this.soloSegreteria.Size = new System.Drawing.Size(129, 17);
            this.soloSegreteria.TabIndex = 12;
            this.soloSegreteria.Text = "Mostra solo segreteria";
            this.soloSegreteria.UseVisualStyleBackColor = true;
            // 
            // SociView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.soloSegreteria);
            this.Controls.Add(this.soloDebiti);
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
            this.Controls.Add(this.listView1);
            this.Name = "SociView";
            this.Text = "SociView";
            this.Load += new System.EventHandler(this.SociView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
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
        private System.Windows.Forms.CheckBox soloDebiti;
        private System.Windows.Forms.CheckBox soloSegreteria;
    }
}