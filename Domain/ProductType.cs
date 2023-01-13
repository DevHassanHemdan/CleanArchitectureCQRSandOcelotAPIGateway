namespace Domain
{
    public class ProductType : BaseClass
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}