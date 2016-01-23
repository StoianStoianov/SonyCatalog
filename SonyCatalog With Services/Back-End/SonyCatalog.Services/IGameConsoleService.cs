using SonyCatalog.Models;
using System.Linq;

namespace SonyCatalog.Services
{
    public interface IGameConsoleService
    {
        IQueryable<GameConsole> GetAllConsoles();
    }
}
