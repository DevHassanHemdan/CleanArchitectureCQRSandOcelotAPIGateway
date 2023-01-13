using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public Guid CategoryId { get; set; }
        public Guid ProductTypeId { get; set; }
        public Guid ProductBrandId { get; set; }

    }
}
