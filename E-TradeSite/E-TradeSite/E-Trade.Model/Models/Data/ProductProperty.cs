namespace E_Trade.Model.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductProperty")]
    public partial class ProductProperty
    {
        public int Id { get; set; }

        public int? ProductId { get; set; }

        [StringLength(250)]
        public string VarKey { get; set; }

        [StringLength(250)]
        public string VarValue { get; set; }

        public int? CategoryId { get; set; }

        public virtual Product Product { get; set; }
    }
}
