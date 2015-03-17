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
    public partial class DetailsModeDePaiement : Form
    {
        private ModeDePaiement modeDePaiement;
        public DetailsModeDePaiement(ModeDePaiement modeDePaiement)
        {
            this.modeDePaiement = modeDePaiement;
            InitializeComponent();
        }
  
        private void DetailsModeDePaiement_Load(object sender, EventArgs e)
        {
            if (modeDePaiement != null)
            {
                nomTextBox.Text = modeDePaiement.Type;
            }
            else
            {
                nomTextBox.Text = string.Empty;

            }

        }

        private void resetButton_Click_1(object sender, EventArgs e)
        {
            nomTextBox.Text = string.Empty;

        }

        private void validerButton_Click_1(object sender, EventArgs e)
        {
            modeDePaiement.Type = nomTextBox.Text;

        }

        private void annulerButton_Click_1(object sender, EventArgs e)
        {
            Close();

        }

    }
}
