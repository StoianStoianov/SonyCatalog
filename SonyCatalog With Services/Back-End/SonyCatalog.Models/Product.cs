using System;
using System.ComponentModel.DataAnnotations;

namespace SonyCatalog.Models
{
    public abstract class Product
    {
        public int Id { get; set; }
        //[Required]
        //[MinLength(10)]
        public string Url { get; set; }
        [Required]
        [Range(0.0, Double.MaxValue)]
        public double Price { get; set; }
        [Required]
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
