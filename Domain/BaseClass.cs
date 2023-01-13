using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class BaseClass
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public Guid CreatedBy { get; set; }
        //public BaseClass()
        //{
        //    Id = Guid.NewGuid(); 
        //}
    }
}