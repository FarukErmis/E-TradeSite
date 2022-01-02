﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class ProductPrice
    {
        public int Id { get; set; }
        [Range(0,10000)]
        public float Value { get; set; }
        [Range(2, 5)]
        public int Type { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
