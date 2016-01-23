using System;
using System.Linq;
using SonyCatalog.Models;
using SonyCatalog.Data.Repositories;

namespace SonyCatalog.Services
{
    public class GameConsoleService : IGameConsoleService
    {
        private readonly IRepository<GameConsole> consoles;

        public GameConsoleService(IRepository<GameConsole> consolesRepo)
        {
            this.consoles = consolesRepo;
        }
        public IQueryable<GameConsole> GetAllConsoles()
        {
            return this.consoles.All();
        }
    }
}
