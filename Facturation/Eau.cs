using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Facturation
{
    public enum TypeEau
    {
        Domestique,
        [Description("Bouche D'Arrossage")] Bouche_D_Arrossage,
        [Description("Borne Foutaie")] Borne_Foutaie
    }

    public class Eau : Facture
    {
        public TypeEau Type { get; set; }
    }
}
