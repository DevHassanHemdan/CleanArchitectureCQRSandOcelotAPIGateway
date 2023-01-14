using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Product : BaseClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }
        public Categories Categories { get; set; }
    }
}