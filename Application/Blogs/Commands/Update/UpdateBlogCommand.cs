using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Blogs.Commands.Update
{
    public record UpdateBlogCommand(UpdateBlogVm model):IRequest<bool>;
}
