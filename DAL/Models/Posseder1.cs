using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Posseder1
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UtilisateurId { get; set; }
        public int AdresseId { get; set; }

        public virtual Utilisateur Utilisateur { get; set; }
        public virtual Adresse Adresse { get; set; }
    }
}
