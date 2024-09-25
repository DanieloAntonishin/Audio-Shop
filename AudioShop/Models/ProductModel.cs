using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AudioShop.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Uncorrect Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Uncorrect Category")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Uncorrect Price")]
        [Range(0.0, 10000000.0)]
        public double Price { get; set; }
        [Required(ErrorMessage = "Uncorrect Count")]
        [Range(0,10000)]
        public int Count { get; set; }
        [Required(ErrorMessage = "Uncorrect Discount setting")]
        public bool Discount { get; set; }
        [Required(ErrorMessage = "Uncorrect Image setting")]
        public string Image { get; set; }
        public string About { get; set; } = "";
    }
}
