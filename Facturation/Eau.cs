using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation
{
    public class Eau : Facture
    {
        public short Annee { get; set; }
        [Key, Column(Order = 6)]
        public int NCompteur { get; set; }
        [Key, Column(Order = 7)]
        public TypeEau TypeEau { get; set; }
        [Key, Column(Order = 8)]
        [MaxLength ( 15)]
        public string Reference { get; set; }
    }
}
