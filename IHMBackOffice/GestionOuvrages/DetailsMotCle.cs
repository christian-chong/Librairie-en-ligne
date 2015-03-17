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
    public partial class DetailsMotCle : Form
    {
        private MotCle motCle;
        public DetailsMotCle(MotCle motCle)
        {
            this.motCle = motCle;

            InitializeComponent();
        }



        private void validerButton_Click(object sender, EventArgs e)
        {
            motCle.Nom = nomTextBox.Text;

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            nomTextBox.Text = string.Empty;

        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void DetailsMotCle_Load(object sender, EventArgs e)
        {
            if (motCle != null)
            {
                nomTextBox.Text = motCle.Nom;
            }
            else
            {
                nomTextBox.Text = string.Empty;

            }
        }
    }
}
