using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SonyCatalog.Models;

namespace SonyCatalog.Data
{
    public class SonyCatalogDbContext : DbContext, ISonyCatalogDbContext
    {
        public SonyCatalogDbContext() : base("SonyCatalog")
        {

        }

        public virtual IDbSet<Product> Products { get; set; }

        public virtual IDbSet<GameConsole> Consoles { get; set; }

        public virtual IDbSet<Phone> Phones { get; set; }

        public virtual IDbSet<Tv> Tvs { get; set; }

        public virtual IDbSet<ProductCategory> ProductCategories { get; set; }
             
        public new  IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public static SonyCatalogDbContext Create()
        {
            return new SonyCatalogDbContext();
        }
    }
}
