using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace ColombiBdT
{
    public partial class SociView : Form
    {
        public SociView()
        {
            InitializeComponent();
        }
        BancaDelTempo bdt;
        List<Socio> ElencoSoci;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        private void SociView_Load(object sender, EventArgs e)
        {
            bdt = new BancaDelTempo();
            bdt.Carica();
            string[] intestazione = new string[] { "ID", "NOME", "COGNOME", "TELEFONO" };

            for (int i = 0; i < intestazione.Length; i++)

            {

                listView1.Columns.Add(intestazione[i]);

            }
            ElencoSoci = new List<Socio>();
            foreach (Socio s in bdt.ElencoSoci)
            {
                ElencoSoci.Add(s.Clone());
            }
            Refresh();
        }
        private void Refresh()
        {
            foreach(Socio s in ElencoSoci)
            {
                string agg = $"{s.IDSocio};{s.Nome};{s.Cognome};{s.Telefono}";
                ListViewItem riga = new ListViewItem(agg.Split(';'));
                listView1.Items.Add(riga);

            }
        }

        private void aggiungiButton_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(nomeBox.Text) && !String.IsNullOrEmpty(cognomeBox.Text) && !String.IsNullOrEmpty(numeroBox.Text) && !String.IsNullOrEmpty(nomeBox.Text))
            {
                int x=0;
                try
                {
                  x=int.Parse(numeroBox.Text);
                } catch (Exception ex)
                {
                    MessageBox.Show("Numero di telefono non valido");
                }
                if (soloSegreteria.Checked)
                {
                    if (segreteria.Checked)
                    {
                        if (!soloDebiti.Checked)
                        {
                            Socio nuovo = new Socio(nomeBox.Text, cognomeBox.Text, x, segreteria.Checked);
                            ElencoSoci.Add(nuovo);
                        }
                    }
                } 
                bdt.aggiungiSocio(nomeBox.Text, cognomeBox.Text, x, segreteria.Checked);
                bdt.Scrivi();
                Refresh();
            }
            else
            {
                MessageBox.Show("Uno o piu' valori inseriti non sono validi");
            }
           
        }
    }
}
