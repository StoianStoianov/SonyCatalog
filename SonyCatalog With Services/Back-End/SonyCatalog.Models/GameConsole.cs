using System.ComponentModel.DataAnnotations;

namespace SonyCatalog.Models
{
    public class GameConsole:Product
    {
        [Required]
        [MinLength(5)]
        public string BundleName { get; set; }
       
    }
}
