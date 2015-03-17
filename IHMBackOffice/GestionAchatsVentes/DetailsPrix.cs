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
    public partial class DetailsPrix : Form
    {
        private Prix prix;
        private Dao dao;
        private int livreId;
        private int exemplaireId;
        public DetailsPrix(int livreId, int exemplaireId)
        {
            this.livreId = livreId;
            this.exemplaireId = exemplaireId;

            dao=new Dao();
            InitializeComponent();

        }

        public Prix PrixSelect
        {
            get { return (Prix) prixBindingSource.Current; }
        }

        
        private void TablePrix_Load(object sender, EventArgs e)
        {
            livreIdTextBox.Text =  livreId.ToString();
             //TableExemplairePrix.ExemplaireId;
            exemplaireIdTextBox.Text = exemplaireId.ToString();
            prixBindingSource.DataSource = dao.FindPrixes(exemplaireId);

        }

        private void entrerButton_Click(object sender, EventArgs e)
        {
            prix = new Prix();
            prix.Date = dateDateTimePicker.Value;
            prix.PrixHT = decimal.Parse(prixHtTextBox.Text);
            prix.TVA = decimal.Parse(tvaTextBox.Text);
            dao.CreatePrix(prix);
            

            Couter couter = new Couter();
            couter.ExemplaireId = exemplaireId;
            couter.PrixId = prix.Id;
            dao.CreateCouter(couter);
            prixBindingSource.DataSource = dao.FindPrixes(exemplaireId);

        }

        private void modifierButton_Click(object sender, EventArgs e)
        {
            prix = PrixSelect;
            prix.Date = dateDateTimePicker.Value;
            prix.PrixHT = decimal.Parse(prixHtTextBox.Text);
            prix.TVA = decimal.Parse(tvaTextBox.Text);
            dao.UpdatePrix(prix);

            Couter couter = dao.FindCouter(exemplaireId, prix.Id);
            dao.UpdateCouter(couter);
            MessageBox.Show("Vous venez de rentrer un prix");
            prixBindingSource.DataSource = dao.FindPrixes(exemplaireId);

        }

        private void prixDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fermerButton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
