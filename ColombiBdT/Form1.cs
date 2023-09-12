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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrestazioniView soci = new PrestazioniView();
            soci.ShowDialog();
            this.Close();
        }

        private void sociButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SociView soci = new SociView();
            soci.ShowDialog();
            this.Close();
        }
    }
}
