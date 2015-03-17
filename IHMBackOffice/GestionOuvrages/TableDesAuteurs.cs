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
    public partial class TableDesAuteurs : Form
    {
        private Dao dao;
        public TableDesAuteurs()
        {
            dao = new Dao();
            InitializeComponent();
        }
        public Auteur AuteurSelect
        {
            get { return (Auteur)auteurBindingSource.Current; }
        }

        private void AfficherAllAuteurs()
        {
            auteurBindingSource.DataSource = dao.AllAuteurs();
        }


        private void rechercherTextBox_TextChanged(object sender, EventArgs e)
        {
            string recherche = rechercherTextBox.Text;
            auteurBindingSource.DataSource = (string.IsNullOrWhiteSpace(recherche) ? dao.AllAuteurs() : dao.RechercheAuteurs(recherche));

        }

        private void TableDesAuteurs_Load(object sender, EventArgs e)
        {
        AfficherAllAuteurs();
        }

        private void rafraichirButton_Click(object sender, EventArgs e)
        {
           AfficherAllAuteurs();
           rechercherTextBox.Text = string.Empty;
        }


        private void fermerButton_Click(object sender, EventArgs e)
        {
        Close();

        }

        private void ajouterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
         try
            {
                Auteur auteur = new Auteur();
                DetailsAuteur da = new DetailsAuteur(auteur);
                DialogResult result = da.ShowDialog();

               if (result == DialogResult.OK)
                {
                    string nom = auteur.Nom;
                    string prenom = auteur.Prenom;
                    if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom))
                        return;
                    dao.CreateAuteur(auteur);
                }
               AfficherAllAuteurs();

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
                Auteur auteur = AuteurSelect;
                DetailsAuteur da = new DetailsAuteur(auteur);
                DialogResult result = da.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string nom = auteur.Nom;
                    string prenom = auteur.Prenom;
                    if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom))
                        MessageBox.Show("Erreur vous devez entrer un nom et un prenom\n" +
                                        "Modification annulé ! ");
                    dao.UpdateAuteur(auteur);
                }
                AfficherAllAuteurs();
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
                Auteur auteur = (Auteur) auteurBindingSource.Current;
                DialogResult result;

                result = MessageBox.Show(
                    string.Format("Êtes-vous sûr de vouloir supprimer l'auteur  {0} {1} {2}", auteur.Prenom, auteur.Nom, "?")
                    , "Demande de confirmation"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dao.DeleteAuteur(auteur);
                }
                AfficherAllAuteurs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
