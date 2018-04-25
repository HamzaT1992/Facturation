using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation
{
    public class RelveeElec
    {
        [Key, Column(Order = 1)]
        public int Id { get; set; }
        [Key, Column(Order = 2)]
        public DateTime Annee { get; set; }
        [Key, Column(Order = 3)]
        public int Trimestre { get; set; }
        public int NIndex { get; set; }
        public int PIndex { get; set; }
        public double NPayer { get; set; }
        public Electricite Elec { get; set; }
    }
}
