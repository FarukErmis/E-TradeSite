using System;
using System.ComponentModel.DataAnnotations;

namespace E_Trade.Model.Entity
{
    public partial class ProductComment
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string Comment { get; set; }

        public double? Rate { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string UserSurname { get; set; }

        public string UserAvatar { get; set; }

        public DateTime WritingDate { get; set; }

        public int? ThumbsUp { get; set; }

        public int? ThumbsDown { get; set; }

        public virtual Product Product { get; set; }
    }
}
