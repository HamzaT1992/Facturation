//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Facturation
{
    using System;
    using System.Collections.Generic;
    
    public partial class RelveeEau
    {
        public int Id { get; set; }
        public short Annee { get; set; }
        public int Trimestre { get; set; }
        public int NIndex { get; set; }
        public int PIndex { get; set; }
        public double NPayer { get; set; }
        public string Eau_NPolice { get; set; }
        public string Eau_Adresse { get; set; }
        public Nullable<System.DateTime> Eau_Date { get; set; }
        public string Eau_Tel { get; set; }
        public string Eau_NCompteur { get; set; }
        public string Eau_Reference { get; set; }
        public string Rapport { get; set; }
    
        public virtual Eau Eau { get; set; }
    }
}
