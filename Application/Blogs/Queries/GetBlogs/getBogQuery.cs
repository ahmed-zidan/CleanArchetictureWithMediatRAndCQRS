using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Blogs.Queries.GetBlogs
{
    public record getBogQuery:IRequest<List<BlogVm>>;
}
