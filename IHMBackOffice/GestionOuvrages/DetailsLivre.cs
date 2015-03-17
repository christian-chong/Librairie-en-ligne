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
    public partial class DetailsLivre : Form
    {
        private Livre livre;

        public DetailsLivre(Livre livre)
        {
            this.livre = livre;
            InitializeComponent();
        }

        private void DetailsLivre_Load(object sender, EventArgs e)
        {
            if (livre != null)
            {
                titreTextBox.Text = livre.Titre;
                sousTitreTextBox.Text = livre.SousTitre;
                resumerTextBox.Text = livre.Resume;
                themeTextBox.Text = livre.Theme;
            }
            else
            {
                titreTextBox.Text = string.Empty;
                sousTitreTextBox.Text = string.Empty;
                resumerTextBox.Text = string.Empty;
                themeTextBox.Text = string.Empty;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            titreTextBox.Text = string.Empty;
            sousTitreTextBox.Text = string.Empty;
            resumerTextBox.Text = string.Empty;
            themeTextBox.Text = string.Empty;
        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void validerButton_Click(object sender, EventArgs e)
        {
            livre.Titre     = titreTextBox.Text;
            livre.SousTitre = sousTitreTextBox.Text;
            livre.Resume    = resumerTextBox.Text;
            livre.Theme     = themeTextBox.Text;
        }


    }
}
