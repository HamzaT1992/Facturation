using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation
{
    public class Facture
    {
        [Key, Column(Order = 1)]
        public int NPolice { get; set; }
        [Key, Column(Order = 2)]
        [MaxLength(100)]
        public string Adresse { get; set; }
        [Key, Column(Order = 3)]
        public Etat Etat { get; set; }
        [Key, Column(Order = 4)]
        public DateTime Date { get; private set; }
        [Key, Column(Order = 5)]
        [MaxLength (20)]
        public string Tel { get; set; }
    }
}
