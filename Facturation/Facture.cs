using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facturation
{
    public enum Etat
    {
        EnCours,
        Resilic,
        Provisoire
    }
    public class Facture
    {
        [Key,Column(Order = 1)]
        public int NPolice { get; set; }
        [Key,Column(Order = 2)]
        public string Adresse { get; set; }
        [Key,Column(Order = 3)]
        public int NCompteur { get; set; }
        [Key,Column(Order = 4)]
        public Etat Etat { get; set; }
        [Key,Column(Order = 5)]
        public DateTime Date { get; private set; }
        [Key,Column(Order = 6)]
        public string Tel { get; set; }
    }
}
