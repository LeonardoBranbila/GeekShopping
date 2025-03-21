﻿using GeekShopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model
{
    [Table("Product")]
    public class Product : BaseEntity

    {
        [Column("name")]
        [Required]
        [StringLength(150)]
        public string Name{ get; set; }

        [Column("price")]
        [Required]
        [Range(1, 10000)]
        public decimal Price { get; set; }

        [Column("description")]
        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Column("categoryName")]
        [StringLength(50)]
        public string CategoryName { get; set; }

        [Column("imgURL")]
        [StringLength(300)]
        public string imgURL { get; set; }
    }
}
