
using System.Linq;
using SonyCatalog.Services;
using System.Web.Http;
using SonyCatalog.Server.Models;
using System.Web.Http.Cors;

namespace SonyCatalog.Server.Controllers
{
    public class TvsController:ApiController
    {
        private readonly ITvService tvs;

        public TvsController(ITvService tvService)
        {
            this.tvs = tvService;
        }

        [EnableCors("*", "*", "*")]
        public IHttpActionResult Get()
        {
            var response = this.tvs.GetAllTvs().Select(tv => new TvResponseModel()
            {
                TvModel = tv.TvModel,
                Url = tv.Url,
                Price = tv.Price,
                ProductCategory = tv.ProductCategory.CategoryName
            });

            return this.Ok(response);
        }
    }
}