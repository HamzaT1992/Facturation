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
    
    public partial class TeleCommunication
    {
        public int NPolice { get; set; }
        public string Adresse { get; set; }
        public System.DateTime Date { get; set; }
        public string Tel { get; set; }
        public string MD { get; set; }
        public int Forfait { get; set; }
        public double Montant { get; set; }
        public Nullable<int> Etat_id { get; set; }
        public Nullable<int> TypeTelecom_id { get; set; }
    
        public virtual Etat Etat { get; set; }
        public virtual TypeTelecommunication TypeTelecommunication { get; set; }
    }
}
