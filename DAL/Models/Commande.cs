using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public partial class Commande
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UtilisateurId { get; set; }
        public int ModeDePaiementId { get; set; }
        public int StatutDeCommandeId { get; set; }
        public DateTime Date { get; set; }

        public virtual Utilisateur Utilisateur { get; set; }
        public virtual ModeDePaiement ModeDePaiement { get; set; }
        public virtual StatusDeCommande StatutDeCommande { get; set; }
        public virtual ICollection<LigneDeCommande> LigneDeCommandes{ get; set; }



        
    }
}
