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
    public partial class TableDesRubriques : Form
    {
         private Dao dao;

        public TableDesRubriques()
        {
            dao = new Dao();
            InitializeComponent();
        }

    /**************************************************/
        public Rubrique RubriqueSelect
        {
            get { return (Rubrique) rubriqueBindingSource.Current; }
        }

        private void AfficherAllRubriques()
        {
            rubriqueBindingSource.DataSource = dao.AllRubriques();
        }


        private void rechercherTextBox_TextChanged(object sender, EventArgs e)
        {
            string recherche = rechercherTextBox.Text;
            rubriqueBindingSource.DataSource = (string.IsNullOrWhiteSpace(recherche) ? dao.AllRubriques() : dao.RechercheRubriques(recherche));
      
        }

        private void TableDesRubriques_Load(object sender, EventArgs e)
        {
            AfficherAllRubriques();

        }

        private void fermerButton_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void rafraichirButton_Click(object sender, EventArgs e)
        {
            AfficherAllRubriques();
            rechercherTextBox.Text = string.Empty;

        }

        private void ajouterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                Rubrique rubrique = new Rubrique();
                DetailsRubrique da = new DetailsRubrique(rubrique);
                DialogResult result = da.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string mot = rubrique.Nom;
                    if (string.IsNullOrWhiteSpace(mot))
                        return;
                    dao.CreateRubrique(rubrique);
                }
                AfficherAllRubriques();
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
                Rubrique rubrique = RubriqueSelect;
                DetailsRubrique da = new DetailsRubrique(rubrique);
                DialogResult result = da.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string mot = rubrique.Nom;
                    if (string.IsNullOrWhiteSpace(mot))
                        MessageBox.Show("Erreur vous devez entrer une rubrique valide" +
                                        "Modification annulé ! ");
                    dao.UpdateRubrique(rubrique);
                }
                AfficherAllRubriques();

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
                Rubrique rubrique = (Rubrique)rubriqueBindingSource.Current;
                DialogResult result;

                result = MessageBox.Show(
                    string.Format("Êtes-vous sûr de vouloir supprimer la rubrique suivante : {0} {1} ", rubrique.Nom, "?")
                    , "Demande de confirmation"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dao.DeleteRubrique(rubrique);
                }
                AfficherAllRubriques();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
