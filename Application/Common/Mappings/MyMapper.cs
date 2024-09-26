using Application.Blogs.Commands.Create;
using Application.Blogs.Commands.Update;
using Application.Blogs.Queries.GetBlogs;
using AutoMapper;
using Core.Entity;


namespace Application.Common.Mappings
{
    public class MyMapper : Profile
    {
        public MyMapper()
        {
            CreateMap<Blog, BlogVm>().ReverseMap();
            CreateMap<Blog, UpdateBlogVm>().ReverseMap();
            CreateMap<Blog, CreateBlogVm>().ReverseMap();
        }
    }
}
