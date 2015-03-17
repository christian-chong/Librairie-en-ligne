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

enum Modification { Creation, Modification, Suppression};

namespace IHMBackOffice.GestionOuvrages
{
    public partial class EditExemplaireLivre : Form
    {
         private Dao dao;
         internal static int LivreId;

         internal static Modification EnCours;

        public EditExemplaireLivre()
        {
            dao = new Dao();
            InitializeComponent();
        }



        private void fermerButton_Click(object sender, EventArgs e)
        {
            Close();
        }
               

        public Livre LivreSelect
        {
            get { return (Livre)livreBindingSource.Current; }
        }

        private void AfficherAllLivres()
        {
            livreBindingSource.DataSource = dao.AllLivres();
        }

        private void rechercherTextBox_TextChanged(object sender, EventArgs e)
        {
            string recherche = rechercherTextBox.Text;
            livreBindingSource.DataSource = (string.IsNullOrWhiteSpace(recherche) ? dao.AllLivres() : dao.RechercheLivres(recherche));
        }

        private void EditExemplaireLivre_Load(object sender, EventArgs e)
        {
            AfficherAllLivres();
        }

        private void rafraichirButton_Click(object sender, EventArgs e)
        {
            AfficherAllLivres();
        }

        private void détailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                EnCours = Modification.Modification;
                Livre livre = LivreSelect;
                LivreId = livre.Id;

                DetailsExemplaireLivre del = new DetailsExemplaireLivre(livre);
                DialogResult result = del.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                EnCours = Modification.Creation;

                Livre livre = new Livre();
                LivreId = livre.Id;
                DetailsExemplaireLivre del = new DetailsExemplaireLivre(livre);
                DialogResult result = del.ShowDialog();

               /* if (result == DialogResult.OK)
                {
                    string nom = etudiant.Nom;
                    string prenom = etudiant.Prenom;
                    if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom))
                        return;
                    dao.Create(etudiant);
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




      
    }
}
