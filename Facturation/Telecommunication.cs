using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation
{
    public class TeleCommunication : Facture
    {
        [Key, Column(Order = 6)]
        public TypeTelecommunication TypeTelecom { get; set; }
        [Key, Column(Order = 7)]
        [MaxLength (20)]
        public string MD { get; set; }
        public int Forfait { get; set; }
        public double Montant { get; set; }
    }
}
