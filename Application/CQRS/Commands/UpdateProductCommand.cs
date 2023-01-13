using Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Commands
{
    public class UpdateProductCommand : IRequest<ProductDTO>
    {
        public ProductDTO _product { get; set; }
        public UpdateProductCommand(ProductDTO product)
        {
            _product = product;
        }
    }
}
