namespace E_Trade.Model.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductComment")]
    public partial class ProductComment
    {
        public int Id { get; set; }

        public int? ProductId { get; set; }

        public string Comment { get; set; }

        public double? Rate { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string UserSurname { get; set; }

        public string UserAvatar { get; set; }

        public string WritingDate { get; set; }

        public string WritingTime { get; set; }

        public int? ThumbsUp { get; set; }

        public int? ThumbsDown { get; set; }

        public virtual Product Product { get; set; }
    }
}
