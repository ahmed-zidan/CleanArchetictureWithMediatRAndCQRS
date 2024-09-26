using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Blogs.Commands.Delete
{
    public record DeleteCommand(int BlogId):IRequest<bool>;
    
}
