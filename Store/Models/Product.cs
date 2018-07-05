using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Store.Models
{
    public enum CatagoriesName
    {
        Accessories, Footwear, Jeans, Outerwear, Pants, Shirsts, [Display(Name = "T-Shirt")] TShirts
    }
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        
        [Display(Name ="Product Title")]
        public string Title { get; set; }

        
        [Display(Name ="Product Catagory")]
        public CatagoriesName ProductCatagory { get; set; }

        [Display(Name ="Product Price")]
        public decimal Price { get; set; }

        
        [Display(Name ="Colour")]
        public string Colour { get; set; }

        [Required]
        public string mainImage { get; set; }

        public string Description { get; set; }

        public ICollection<Order> Order { get; set; }
    }
}
