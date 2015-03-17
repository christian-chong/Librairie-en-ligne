using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class RechercheMotCle
    {
        public string MotCle { get; set; }
        public List<Exemplaire> MaListExemplaires { get; set; }
    }
}
