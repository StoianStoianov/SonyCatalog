namespace SonyCatalog.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ProductCategory
    {
        private ICollection<Product> products;

        public ProductCategory()
        {
            this.products = new HashSet<Product>();
        }
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products
        {
            get { return this.products; }
            set { this.products = value; }
        }

    }
}
