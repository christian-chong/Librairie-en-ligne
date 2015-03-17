using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public partial class Auteur
    {
        public string PrenomNom
        {
            get { return Prenom + " " + Nom; }
        }
    }
    public partial class Utilisateur
    {
        public string PrenomNom
        {
            get { return Prenom + " " + Nom; }
        }
    }

}
