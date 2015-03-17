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
    public partial class DetailsExemplaireLivre : Form
    {
        private Dao dao;
        private Livre livre;
        private Auteur auteur;
        private Ecrire ecrire;
        private MotCle motCle;
        private Tagger tagger;
        private Rubrique rubrique;
        private Appartenir1 appartenir1;


        internal static int EditeurId;

        public DetailsExemplaireLivre()
        {
            dao = new Dao();
            InitializeComponent();
        }
        public DetailsExemplaireLivre(Livre livre)
        {
            dao = new Dao();
            this.livre = livre;
            InitializeComponent();
        }
        public MotCle MotCleSelect
        {
            get { return (MotCle)motCleComboBox.SelectedItem; }
        }
        public Rubrique RubriqueSelect
        {
            get { return (Rubrique)RubriqueComboBox.SelectedItem; }
        }
        public Auteur AuteurSelect
        {
            get { return (Auteur) auteurComboBox.SelectedItem; }
        }
        public Editeur EditeurSelect
        {
            get { return (Editeur)editeurComboBox.SelectedItem; }
        }
        public Exemplaire ExemplaireSelect
        {
            get { return (Exemplaire) exemplaireSelectBindingSource.Current; }
        }


        private void DetailsExemplaireLivre_Load(object sender, EventArgs e)
        {
            if (EditExemplaireLivre.EnCours == Modification.Modification){
                livreIdTextBox.Text = livre.Id.ToString();
                titreTextBox.Text = livre.Titre;
                sousTitreTextBox.Text = livre.SousTitre;
                resumeTextBox.Text = livre.Resume;
                themeTextBox.Text = livre.Theme;
                }

            if (EditExemplaireLivre.EnCours == Modification.Creation)
            { //
                livreIdTextBox.Text = string.Empty;
                titreTextBox.Text = string.Empty;
                sousTitreTextBox.Text = string.Empty;
                resumeTextBox.Text = string.Empty;
                themeTextBox.Text = string.Empty;
            }
            //dateTextBox.Text = string.Format("{0:D}", etudiant.DateInscription);
            auteurSelectBindingSource.DataSource     = dao.FindAuteurs(livre);
            auteurBindingSource.DataSource           = dao.AllAuteurs();
            exemplaireSelectBindingSource.DataSource = dao.FindExemplaire(EditExemplaireLivre.LivreId);
            editeurBindingSource.DataSource          = dao.AllEditeurs();
            editeurSelectBindingSource.DataSource = dao.FindEditeurs(livre);
            // exemplaireBindingSource.DataSource = dao.AllExemplaire();
            motCleBindingSource.DataSource = dao.AllMotCles();
            motCleSelectBindingSource.DataSource = dao.FindMotCles(livre);
            rubriqueBindingSource.DataSource = dao.AllRubriques();
            rubriqueSelectBindingSource.DataSource = dao.FindRubrique(livre);
        }
  

        private void FermerButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modifierLivreButton_Click(object sender, EventArgs e)
        {
            livreIdTextBox.Enabled = false;
            titreTextBox.Enabled = false;
            sousTitreTextBox.Enabled = false;
            resumeTextBox.Enabled = false;
            themeTextBox.Enabled = false;

            livre.Titre = titreTextBox.Text;
            livre.SousTitre = sousTitreTextBox.Text;
            livre.Resume = resumeTextBox.Text;
            livre.Theme = themeTextBox.Text;
           


            if (EditExemplaireLivre.EnCours == Modification.Modification)
            {
                if (string.IsNullOrWhiteSpace(livre.Titre) || string.IsNullOrWhiteSpace(livre.SousTitre))
                    return;
                dao.UpdateLivre(livre);
            }

            if (EditExemplaireLivre.EnCours == Modification.Creation)
            {
                if (string.IsNullOrWhiteSpace(livre.Titre) || string.IsNullOrWhiteSpace(livre.SousTitre))
                    return;
                dao.CreateLivre(livre);
                EditExemplaireLivre.LivreId = livre.Id;
            }

        }

        private void ajouterAuteurButton_Click(object sender, EventArgs e)
        {
            auteur = new Auteur();
            try
            {
                auteur.Nom = auteurNomTextBox.Text;
                auteur.Prenom = auteurPrenomTextBox.Text;
                if (string.IsNullOrWhiteSpace(auteur.Nom) || string.IsNullOrWhiteSpace(auteur.Prenom))
                    return;
                dao.CreateAuteur(auteur);
                auteurBindingSource.DataSource = dao.AllAuteurs();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ajouterAuteurSelectButton_Click(object sender, EventArgs e)
        {
            ecrire = new Ecrire();
            ecrire.AuteurId = AuteurSelect.Id;
            ecrire.LivreId = EditExemplaireLivre.LivreId;
            if (ecrire.LivreId != 0 && ecrire.AuteurId != 0)
            {
                dao.CreateEcrire(ecrire);
                auteurSelectBindingSource.DataSource = dao.FindAuteurs(livre);
            }

        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                auteur = (Auteur) auteurSelectBindingSource.Current;
                DialogResult result;

                result = MessageBox.Show(
                    string.Format("Êtes-vous sûr de vouloir supprimer l'auteur {0} {1} ", auteur.Prenom, auteur.Nom, "?")
                    , "Demande de confirmation"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ecrire = dao.FindEcrire(auteur.Id, EditExemplaireLivre.LivreId);
                    dao.DeleteEcrire(ecrire);
                }
                auteurSelectBindingSource.DataSource = dao.FindAuteurs(livre);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ajouterEditeurSelectButton_Click(object sender, EventArgs e)
        {
            try{
                Exemplaire exemplaire = new Exemplaire();
                EditeurId = EditeurSelect.Id;
                
                exemplaire.EditeurId = EditeurId;
                exemplaire.LivreId = EditExemplaireLivre.LivreId;
                exemplaire.ISBN = "";
                exemplaire.Pages = 0;
                exemplaire.DateEdition = new DateTime(1900, 01, 01);
                exemplaire.Stock = 0;
                exemplaire.Type = "0";
                exemplaire.URLimage = "";


                 if (exemplaire.EditeurId != 0 && exemplaire.LivreId !=0)
                    {
                        dao.CreateExemplaire(exemplaire);
                        editeurSelectBindingSource.DataSource = dao.FindEditeurs(livre);
                        exemplaireSelectBindingSource.DataSource = dao.FindExemplaire(EditExemplaireLivre.LivreId);
                    }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ajouterEditeur_Click(object sender, EventArgs e)
        {
            Editeur editeur = new Editeur();
            try
            {
                editeur.Nom = editeurNomTextBox.Text;
                
                if (string.IsNullOrWhiteSpace(editeur.Nom))
                    return;
                dao.CreateEditeur(editeur);
                editeurBindingSource.DataSource = dao.AllEditeurs();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void supprimerEditeurSelectButton_Click(object sender, EventArgs e)
        {
            try
            {
                Editeur editeur = (Editeur) editeurSelectBindingSource.Current;
                EditeurId = editeur.Id;
                DialogResult result;

                result = MessageBox.Show(
                    string.Format("Êtes-vous sûr de vouloir supprimer l'éditeur {0} {1} ", editeur.Nom, "?")
                    , "Demande de confirmation"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var exemplaire = dao.FindExemplaireSuppression(EditeurId, EditExemplaireLivre.LivreId);
                    dao.DeleteExemplaire(exemplaire);
                }
                editeurSelectBindingSource.DataSource = dao.FindEditeurs(livre);
                exemplaireSelectBindingSource.DataSource = dao.FindExemplaire(livre.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ajouteExemplaireButton_Click(object sender, EventArgs e)
        {
            /*
             * livreIdTextBox.Enabled = false;
            titreTextBox.Enabled = false;
            sousTitreTextBox.Enabled = false;
            resumeTextBox.Enabled = false;
            themeTextBox.Enabled = false;
            */

            Exemplaire exemplaire = ExemplaireSelect;

            exemplaire.ISBN = exemplaireIsbnTextBox.Text;
            exemplaire.Pages = int.Parse(exemplairePagesTextBox.Text);
            exemplaire.DateEdition = exemplaireDateTimePicker.Value;
            exemplaire.Stock = int.Parse(exemplaireStockTextBox.Text);
            exemplaire.Type = exemplaireTypeTextBox.Text;
            exemplaire.URLimage = exemplaireUrlTextBox.Text;

            if (string.IsNullOrWhiteSpace(exemplaire.ISBN) || string.IsNullOrWhiteSpace(exemplaire.Type))
                return;
            dao.UpdateExemplaire(exemplaire);
            exemplaireSelectBindingSource.DataSource = dao.FindExemplaire(EditExemplaireLivre.LivreId);
        }

        private void exemplaireDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Exemplaire exemplaire = ExemplaireSelect;
            EditeurId = exemplaire.EditeurId;
            exemplaireIdTextBox.Text = exemplaire.Id.ToString();
            exemplaireIsbnTextBox.Text = exemplaire.ISBN;
            exemplairePagesTextBox.Text = exemplaire.Pages.ToString();
            exemplaireStockTextBox.Text = exemplaire.Stock.ToString();
            exemplaireTypeTextBox.Text = exemplaire.Type;
            exemplaireUrlTextBox.Text = exemplaire.URLimage;
            exemplaireDateTimePicker.Value = exemplaire.DateEdition;

            //editeurDataGridView

        }

        private void ajouterMotCleButton_Click_1(object sender, EventArgs e)
        {
            motCle = new MotCle();
            try
            {
                motCle.Nom = motCleTextBox.Text;
                if (string.IsNullOrWhiteSpace(motCle.Nom))
                    return;
                dao.CreateMotCle(motCle);
                motCleBindingSource.DataSource = dao.AllMotCles();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        
        private void ajouterMotCleSelectButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                tagger = new Tagger();
                tagger.MotCleId = MotCleSelect.Id;
                tagger.LivreId = EditExemplaireLivre.LivreId;
                if (tagger.LivreId != 0 && tagger.MotCleId != 0)
                {
                    dao.CreateTagger(tagger);
                    motCleSelectBindingSource.DataSource = dao.FindMotCles(livre);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void supprimerMotCleButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                motCle = (MotCle)motCleSelectBindingSource.Current;
                DialogResult result;

                result = MessageBox.Show(
                    string.Format("Êtes-vous sûr de vouloir supprimer le mot clé {0} {1} ", motCle.Nom, "?")
                    , "Demande de confirmation"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    tagger = dao.FindTagger(motCle.Id, EditExemplaireLivre.LivreId);
                    dao.DeleteTagger(tagger);
                }
                motCleSelectBindingSource.DataSource = dao.FindMotCles(livre);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ajouterRubriqueButton_Click(object sender, EventArgs e)
        {
            rubrique = new Rubrique();
            try
            {
                rubrique.Nom = rubriqueTextBox.Text;
                if (string.IsNullOrWhiteSpace(rubrique.Nom))
                    return;
                dao.CreateRubrique(rubrique);
                rubriqueBindingSource.DataSource = dao.AllRubriques();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ajouterRubriqueSelectButton_Click(object sender, EventArgs e)
        {
            try
            {
                appartenir1 = new Appartenir1();
                appartenir1.RubriqueId = RubriqueSelect.Id;
                appartenir1.LivreId = EditExemplaireLivre.LivreId;
                if (appartenir1.LivreId != 0 && appartenir1.RubriqueId != 0)
                {
                    dao.CreateAppartenir1(appartenir1);
                    rubriqueSelectBindingSource.DataSource = dao.FindRubrique(livre);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void supprimerRubriqueButton_Click(object sender, EventArgs e)
        {
            try
            {
                rubrique = (Rubrique)rubriqueSelectBindingSource.Current;
                DialogResult result;

                result = MessageBox.Show(
                    string.Format("Êtes-vous sûr de vouloir supprimer le mot clé {0} {1} ", rubrique.Nom, "?")
                    , "Demande de confirmation"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    appartenir1 = dao.FindAppartenir1(rubrique.Id, EditExemplaireLivre.LivreId);
                    dao.DeleteAppartenir1(appartenir1);
                }
                rubriqueSelectBindingSource.DataSource = dao.FindRubrique(livre);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

  

    }
}
