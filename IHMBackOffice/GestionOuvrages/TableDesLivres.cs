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

namespace IHMBackOffice.GestionOuvrages
{
    public partial class TableDesLivres : Form
    {
           private Dao dao;
        public TableDesLivres()
        {
            dao = new Dao();
            InitializeComponent();
        }

        public Livre LivreSelect
        {
            get { return (Livre)livreBindingSource.Current; }
        }

        private void AfficherAllLivres()
        {
            livreBindingSource.DataSource = dao.AllLivres();
        }

        private void fermerButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /***************************************/

        private void rechercherTextBox_TextChanged_1(object sender, EventArgs e)
        {
            string recherche = rechercherTextBox.Text;
            livreBindingSource.DataSource = (string.IsNullOrWhiteSpace(recherche) ? dao.AllLivres() : dao.RechercheLivres(recherche));
            
        }

        private void TableDesLivres_Load(object sender, EventArgs e)
        {
            AfficherAllLivres();

        }

        private void rafraichirButton_Click_1(object sender, EventArgs e)
        {
            AfficherAllLivres();
            rechercherTextBox.Text = string.Empty;
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Livre livre = new Livre();
                DetailsLivre dl = new DetailsLivre(livre);
                DialogResult result = dl.ShowDialog();

               if (result == DialogResult.OK)
                {
                    string titre = livre.Titre;
                    string sousTitre = livre.SousTitre;
                    if (string.IsNullOrWhiteSpace(titre) || string.IsNullOrWhiteSpace(sousTitre))
                        return;
                    dao.CreateLivre(livre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Livre livre = LivreSelect;
                DetailsLivre dl = new DetailsLivre(livre);
                DialogResult result = dl.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string titre = livre.Titre;
                    string sousTitre = livre.SousTitre;
                    if (string.IsNullOrWhiteSpace(titre) || string.IsNullOrWhiteSpace(sousTitre))
                        MessageBox.Show("Erreur vous devez entrer un titre et un sous-titre\n" +
                                        "Modification annulé ! ");
                    dao.UpdateLivre(livre);
                }
                AfficherAllLivres();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Livre livre = (Livre) livreBindingSource.Current;
                DialogResult result;

                result = MessageBox.Show(
                    string.Format("Êtes-vous sûr de vouloir supprimer le livre  {0} {1} ", livre.Titre, "?")
                    , "Demande de confirmation"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dao.DeleteLivre(livre);
                }
                AfficherAllLivres();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }






        /*******************************************/

    }
}
