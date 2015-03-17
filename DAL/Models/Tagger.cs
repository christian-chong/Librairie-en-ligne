using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Tagger
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int LivreId { get; set; }
        public int MotCleId { get; set; }

        public virtual Livre Livre { get; set; }
        public virtual MotCle MotCle { get; set; }

    }
}
