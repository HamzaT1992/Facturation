using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation
{
    public enum TypeTelecomunication
    {
        Fix,
        GSM,
        Internet
    }
    public class Telecomunication : Facture
    {
        public TypeTelecomunication Type { get; set; }
    }
}
