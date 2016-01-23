using System;
using System.Linq;
using SonyCatalog.Models;
using SonyCatalog.Data.Repositories;

namespace SonyCatalog.Services
{
    public class TvService : ITvService
    {
        private readonly IRepository<Tv> tvs;

        public TvService(IRepository<Tv> tvsRepo)
        {
            this.tvs = tvsRepo;
        }
        public IQueryable<Tv> GetAllTvs()
        {
            return this.tvs.All();
        }
    }
}
