using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation
{
    public class RelveeEau
    {
        [Key, Column(Order = 1)]
        public Eau eau { get; set; }
        [Key, Column(Order = 2)]
        public DateTime Annee { get; set; }
        [Key, Column(Order = 3)]
        public int trimestre { get; set; }
        public int nIndex { get; set; }
        public int pIndex { get; set; }
        public double nPayer { get; set; }

    }
}
