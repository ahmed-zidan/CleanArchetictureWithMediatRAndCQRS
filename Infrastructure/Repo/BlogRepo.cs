using Core.Entity;
using Core.IRepo;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repo
{
    public class BlogRepo : IBlogRepo
    {
        private readonly AppDbContext _context;

        public BlogRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task addBlogAsync(Blog blog)
        {
            await _context.Blogs.AddAsync(blog);
        }

        public async Task<bool> deleteBlog(int id)
        {
            var blog = await _context.Blogs.FirstOrDefaultAsync(x=>x.Id == id);
            if (blog == null) {
                return false;
            }
            _context.Blogs.Remove(blog);
            return true;
        }

        public async Task<Blog> getBlogByIdAsync(int id)
        {
            return await _context.Blogs.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Blog>> getBlogsAsync()
        {
            return await _context.Blogs.ToListAsync();
        }

        public async Task<bool> updateBlog(Blog blog)
        {
            await _context.Blogs.Where(x => x.Id == blog.Id)
                .ExecuteUpdateAsync(setters => setters.SetProperty(m => m.Name, blog.Name)
                .SetProperty(m => m.Author, blog.Author)
                .SetProperty(m => m.Description, blog.Description));
                ;
            return true;
        }
    }
}
