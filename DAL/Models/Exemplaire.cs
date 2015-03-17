using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Exemplaire
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int LivreId { get; set; }
        public int EditeurId { get; set; }
        public string ISBN { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int Stock { get; set; }
        public int Pages { get; set; }
        public string URLimage { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        [Display(Name = "Date de Publication")]
        public DateTime DateEdition { get; set; }

        public virtual Livre Livre { get; set; }
        public virtual Editeur Editeur { get; set; }
        public virtual ICollection<LigneDeCommande> LigneDeCommandes { get; set; }
        public virtual ICollection<Couter> Couters { get; set; }


    }
}
