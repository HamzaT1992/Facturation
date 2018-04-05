namespace Facturation
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class FacturationEntities : DbContext
    {
        public FacturationEntities()
            : base("name=FacturationEntities")
        {
        }
    }

}