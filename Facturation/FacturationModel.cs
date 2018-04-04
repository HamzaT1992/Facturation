namespace Facturation
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class FacturationEntities : DbContext
    {
        public virtual DbSet<Eau> Eaus { get; set; }
        public virtual DbSet<Electricite> Electricites { get; set; }
        public virtual DbSet<Telecomunication> Telecomunications { get; set; }
        public FacturationEntities()
            :base("name=FacturationEntities")
        {
        }
    }

}