using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class VaryantToProduct
    {
        public int Id { get; set; }
        public int ParentProductId { get; set; }
        [ForeignKey("OptionGroup")]
        public int OptionGroupId { get; set; }
        [ForeignKey("Options")]
        public int OptionId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public OptionGroup OptionGroup { get; set; }
        public Options Options { get; set; }
        public Product Product { get; set; }
    }
}
