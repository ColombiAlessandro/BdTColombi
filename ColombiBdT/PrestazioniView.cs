using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                if (!(fornitoreBox.SelectedItem == destinatarioBox.SelectedItem))
                {
                    DateTime data= new DateTime(dataBox.
                    Prestazione p=new Prestazione(bdt.ElencoSoci[destinatarioBox.SelectedIndex], bdt.ElencoSoci[fornitoreBox.SelectedIndex]),, zonaBox.Text,)
                }
                else MessageBox.Show("Il fornitore e il destinatario devono essere diversi");
            }
            else MessageBox.Show("Uno o più valori non validi");
        }

        private void PrestazioniView_Load(object sender, EventArgs e)
        {
            bdt = new BancaDelTempo();
            bdt.Carica();
            foreach(Socio s in bdt.ElencoSoci)
            {
                
                fornitoreBox.Items.Add($"{s.Nome} {s.Cognome} {s.IDSocio}");
                destinatarioBox.Items.Add($"{s.Nome} {s.Cognome} {s.IDSocio}");
            }
            
        }

        private void fornitoreBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}
