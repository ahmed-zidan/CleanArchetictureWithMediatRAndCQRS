using Application.Blogs.Queries.GetBlogs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Blogs.Commands.Create
{
    public record CreateBlogCommand(CreateBlogVm Blog):IRequest<bool>;
}
