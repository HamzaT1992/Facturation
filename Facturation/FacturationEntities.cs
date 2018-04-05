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
    public class MyEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}