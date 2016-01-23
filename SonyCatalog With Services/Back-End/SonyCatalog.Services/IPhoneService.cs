using SonyCatalog.Models;
using System.Linq;

namespace SonyCatalog.Services
{
    public interface IPhoneService
    {
        IQueryable<Phone> GetAllPhones();
    }
}
