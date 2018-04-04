using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Facturation
{
    public static class EnumStrValues
    {
        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
        public static List<string> GetEtatsString()
        {
            var strList = new List<string>();
            foreach (var etat in EnumStrValues.GetValues<Etat>())
            {
                switch (etat)
                {
                    case Etat.EnCours:
                        strList.Add("En Cours");
                        break;
                    case Etat.Provisoire:
                        strList.Add("Provisoire");
                        break;
                    case Etat.Resilic:
                        strList.Add("Resilic");
                        break;
                }
            }
            return strList;
        }
        public static List<string> GetTypeEauString()
        {
            var strList = new List<string>();
            foreach (var etat in EnumStrValues.GetValues<TypeEau>())
            {
                switch (etat)
                {
                    case TypeEau.Borne_Foutaie:
                        strList.Add("Borne Foutaie");
                        break;
                    case TypeEau.Bouche_D_Arrossage:
                        strList.Add("Bouche d'Arrossage");
                        break;
                    case TypeEau.Domestique:
                        strList.Add("Domestique");
                        break;
                }
            }
            return strList;
        }
    }
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
