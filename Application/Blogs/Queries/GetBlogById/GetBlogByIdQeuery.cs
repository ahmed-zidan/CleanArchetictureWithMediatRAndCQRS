﻿using Application.Blogs.Queries.GetBlogs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Blogs.Queries.GetBlogById
{
    public record GetBlogByIdQeuery(int BlogId):IRequest<BlogVm>;
}
