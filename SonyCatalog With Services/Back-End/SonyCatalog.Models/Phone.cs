using System.ComponentModel.DataAnnotations;

namespace SonyCatalog.Models
{
    public class Phone:Product
    {   [Required]
        [MinLength(5)]     
        public string PhoneModel { get; set; }
       
    }
}
