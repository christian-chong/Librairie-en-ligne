using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class LigneDeCommande
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ExemplaireId { get; set; }
        public int CommandeId { get; set; }
        [Required]
        public int Quantite { get; set; }

        public virtual Exemplaire Exemplaire { get; set; }
        public virtual Commande Commande { get; set; }
    }
}
