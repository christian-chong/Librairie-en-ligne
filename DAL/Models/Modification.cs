using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Modification
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UtilisateurId { get; set; }
        public DateTime Date { get; set; }
        public string Nom { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }

    }

}
