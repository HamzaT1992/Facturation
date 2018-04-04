using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation
{
    public enum TypeElectricite
    {
        MT,
        BT,
        Pompe,
        Domestique,
        Borue
    }
    public class Electricite : Facture
    {
        public TypeElectricite Type { get; set; }
    }
}
