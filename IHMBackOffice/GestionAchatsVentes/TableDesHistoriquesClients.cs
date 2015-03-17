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
    public partial class TableDesHistoriquesClients : Form
    {
        private Dao dao;
        public TableDesHistoriquesClients()
        {
            dao= new Dao();
            InitializeComponent();
        }
        public Utilisateur UtilisateurSelect
        {
            get { return (Utilisateur)utilisateurBindingSource.Current; }
        }

        public Commande CommandeSelect
        {
            get { return (Commande) commandeBindingSource.Current; }
        }
        private void rechercherTextBox_TextChanged(object sender, EventArgs e)
        {
            string recherche = rechercherTextBox.Text;
            utilisateurBindingSource.DataSource = (string.IsNullOrWhiteSpace(recherche) ?
            dao.AllUtilisateurs() : dao.RechercheUtilisateurs(recherche));
        }

        private void AfficherAllUtilisateurs()
        {
            utilisateurBindingSource.DataSource = dao.AllUtilisateurs();
        }

        private void rafraichirButton_Click_1(object sender, EventArgs e)
        {
            AfficherAllUtilisateurs();
            rechercherTextBox.Text = string.Empty;
        }

        private void fermerButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void TableDesHistoriquesClients_Load(object sender, EventArgs e)
        {
            AfficherAllUtilisateurs();
        }

        private void utilisateurDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (UtilisateurSelect != null)
            {
                commandeBindingSource.DataSource = dao.FindCommandes(UtilisateurSelect);
            }



        }

        private void commandeDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (CommandeSelect != null)
            {
                panierBindingSource.DataSource = dao.FindLignesDeCommande(CommandeSelect);
                dao.UpdateLigneDeCommandeDataSource(dao.FindLignesDeCommande(CommandeSelect), panierDataGridView);
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        

    }
}
