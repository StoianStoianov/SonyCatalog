﻿using System;
using System.Linq;
using System.Data.Entity;

namespace SonyCatalog.Data.Repositories
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity:class
    {
        private readonly ISonyCatalogDbContext data;

        private readonly IDbSet<TEntity> set;

        public EfRepository(ISonyCatalogDbContext data)
        {
            this.data = data;
            this.set = data.Set<TEntity>();
        }
       
        public void Add(TEntity entity)
        {
            this.ChangeState(entity, EntityState.Added);
        }

        public IQueryable<TEntity> All()
        {
            return this.set;
        }

        public TEntity FindById(int id)
        {
            return this.set.Find(id);
        }

        public void Remove(TEntity entity)
        {
            this.ChangeState(entity, EntityState.Deleted);
        }

        public void SaveChanges()
        {
            this.data.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            this.ChangeState(entity, EntityState.Modified);
        }

        private void ChangeState(TEntity entity, EntityState state)
        {
            var dbEntry = this.data.Entry(entity);
            dbEntry.State = state;
        }
    }
}
