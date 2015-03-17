using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DAL.Models;

namespace IHMBackOffice.GestionAchatsVentes
{
    public partial class TableDesCommandes : Form
    {
        private Dao dao;

        public TableDesCommandes()
        { 
            dao = new Dao();
            InitializeComponent();
        }

        private void rechercherTextBox_TextChanged(object sender, EventArgs e)
        {
            string recherche = rechercherTextBox.Text;
            commandeBindingSource.DataSource = (string.IsNullOrWhiteSpace(recherche) ?
                dao.AllCommandes() : dao.RechercheCommande(recherche));
      
        }

        private void fermerButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rafraichirButton_Click(object sender, EventArgs e)
        {
            AfficherAllCommandes();
            rechercherTextBox.Text = string.Empty;
        }

        public Commande CommandeSelect
        {
            get { return (Commande)commandeBindingSource.Current; }
        }

        private void AfficherAllCommandes()
        {
            commandeBindingSource.DataSource = dao.AllCommandes();
        }

  
        private void commandeDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (CommandeSelect != null)
            {
                panierBindingSource.DataSource = dao.FindLignesDeCommande(CommandeSelect);
                dao.UpdateLigneDeCommandeDataSource(dao.FindLignesDeCommande(CommandeSelect), panierDataGridView);
            }
        }

        private void TableDesCommandes_Load(object sender, EventArgs e)
        {
            AfficherAllCommandes();
            panierBindingSource.DataSource = dao.FindLignesDeCommande(CommandeSelect);
           dao.UpdateLigneDeCommandeDataSource(dao.FindLignesDeCommande(CommandeSelect), panierDataGridView);
        }



    }
}
