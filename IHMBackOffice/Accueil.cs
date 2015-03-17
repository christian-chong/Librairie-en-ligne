using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IHMBackOffice.GestionAchatsVentes;
using IHMBackOffice.GestionOuvrages;

namespace IHMBackOffice
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void tablesDesLivresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var eel = new EditExemplaireLivre();
            eel.Visible = true;

        }

        private void tablesDesRubriquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tdl = new TableDesLivres();
            tdl.Visible = true;
        }

        private void tablesDesMotsClésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tda = new TableDesAuteurs();
            tda.Visible = true;
        }

        private void tablesDesMotsClésToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var tdm = new TableDesMotsCles();
            tdm.Visible = true;
        }

        private void tablesDesRubriquesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var tdr = new TableDesRubriques();
            tdr.Visible = true;
        }

        private void tablesDesPrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tep = new TableExemplairePrix();
            tep.Visible = true;
        }

        private void modeDePaiementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var tdm = new TableModeDePaiement();
            tdm.Visible = true;
        }

        private void commandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tdc = new TableDesCommandes();
            tdc.Visible = true;
        }

        private void tablesDesStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tds = new TableDesStatus();
            tds.Visible = true;
        }

        private void entrerUneCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ac = new AjouterCommande();
            ac.Visible = true;
        }

        private void historiqueDesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tdhc = new TableDesHistoriquesClients();
            tdhc.Visible = true;
        }
    }
}
