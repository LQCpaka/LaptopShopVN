﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LaptopShopVN.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { set; get; }
        public string ImageUrl { get; set; }
    }
}
