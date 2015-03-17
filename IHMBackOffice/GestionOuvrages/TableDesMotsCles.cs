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
    public partial class TableDesMotsCles : Form
    {
        private Dao dao;
        public TableDesMotsCles()
        {
            dao = new Dao();
            InitializeComponent();
        }
    /**************************************************/
        public MotCle MotCleSelect
        {
            get { return (MotCle) motCleBindingSource.Current; }
        }

        private void AfficherAllMotCle()
        {
            motCleBindingSource.DataSource = dao.AllMotCles();
        }


        private void rechercherTextBox_TextChanged_1(object sender, EventArgs e)
        {
            string recherche = rechercherTextBox.Text;
            motCleBindingSource.DataSource = (string.IsNullOrWhiteSpace(recherche) ? dao.AllMotCles() : dao.RechercheMotCle(recherche));
        }
        private void TableDesMotsCles_Load(object sender, EventArgs e)
        {
            AfficherAllMotCle();
        }

        private void rafraichirButton_Click_1(object sender, EventArgs e)
        {
            AfficherAllMotCle();
            rechercherTextBox.Text = string.Empty;
        }

        private void fermerButton_Click_1(object sender, EventArgs e)
        {
            Close();

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MotCle motCle = new MotCle();
                DetailsMotCle da = new DetailsMotCle(motCle);
                DialogResult result = da.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string mot = motCle.Nom;
                    if (string.IsNullOrWhiteSpace(mot))
                        return;
                    dao.CreateMotCle(motCle);
                }
                AfficherAllMotCle();
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
                MotCle motCle = MotCleSelect;
                DetailsMotCle da = new DetailsMotCle(motCle);
                DialogResult result = da.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string mot = motCle.Nom;
                    if (string.IsNullOrWhiteSpace(mot))
                        MessageBox.Show("Erreur vous devez entrer un mot clé valide"+
                                        "Modification annulé ! ");
                    dao.UpdateMotCle(motCle);
                }
                AfficherAllMotCle();

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
                MotCle motCle = (MotCle)motCleBindingSource.Current;
                DialogResult result;

                result = MessageBox.Show(
                    string.Format("Êtes-vous sûr de vouloir supprimer le mot clé suivant :  {0} {1} ", motCle.Nom, "?")
                    , "Demande de confirmation"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dao.DeleteMotCle(motCle);
                }
                AfficherAllMotCle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

 

            /**************************************************/

    
    
    
    
    }
}
