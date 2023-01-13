using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Commands
{
    public class DeleteProductCommand : IRequest<int>
    {
        public Guid ProductId { get; set; }
        public DeleteProductCommand(Guid productId)
        {
            ProductId = productId;
        }
    }
}
