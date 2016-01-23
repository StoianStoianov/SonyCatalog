using System.ComponentModel.DataAnnotations;

namespace SonyCatalog.Models
{
    public class Tv:Product
    {
        [Required]
        [MinLength(5)]
        public string TvModel { get; set; }
    }
       
}
