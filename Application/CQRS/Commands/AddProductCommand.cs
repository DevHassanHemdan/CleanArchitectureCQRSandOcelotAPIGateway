using Application.DTOs;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Commands
{
    public class AddProductCommand : IRequest<ProductDTO>
    {
        public ProductDTO _product { get; set; }
        public AddProductCommand(ProductDTO product)
        {
            _product = product;
        }
    }
}
