using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Livre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Titre { get; set; }
        public string SousTitre { get; set; }
        public string Resume { get; set; }
        [Required]
        public string Theme { get; set; }

        public virtual ICollection<Exemplaire> Exemplaires { get; set; }
        public virtual ICollection<Appartenir1> Appartenir1s { get; set; }
        public virtual ICollection<Tagger> Taggers { get; set; }
        public virtual ICollection<Ecrire> Ecrires { get; set; }
        public virtual ICollection<Aviser> Avisers{ get; set; }
    }
}
