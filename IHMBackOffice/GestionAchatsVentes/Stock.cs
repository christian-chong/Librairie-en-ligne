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
    public partial class Stock : Form
    {
        private Exemplaire exemplaire;
        private Dao dao;

        public Stock(Exemplaire exemplaire)
        {
            this.exemplaire = exemplaire;
            dao = new Dao();
            InitializeComponent();
        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void validerButton_Click(object sender, EventArgs e)
        {
            exemplaire.Stock = int.Parse(nouveauStockTextBox.Text);
            dao.UpdateExemplaire(exemplaire);
            stockActuelTextBox.Text = exemplaire.Stock.ToString();
            Close();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            stockActuelTextBox.Text = exemplaire.Stock.ToString();
        }

    }
}
