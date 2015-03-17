using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Couter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PrixId { get; set; }
        public int ExemplaireId { get; set; }

        public virtual Prix Prixes { get; set; }
        public virtual Exemplaire Exemplaires { get; set; } 

    }
}
