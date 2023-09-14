using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColombiBdT
{
    public partial class PrestazioniView : Form
    {
        public PrestazioniView()
        {
            InitializeComponent();
        }
        BancaDelTempo bdt;
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void aggiungiButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(servizioBox.Text) && !string.IsNullOrEmpty(destinatarioBox.Text) && !string.IsNullOrEmpty(fornitoreBox.Text))
            {
                if (!(fornitoreBox.SelectedIndex == destinatarioBox.SelectedIndex))
                {
                    string data=dataBox.SelectionStart.ToString();
                    Prestazione p = new Prestazione(destinatarioBox.SelectedIndex, fornitoreBox.SelectedIndex, data, (float)oreBox.Value, zonaBox.Text, servizioBox.Text);
                    try
                    {
                        bdt.aggiungiPrestazione(p);
                    } catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    bdt.Scrivi();
                    Visualizza(bdt.RegistroPrestazioni);
                    servizioBox.Text = "";
                    destinatarioBox.SelectedIndex = 0;
                    fornitoreBox.SelectedIndex = 0;
                    oreBox.Value = 0;
                    zonaBox.Text = "";
                    
                }
                else MessageBox.Show("Il fornitore e il destinatario devono essere diversi");
            }
            else MessageBox.Show("Uno o più valori non validi");
        }

        private void PrestazioniView_Load(object sender, EventArgs e)
        {
            bdt = new BancaDelTempo();
            bdt.Carica();
            foreach (Socio s in bdt.ElencoSoci)
            {
                fornitoreBox.Items.Add($"{s.Nome} {s.Cognome} {s.IDSocio}");
                destinatarioBox.Items.Add($"{s.Nome} {s.Cognome} {s.IDSocio}");
                modificaDestinatario.Items.Add($"{s.Nome} {s.Cognome} {s.IDSocio}");
                modificaFornitore.Items.Add($"{s.Nome} {s.Cognome} {s.IDSocio}");
            }
            string[] intestazione = new string[] { "TIPO", "FORNITORE", "DESTINATARIO", "DATA", "NUMERO ORE" };

            for (int i = 0; i < intestazione.Length; i++)

            {

                listView1.Columns.Add(intestazione[i]);

            }

            Visualizza(bdt.RegistroPrestazioni);
        
        

        }
        private void Visualizza(List<Prestazione> lista)
        {
            listView1.Items.Clear();
            listView1.FullRowSelect = true;
            listView1.View = View.Details;

            foreach (Prestazione s in lista)
            {
                string[] p = new string[] { $"{s.Tipo}", $"{bdt.ElencoSoci[s.IDFornitore].Nome} {bdt.ElencoSoci[s.IDFornitore].Cognome}", $"{bdt.ElencoSoci[s.IDRichiedente].Nome} {bdt.ElencoSoci[s.IDRichiedente].Cognome}", $"{s.Data}", $"{s.NOre}" };
                ListViewItem item = new ListViewItem(p);
                listView1.Items.Add(item);

            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void fornitoreBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void indietroButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form=new Form1();
            form.ShowDialog();
            this.Close();
        }

        private void sociButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SociView form = new SociView();
            form.ShowDialog();
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                Prestazione vecchia = bdt.RegistroPrestazioni[listView1.SelectedIndices[0]];
                modificaOre.Value = (decimal)vecchia.NOre;
                modificaDestinatario.SelectedIndex = vecchia.IDRichiedente;
                modificaFornitore.SelectedIndex = vecchia.IDFornitore;
                modificaServizio.Text = vecchia.Tipo;
                modificaZona.Text = vecchia.Zona;
            }
        }

        private void modifica_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                if (!string.IsNullOrEmpty(modificaServizio.Text)&& !string.IsNullOrEmpty(modificaZona.Text))
                {
                    Prestazione p= bdt.RegistroPrestazioni[listView1.SelectedIndices[0]];
                    bdt.ElencoSoci[p.IDRichiedente].modificaDebito(p.NOre);
                    bdt.ElencoSoci[p.IDFornitore].modificaDebito(-p.NOre);
                    Prestazione nuova = new Prestazione(modificaZona.Text, modificaServizio.Text, (float)modificaOre.Value, p.IDRichiedente, p.IDFornitore, modificaData.SelectionStart.ToString(), p.IDServizio);
                    try 
                    {
                        bdt.ElencoSoci[p.IDRichiedente].modificaDebito(-nuova.NOre);
                        

                    } catch (Exception ex) 
                    {
                        MessageBox.Show(ex.Message);
                        bdt.ElencoSoci[p.IDRichiedente].modificaDebito(-p.NOre);
                        return;
                    }
                    try
                    {
                        bdt.ElencoSoci[p.IDFornitore].modificaDebito(nuova.NOre);
                    } catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        bdt.ElencoSoci[p.IDFornitore].modificaDebito(p.NOre);
                        bdt.ElencoSoci[p.IDRichiedente].modificaDebito(nuova.NOre);
                        bdt.ElencoSoci[p.IDRichiedente].modificaDebito(-p.NOre);
                        return;
                    }
                    MessageBox.Show("Machuca machuca");
                    bdt.RegistroPrestazioni[nuova.IDServizio] = nuova;
                    modificaDestinatario.SelectedIndex = 0;
                    modificaFornitore.SelectedIndex = 0;
                    modificaOre.Value = 0;
                    modificaServizio.Text = "";
                    modificaZona.Text = "";
                    Visualizza(bdt.RegistroPrestazioni);
                    bdt.Scrivi();
                }
            }
            else MessageBox.Show("Selezionare una prestazione da modificare");
        }

        private void eliminaButton_Click(object sender, EventArgs e)
        {
            int v;
            if (listView1.SelectedIndices.Count > 0)
            {
                v = listView1.SelectedIndices[0];
                Prestazione p = bdt.RegistroPrestazioni[v];
                bdt.ElencoSoci[p.IDRichiedente].modificaDebito(p.NOre);
                bdt.ElencoSoci[p.IDFornitore].modificaDebito(-p.NOre);
                bdt.RegistroPrestazioni.Remove(p);
                for (int i = v; i < bdt.RegistroPrestazioni.Count; i++)
                {
                    bdt.RegistroPrestazioni[i].IDServizio--;
                }
                Prestazione.loadServizi(Prestazione.NServizi - 1);
                bdt.Scrivi();
                MessageBox.Show("Prestazione rimossa");
                Visualizza(bdt.RegistroPrestazioni);
            }
            else MessageBox.Show("Selezionare una prestazione da eliminare");
        }

        private void ordinaCre_Click(object sender, EventArgs e)
        {
            bdt.RegistroPrestazioni.Sort();
            Visualizza(bdt.RegistroPrestazioni);
        }

        private void ordinaDec_Click(object sender, EventArgs e)
        {
            bdt.RegistroPrestazioni.Reverse();
            Visualizza(bdt.RegistroPrestazioni);
        }
    }
}
