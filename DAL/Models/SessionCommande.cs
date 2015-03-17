using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public static class SessionCommande
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public static int Id { get; set; }
        public static Utilisateur currentUtilisateur { get; set; }
        public static ModeDePaiement currentModeDePaiement { get; set; }
        public static StatusDeCommande currentStatusDeCommande { get; set; }
        public static Livre currentLivre { get; set; }
        public static Exemplaire currentExemplaire { get; set; }
        public static Prix currentPrix { get; set; }

        public static List<LigneDeCommande> mesLignesDeCommandes { get; set; }
        public static Commande maCommande { get; set; }
        public static LigneDeCommande maLigneDeCommande { get; set; }
        public static RechercheMotCle maRechercheMotCle { get; set; }



    }
}
