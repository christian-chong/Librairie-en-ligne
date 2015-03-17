using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Models;

namespace IHMBackOffice.GestionOuvrages
{
    public partial class DetailsAuteur : Form
    {
        private Auteur auteur;
        public DetailsAuteur(Auteur auteur)
        {
            this.auteur = auteur;
            InitializeComponent();
        }

        private void DetailsAuteur_Load(object sender, EventArgs e)
        {
            if (auteur != null)
            {
                nomTextBox.Text = auteur.Nom;
                prenomTextBox.Text = auteur.Prenom;
            }
            else
            {
                nomTextBox.Text = string.Empty;
                prenomTextBox.Text = string.Empty;
            }
        }

        private void annulerButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void resetButton_Click_1(object sender, EventArgs e)
        {

            nomTextBox.Text = string.Empty;
            prenomTextBox.Text = string.Empty;

        }

        private void validerButton_Click_1(object sender, EventArgs e)
        {
            auteur.Nom = nomTextBox.Text;
            auteur.Prenom = prenomTextBox.Text;
            
        }
    }
}
