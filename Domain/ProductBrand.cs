namespace Domain
{
    public class ProductBrand : BaseClass
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}