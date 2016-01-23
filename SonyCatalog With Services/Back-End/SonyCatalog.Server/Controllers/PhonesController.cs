using SonyCatalog.Services;
using System.Web.Http;
using System.Web.Http.Cors;
using SonyCatalog.Server.Models;
using System.Linq;



namespace SonyCatalog.Server.Controllers
{
    public class PhonesController:ApiController
    {
        private readonly IPhoneService phones;

        public PhonesController(IPhoneService phoneService)
        {
            this.phones = phoneService;
        }
        [EnableCors("*", "*", "*")]
        public IHttpActionResult Get()
        {            
            var response = phones.GetAllPhones().Select(phone => new PhoneResponseModel()
            {
                PhoneModel = phone.PhoneModel,
                Url = phone.Url,
                Price = phone.Price,
                ProductCategory = phone.ProductCategory.CategoryName
            });

            return this.Ok(response);
        }
    }
}