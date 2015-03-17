using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public partial class Utilisateur
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime DateAdhesion { get; set; }
        public string MotDePasse { get; set; }
        public bool Activite { get; set; }
        public virtual ICollection<Aviser> Avisers { get; set; }
        public virtual ICollection<Commande> Commandes { get; set; }
        public virtual ICollection<Modification> Modifications { get; set; }
        public virtual ICollection<Posseder1> Posseder1s { get; set; }
        public virtual ICollection<Appartenir2> Appartenir2s { get; set; }
 

    }
}
