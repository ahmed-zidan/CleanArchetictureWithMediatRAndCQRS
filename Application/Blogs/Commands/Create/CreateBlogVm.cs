﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Blogs.Commands.Create
{
    public class CreateBlogVm
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
    }
}
