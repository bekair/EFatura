﻿using EFatura.Core.EntityBase;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFatura.Entities.Domain
{
    [Table("PRODUCTS")]
    public class Product : BaseEntity
    {
        [Column("PRODUCT_ID")]
        public override long? ID { get => base.ID; set => base.ID = value; }

        [Column("PRODUCT_NAME")]
        [Required]
        [MaxLength(100)]
        public string ProductName { get; set; }

        [Column("CATEGORY_ID_FOREIGN")]
        [Required]
        public long? CategoryID { get; set; }

        //Navigation Property
        public Category ProductCategory { get; set; }

        [Column("UNIT_PRICE")]
        [Required]
        public double UnitPrice { get; set; }

        [Column("KDV_RATE")]
        [Required]
        public int KdvRate { get; set; }

        [Column("DISCOUNT_RATE")]
        [Required]
        public int DiscountRate { get; set; } = 0; //Default 'No Discount'

        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("STOCK_AMOUNT")]
        [Required]
        public int StockAmount { get; set; }

        [Column("CREATION_DATE")]
        [Required]
        public string CreationDate { get; set; } = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");

    }
}
