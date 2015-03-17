using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Ecrire
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int LivreId { get; set; }
        public int AuteurId { get; set; }
        public virtual Livre Livre { get; set; }
        public virtual Auteur Auteur { get; set; } 
    }
}
