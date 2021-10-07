using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace heARTshopAdminApplication.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "ARTWORK NAME")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name = "ARTWORK IMAGE")]
        public string Image { get; set; }
        [Required]
        [Display(Name = "ARTWORK DESCRIPTION")]
        public string ProductDescription { get; set; }
        [Required]
        [Display(Name = "ARTWORK ARTIST")]
        public string ProductArtist { get; set; }
        [Required]
        [Display(Name = "ARTWORK PRICE")]
        public int ProductPrice { get; set; }
        [Required]
        [Display(Name = "ARTWORK RATING")]
        public int Rating { get; set; }
    }
}
