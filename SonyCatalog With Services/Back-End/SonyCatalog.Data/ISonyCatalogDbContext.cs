using SonyCatalog.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace SonyCatalog.Data
{
    public interface ISonyCatalogDbContext
    {
        IDbSet<Product> Products { get; set; }

        IDbSet<GameConsole> Consoles { get; set; }

        IDbSet<Phone> Phones { get; set; }

        IDbSet<Tv> Tvs { get; set; }

        IDbSet<ProductCategory> ProductCategories { get; set; }

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();

    }
}
