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
    public partial class TableExemplairePrix : Form
    {
        private Dao dao;
        public static int LivreId1;
        public static int ExemplaireId;
        public static string ExemplaireISBN;

        public TableExemplairePrix()
        {
            dao = new Dao();
            InitializeComponent();
        }

/****************************************/
        public void AfficherExemplaires()
        {
            exemplaireBindingSource.DataSource = dao.FindExemplaire(LivreId1);
        }
        
        public void AfficherLivres()
         {
             livreBindingSource.DataSource = dao.AllLivres();
         }
         public Exemplaire ExemplaireSelect
         {
             get { return (Exemplaire)exemplaireBindingSource.Current; }
         }
        public Livre LivreSelect
        {
            get { return (Livre)livreBindingSource.Current; }
        }
        private void rechercherTextBox_TextChanged(object sender, EventArgs e)
        {
           string recherche = rechercherTextBox.Text;
            livreBindingSource.DataSource = (string.IsNullOrWhiteSpace(recherche) ? dao.AllLivres() : dao.RechercheLivres(recherche));
        }
       
        private void rafraichirButton_Click(object sender, EventArgs e)
        {
            AfficherLivres();
            AfficherExemplaires();
        }

        private void fermerButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void TableExemplairePrix_Load(object sender, EventArgs e)
        {
            AfficherLivres();
            LivreId1 = LivreSelect.Id;
            ExemplaireId = ExemplaireSelect.Id;
            ExemplaireISBN = ExemplaireSelect.ISBN;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (LivreSelect != null)
            {
                exemplaireBindingSource.DataSource = dao.FindExemplaire(LivreSelect.Id);
                LivreId1 = LivreSelect.Id;
            }
            
        }

        private void exemplaireDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            ExemplaireId = ExemplaireSelect.Id;
            ExemplaireISBN = ExemplaireSelect.ISBN;
            
        }
        private void afficherLesPrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tdp = new DetailsPrix(LivreId1, ExemplaireId);
            tdp.Visible = true; 
        
        }

        private void modifierLeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var stock = new DetailsStock(ExemplaireSelect);
            stock.Visible = true; 
        }


/***********
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
**********************/
    }
}
