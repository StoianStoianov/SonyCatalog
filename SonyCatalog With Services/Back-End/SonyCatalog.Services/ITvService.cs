using SonyCatalog.Models;
using System.Linq;

namespace SonyCatalog.Services
{
    public interface ITvService
    {
        IQueryable<Tv> GetAllTvs();
    }
}
