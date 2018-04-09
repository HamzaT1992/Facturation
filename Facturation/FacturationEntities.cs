namespace Facturation
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class FacturationEntities : DbContext
    {
        public virtual DbSet<Eau> Eaus { get; set; }
        public virtual DbSet<TypeEau> TypeEaus { get; set; }
        public virtual DbSet<Electricite> Electricites { get; set; }
        public virtual DbSet<TypeElectricite> TypeElectricites { get; set; }
        public virtual DbSet<TeleCommunication> TeleCommunications { get; set; }
        public virtual DbSet<TypeTelecommunication> TypeTelecommunications { get; set; }

        public virtual DbSet<Etat> Etats { get; set; }
        public FacturationEntities()

        {
        }
    }

}