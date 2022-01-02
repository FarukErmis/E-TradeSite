namespace E_Trade.Model.Entity
{
    public partial class ProductImage
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string Image { get; set; }

        public virtual Product Product { get; set; }
    }
}
