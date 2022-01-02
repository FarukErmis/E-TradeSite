using E_Trade.Model.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public ProductImageExtension Extension { get; set; }
        public string DirectoryName { get; set; }
        public string Revision { get; set; }
        [Range(1,8)]
        public int SortOrder { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public string Attachment { get; set; }
        public Product Product { get; set; }
    }
}
