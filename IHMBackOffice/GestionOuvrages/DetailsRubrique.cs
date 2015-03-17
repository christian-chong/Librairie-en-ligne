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
    public partial class DetailsRubrique : Form
    {
        private Rubrique rubrique;
        public DetailsRubrique(Rubrique rubrique)
        {
            this.rubrique = rubrique;
            InitializeComponent();
        }
        
      
        private void validerButton_Click(object sender, EventArgs e)
        {
            rubrique.Nom = nomTextBox.Text;

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            nomTextBox.Text = string.Empty;

        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void DetailsRubrique_Load(object sender, EventArgs e)
        {
            if (rubrique != null)
            {
                nomTextBox.Text = rubrique.Nom;
            }
            else
            {
                nomTextBox.Text = string.Empty;

            }
        }
    }
}
