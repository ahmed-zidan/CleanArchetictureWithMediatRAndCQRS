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

        public async Task<List<Blog>> getBlogsAsync()
        {
            return await Task.FromResult(new List<Blog>()
            {
                new Blog() {Author="sdhsk",Description="sdhsk",Id=1,Name="sdskjd" },
                new Blog() {Author="sdhsk",Description="sdsdjh",Id=2,Name="sdskjd"}
            }
            );
        }

        public void updateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
