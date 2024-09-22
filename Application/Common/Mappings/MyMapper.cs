using Application.Blogs.Queries.GetBlogs;
using AutoMapper;
using Core.Entity;


namespace Application.Common.Mappings
{
    public class MyMapper : Profile
    {
        public MyMapper()
        {
            CreateMap<Blog, BlogVm>();
        }
    }
}
