using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Panier
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ExemplaireId { get; set; }
        public int Quantite { get; set; }
        public string ISBN { get; set; }
        public string Titre { get; set; }
        public decimal PrixHT { get; set; }
        public decimal TVA{ get; set; }
        public decimal PrixTTC{ get; set; }

    }
}
