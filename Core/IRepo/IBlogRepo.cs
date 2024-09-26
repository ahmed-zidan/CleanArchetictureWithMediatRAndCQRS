using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.IRepo
{
    public interface IBlogRepo
    {
        Task<List<Blog>> getBlogsAsync();
        Task<Blog> getBlogByIdAsync(int id);
        Task addBlogAsync(Blog blog);
        Task<bool> updateBlog(Blog blog);
        Task<bool> deleteBlog(int id);

    }
}
