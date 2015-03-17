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
    public partial class TableDesStatus : Form
    {
        private Dao dao;
        public TableDesStatus()
        {
            dao = new Dao();
            InitializeComponent();
        }

        public StatusDeCommande StatusDeCommandeSelect
        {
            get { return (StatusDeCommande)statusDeCommandeBindingSource.Current; }
        }

        private void AfficherAllStatusDeCommande()
        {
            statusDeCommandeBindingSource.DataSource = dao.AllStatusDeCommandes();
        }

        private void fermerButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void rafraichirButton_Click(object sender, EventArgs e)
        {
            AfficherAllStatusDeCommande();
            rechercherTextBox.Text = string.Empty;

        }

        private void TableDesStatus_Load(object sender, EventArgs e)
        {
            AfficherAllStatusDeCommande();
        }

        private void rechercherTextBox_TextChanged(object sender, EventArgs e)
        {
            string recherche = rechercherTextBox.Text;
            statusDeCommandeBindingSource.DataSource = (string.IsNullOrWhiteSpace(recherche) ?
                dao.AllStatusDeCommandes() : dao.RechercheStatusDeCommandes(recherche));
      
        }



        private void ajouterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        try
            {
                StatusDeCommande statusDeCommande = new StatusDeCommande();
                DetailsStatus ds = new DetailsStatus(statusDeCommande);
                DialogResult result = ds.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string mot = statusDeCommande.Nom;
                    if (string.IsNullOrWhiteSpace(mot))
                        return;
                    dao.CreateStatusDeCommande(statusDeCommande);
                }
                AfficherAllStatusDeCommande();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

  
        private void modifierToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

         try
            {
                StatusDeCommande statusDeCommande = StatusDeCommandeSelect;
                DetailsStatus ds = new DetailsStatus(statusDeCommande);
                DialogResult result = ds.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string mot = statusDeCommande.Nom;
                    if (string.IsNullOrWhiteSpace(mot))
                        MessageBox.Show("Erreur vous devez entrer une rubrique valide" +
                                        "Modification annulé ! ");
                    dao.UpdateStatusDeCommande(statusDeCommande);
                }
                AfficherAllStatusDeCommande();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void supprimerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                StatusDeCommande statusDeCommande = (StatusDeCommande) statusDeCommandeBindingSource.Current;
                DialogResult result;

                result = MessageBox.Show(
                    string.Format("Êtes-vous sûr de vouloir supprimer la rubrique suivante : {0} {1} ", statusDeCommande.Nom, "?")
                    , "Demande de confirmation"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dao.DeleteStatusDeCommande(statusDeCommande);
                }
                AfficherAllStatusDeCommande();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
