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
    public partial class AjouterCommande : Form
    {
        private Dao dao;
        private Commande newCommande;
        private LigneDeCommande maLignesDeCommandes;

        public static Utilisateur CurrentUtilisateur;
        public static ModeDePaiement CurrentModeDePaiement;
        public static StatusDeCommande CurrentStatusDeCommande;
        public static Livre CurrentLivre;
        public static Exemplaire CurrentExemplaire;
        public static Panier CurrentPanier;
        public List<Panier> ListingPaniers;
        public List<LigneDeCommande> mesLignesDeCommandes;

        public AjouterCommande()
        {
            dao = new Dao();
            InitializeComponent();
        }
        public Panier PanierSelect
        {
            get { return (Panier) panierBindingSource.Current; }
        }
        public Exemplaire ExemplaireSelect
        {
            get { return (Exemplaire) exemplaireSelectBindingSource.Current; }
        }
        
        public Livre LivreSelect
        {
            get { return (Livre)livreBindingSource.Current; }
        }
        public Utilisateur UtilisateurSelect
        {
            get { return (Utilisateur)utilisateurBindingSource.Current; }
        }
        public ModeDePaiement ModeDePaiementSelect{
            get { return (ModeDePaiement)modeDePaiementBindingSource.Current; }
        }
        public StatusDeCommande StatusDeCommandeSelect{
            get { return (StatusDeCommande)statusDeCommandeBindingSource.Current; }
        }


        private void TableDesCommandes_Load(object sender, EventArgs e)
        {
            utilisateurBindingSource.DataSource = dao.AllUtilisateurs();
            modeDePaiementBindingSource.DataSource = dao.AllModeDePaiements();
            statusDeCommandeBindingSource.DataSource = dao.AllStatusDeCommandes();
            commandeBindingSource.DataSource = dao.AllCommandes();
            livreBindingSource.DataSource = dao.AllLivres();
            CurrentLivre = dao.AllLivres().First();
            exemplaireSelectBindingSource.DataSource = dao.FindExemplaire(CurrentLivre.Id);
        }

        private void UtilisateurSelectButton_Click(object sender, EventArgs e)
        {
            CurrentUtilisateur = UtilisateurSelect;
            utilisateurComboBox.Enabled = false;
        }

        private void modeDePaiementSelectButton_Click(object sender, EventArgs e)
        {
            CurrentModeDePaiement = ModeDePaiementSelect;
            modeDePaiementComboBox.Enabled = false;
        }


        private void statusDeCommandeSelectButton_Click(object sender, EventArgs e)
        {
            CurrentStatusDeCommande = StatusDeCommandeSelect;
            statusDeCommandeComboBox.Enabled = false;
        }



        private void fermerButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            modeDePaiementComboBox.Enabled = true;
            statusDeCommandeComboBox.Enabled = true;
            utilisateurComboBox.Enabled = true;
        }

        private void liveSelectButton_Click(object sender, EventArgs e)
        {
            CurrentLivre = LivreSelect;
            exemplaireSelectBindingSource.DataSource = dao.FindExemplaire(CurrentLivre.Id);
        }

        private void livreDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            CurrentLivre = LivreSelect;
            exemplaireSelectBindingSource.DataSource = dao.FindExemplaire(CurrentLivre.Id);
        }

        private void exemplaireSelectButton_Click(object sender, EventArgs e)
        {
            CurrentExemplaire = ExemplaireSelect;
            prixHTTextBox.Text = dao.FindPrixes(CurrentExemplaire.Id).Last().PrixHT.ToString();
            tvaTextBox.Text = dao.FindPrixes(CurrentExemplaire.Id).Last().TVA.ToString();

            //              public List<Prix> FindPrixes(int eId)


        }

        private void tableDesPrixButton_Click(object sender, EventArgs e)
        {
            var tdp = new DetailsPrix(CurrentLivre.Id, CurrentExemplaire.Id);
            tdp.Visible = true;

        }

        private void creerCommandeButton_Click(object sender, EventArgs e)
        {
            try
            {
                newCommande = new Commande();
                newCommande.Date = DateTime.Now;
                newCommande.UtilisateurId = CurrentUtilisateur.Id;
                newCommande.ModeDePaiementId = CurrentModeDePaiement.Id;
                newCommande.StatutDeCommandeId = CurrentStatusDeCommande.Id;
                dao.CreateCommande(newCommande);
                //commandeBindingSource.DataSource = dao.AllCommandes();
                dateTimePicker.Enabled = false;

            }
            catch (Exception ex)
            {
                //Ce message sera affiche si un probleme survient lors du chargement de la liste des mots clés
                throw new Exception("Un problème est survenu pour la raison suivante \n" + ex.Message);
            }
        }

        private void ajouterPanierButton_Click(object sender, EventArgs e)
        {
            try
            {

                LigneDeCommande ldc = new LigneDeCommande();
                ldc.CommandeId = newCommande.Id;
                ldc.ExemplaireId = CurrentExemplaire.Id;
               // MessageBox.Show(string.Format("Commande id {0}, Exemplaire id {1}", ldc.CommandeId, ldc.ExemplaireId));

                ldc.Quantite = int.Parse(quantiteTextBox.Text);
                dao.CreateLigneDeCommande(ldc);

                mesLignesDeCommandes = dao.FindLignesDeCommande(newCommande);
                dao.UpdateLigneDeCommandeDataSource(mesLignesDeCommandes, panierGridView);
      
            }
            catch (Exception ex)
            {
                //Ce message sera affiche si un probleme survient lors du chargement de la liste des mots clés
                throw new Exception("Un problème est survenu pour la raison suivante \n" + ex.Message);
            }
        }

        private void supprimerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Attention : Veuillez selectionner l'exemplaire a supprimer dans la table des exemplaires");
                
                CurrentExemplaire = dao.FindExemplaireId(CurrentExemplaire.Id);
                maLignesDeCommandes = dao.FindLignesDeCommandeSuppression(newCommande, CurrentExemplaire);
                // MessageBox.Show(string.Format("Commande id {0}, Exemplaire id {1}", ldc.CommandeId, ldc.ExemplaireId));

                dao.DeleteLigneDeCommande(maLignesDeCommandes);

                mesLignesDeCommandes = dao.FindLignesDeCommande(newCommande);
                dao.UpdateLigneDeCommandeDataSource(mesLignesDeCommandes, panierGridView);

            }
            catch (Exception ex)
            {
                //Ce message sera affiche si un probleme survient lors du chargement de la liste des mots clés
                throw new Exception("Un problème est survenu pour la raison suivante \n" + ex.Message);
            }
        }

        private void exemplaireSelectDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            CurrentExemplaire = ExemplaireSelect;
            
        }



    }
}
