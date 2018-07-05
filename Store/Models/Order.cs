using Store.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Store.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        [Range(0,500)]
        public int Quantity { get; set; }

        [Required]
        [Display(Name ="Order Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MMM/yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public System.DateTime OrderDate { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [Display(Name ="Current Address")]
        public string Address { get; set; }

        public decimal Total { get; set; }

        public User User { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}