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
        List<Socio> sociFiltro;
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
            string[] intestazione = new string[] { "ID", "NOME", "COGNOME", "TELEFONO","DEBITO" };

            for (int i = 0; i < intestazione.Length; i++)

            {

                listView1.Columns.Add(intestazione[i]);

            }
            
            Visualizza(bdt.ElencoSoci);
        }
        private void Visualizza(List<Socio> lista)
        {
            listView1.Items.Clear();
            listView1.FullRowSelect = true;
            listView1.View = View.Details;

            foreach (Socio s in lista)
            {
                string[] p = new string[] { $"{s.IDSocio}", $"{s.Nome}", $"{s.Cognome}", $"{s.Telefono.ToString()}", $"{s.DebitoOre}" };
                ListViewItem item = new ListViewItem(p);
                listView1.Items.Add(item);

            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void aggiungiButton_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(nomeBox.Text) && !String.IsNullOrEmpty(cognomeBox.Text) && !String.IsNullOrEmpty(numeroBox.Text) && !String.IsNullOrEmpty(nomeBox.Text))
            {
                long x=0;
                try
                {
                  x=long.Parse(numeroBox.Text);
                } catch (Exception ex)
                {
                    MessageBox.Show("Numero di telefono non valido");
                    nomeBox.Text = "";
                    cognomeBox.Text = "";
                    numeroBox.Text = "";
                    return;
                }
                bdt.aggiungiSocio(nomeBox.Text, cognomeBox.Text, x, segreteria.Checked);
                bdt.Scrivi();
                nomeBox.Text = "";
                cognomeBox.Text = "";
                numeroBox.Text = "";
                segreteria.Checked = false;
                MessageBox.Show("Socio aggiunto");
                Visualizza(bdt.ElencoSoci);
            }
            else
            {
                MessageBox.Show("Uno o piu' valori inseriti non sono validi");
            }
           
        }

        private void modificaButton_Click(object sender, EventArgs e)
        {
            int v=0;
            if (listView1.SelectedIndices.Count > 0)
            {
                v = listView1.SelectedIndices[0];
                if (!string.IsNullOrEmpty(modificaNome.Text) && !string.IsNullOrEmpty(modificaCognome.Text) && !string.IsNullOrEmpty(modificaTelefono.Text) && !string.IsNullOrEmpty(modificaDebito.Text))
                {
                    long x = 0;
                    try
                    {
                        x = long.Parse(modificaTelefono.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Il numero di telefono non è valido");
                    }
                    float y = (float)modificaDebito.Value;
                    bdt.ElencoSoci[v] = new Socio(modificaNome.Text, modificaCognome.Text, y, x, modificaSegreteria.Checked, bdt.ElencoSoci[v].IDSocio);
                    bdt.Scrivi();
                    modificaNome.Text = "";
                    modificaCognome.Text = "";
                    modificaTelefono.Text = "";
                    modificaDebito.Value = 0;
                    modificaSegreteria.Checked = false;
                    MessageBox.Show("Socio modificato");
                    Visualizza(bdt.ElencoSoci);
                }
                else MessageBox.Show("Valori inseriti non validi");
            }
            else MessageBox.Show("Seleziona un elemento da modificare");
        }


        private void eliminaButton_Click(object sender, EventArgs e)
        {
            int v = 0;
            if (listView1.SelectedIndices.Count > 0)
            {
                v = listView1.SelectedIndices[0];
                bdt.ElencoSoci.Remove(bdt.ElencoSoci[v]);
                for(int i = v; i < bdt.ElencoSoci.Count; i++)
                {
                    bdt.ElencoSoci[i].IDSocio--;
                }
                Socio.LoadSoci(Socio.NSoci - 1);
                bdt.Scrivi();
                MessageBox.Show("Socio rimosso");
                Visualizza(bdt.ElencoSoci);
            } else
            {
                MessageBox.Show("Selezionare un socio");
            }
        }


        private void sociSeg_Click_1(object sender, EventArgs e)
        {
            sociFiltro = new List<Socio>();
            foreach(Socio s in bdt.ElencoSoci)
            {
                if (s.Segreteria)
                {
                    sociFiltro.Add(s); 
                }
            }
            Visualizza(sociFiltro);
        }

        private void sociNSeg_Click(object sender, EventArgs e)
        {
            sociFiltro = new List<Socio>();
            foreach (Socio s in bdt.ElencoSoci)
            {
                if (!s.Segreteria)
                {
                    sociFiltro.Add(s);
                }
            }
            Visualizza(sociFiltro);
        }

        private void sociDeb_Click(object sender, EventArgs e)
        {
            sociFiltro = new List<Socio>();
            foreach (Socio s in bdt.ElencoSoci)
            {
                if (s.DebitoOre<0)
                {
                    sociFiltro.Add(s);
                }
            }
            Visualizza(sociFiltro);
        }

        private void sociNDeb_Click(object sender, EventArgs e)
        {
            sociFiltro = new List<Socio>();
            foreach (Socio s in bdt.ElencoSoci)
            {
                if (s.DebitoOre>0)
                {
                    sociFiltro.Add(s);
                }
            }
            Visualizza(sociFiltro);
        }

        private void visualizzaTot_Click(object sender, EventArgs e)
        {
            Visualizza(bdt.ElencoSoci);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int v;
            if (listView1.SelectedIndices.Count > 0)
            {
                v = listView1.SelectedIndices[0];
                modificaNome.Text = bdt.ElencoSoci[v].Nome;
                modificaCognome.Text = bdt.ElencoSoci[v].Cognome;
                modificaTelefono.Text = bdt.ElencoSoci[v].Telefono.ToString();
                modificaSegreteria.Checked = bdt.ElencoSoci[v].Segreteria;
                modificaDebito.Value = (decimal)bdt.ElencoSoci[v].DebitoOre;
            }
        }

        private void indietroButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form=new Form1();
            form.ShowDialog();
            this.Close();
        }
    }
}
