using Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Commands
{
    public class AddCategoryCommand : IRequest<CategoriesDTO>
    {
        public CategoriesDTO _categoryDTO { get; set; }
        public AddCategoryCommand(CategoriesDTO categoryDTO)
        {
            _categoryDTO = categoryDTO;
        }
    }
}
