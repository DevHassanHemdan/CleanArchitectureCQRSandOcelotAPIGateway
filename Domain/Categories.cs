namespace Domain
{
    public class Categories : BaseClass
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}