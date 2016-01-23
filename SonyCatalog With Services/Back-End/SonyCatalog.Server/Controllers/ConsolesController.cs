using SonyCatalog.Services;
using System.Web.Http;
using System.Linq;
using SonyCatalog.Server.Models;
using System.Web.Http.Cors;

namespace SonyCatalog.Server.Controllers
{
    public class ConsolesController:ApiController
    {
        private readonly IGameConsoleService consoles;

        public ConsolesController(IGameConsoleService consoleService)
        {
            this.consoles = consoleService;
        }
        [EnableCors("*", "*", "*")]
        public IHttpActionResult Get()
        {
            var response = this.consoles.GetAllConsoles().Select(console => new GameConsoleResponseModel()
            {
                BundleName = console.BundleName,
                Url = console.Url,
                Price = console.Price,
                ProductCategory = console.ProductCategory.CategoryName
            });

            return this.Ok(response);
        }
    }
}