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

namespace IHMBackOffice.GestionAchatsVentes
{
    public partial class DetailsStatus : Form
    {
        private StatusDeCommande statusDeCommande;

        public DetailsStatus(StatusDeCommande statusDeCommande)
        {
            this.statusDeCommande = statusDeCommande;
            InitializeComponent();
        }
        
        private void resetButton_Click(object sender, EventArgs e)
        {
            nomTextBox.Text = string.Empty;

        }

        private void validerButton_Click(object sender, EventArgs e)
        {
            statusDeCommande.Nom = nomTextBox.Text;

        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void DetailsStatus_Load(object sender, EventArgs e)
        {
            if (statusDeCommande != null)
            {
                nomTextBox.Text = statusDeCommande.Nom;
            }
            else
            {
                nomTextBox.Text = string.Empty;

            }
        }
    }
}
