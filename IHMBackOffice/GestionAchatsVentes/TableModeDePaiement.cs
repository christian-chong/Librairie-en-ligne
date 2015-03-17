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
using IHMBackOffice.GestionOuvrages;

namespace IHMBackOffice.GestionAchatsVentes
{
    public partial class TableModeDePaiement : Form
    {
        private Dao dao;
        public TableModeDePaiement()
        {
            dao = new Dao();
            InitializeComponent();
        }
        /*****************************/
        public ModeDePaiement ModeDePaiementSelect
        {
            get { return (ModeDePaiement) modeDePaiementBindingSource.Current; }
        }

        private void AfficherAllModeDePaiement()
        {
            modeDePaiementBindingSource.DataSource = dao.AllModeDePaiements();
        }

        private void rechercherTextBox_TextChanged_1(object sender, EventArgs e)
        {
            string recherche = rechercherTextBox.Text;
            modeDePaiementBindingSource.DataSource = (string.IsNullOrWhiteSpace(recherche) ?
                dao.AllModeDePaiements() : dao.RechercheModeDePaiements(recherche));
      
        }

        private void TableModeDePaiement_Load(object sender, EventArgs e)
        {
            AfficherAllModeDePaiement();

        }

        private void fermerButton_Click_1(object sender, EventArgs e)
        {
            Close();

        }

        private void rafraichirButton_Click_1(object sender, EventArgs e)
        {
            AfficherAllModeDePaiement();
            rechercherTextBox.Text = string.Empty;

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           try
            {
                ModeDePaiement modeDePaiement = new ModeDePaiement();
                DetailsModeDePaiement dm = new DetailsModeDePaiement(modeDePaiement);
                DialogResult result = dm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string mot = modeDePaiement.Type;
                    if (string.IsNullOrWhiteSpace(mot))
                        return;
                    dao.CreateModeDePaiement(modeDePaiement);
                }
                AfficherAllModeDePaiement();
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
                ModeDePaiement modeDePaiement = ModeDePaiementSelect;
                DetailsModeDePaiement dm = new DetailsModeDePaiement(modeDePaiement);
                DialogResult result = dm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string mot = modeDePaiement.Type;
                    if (string.IsNullOrWhiteSpace(mot))
                        MessageBox.Show("Erreur vous devez entrer une rubrique valide" +
                                        "Modification annulé ! ");
                    dao.UpdateModeDePaiement(modeDePaiement);
                }
                AfficherAllModeDePaiement();

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
                ModeDePaiement modeDePaiement = (ModeDePaiement) modeDePaiementBindingSource.Current;
                DialogResult result;

                result = MessageBox.Show(
                    string.Format("Êtes-vous sûr de vouloir supprimer la rubrique suivante : {0} {1} ", modeDePaiement.Type, "?")
                    , "Demande de confirmation"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dao.DeleteModeDePaiement(modeDePaiement);
                }
                AfficherAllModeDePaiement();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        /*****************************/
    }
}
