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
        [Key, Column(Order = 1)]
        public TypeTelecommunication TypeTelecom { get; set; }
    }
}
