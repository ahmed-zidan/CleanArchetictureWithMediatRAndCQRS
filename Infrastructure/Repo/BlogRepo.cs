using Core.Entity;
using Core.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repo
{
    public class BlogRepo : IBlogRepo
    {
        public Task addBlogAsync(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void deleteBlog(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Blog> getBlogByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Blog>> getBlogsAsync()
        {
            throw new NotImplementedException();
        }

        public void updateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
