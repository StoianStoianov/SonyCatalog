using System;
using System.Linq;
using SonyCatalog.Models;
using SonyCatalog.Data.Repositories;

namespace SonyCatalog.Services
{
    public class PhoneService : IPhoneService
    {
        private readonly IRepository<Phone> phones;

        public PhoneService(IRepository<Phone> phonesRepo)
        {
            this.phones = phonesRepo;
        }
        public IQueryable<Phone> GetAllPhones()
        {
            return this.phones.All();
        }
    }
}
