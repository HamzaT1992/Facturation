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
        Bouche_D_Arrossage,
        Borne_Foutaie
    }

    public class Eau : Facture
    {
        public TypeEau Type = TypeEau.Bouche_D_Arrossage;
    }
}
