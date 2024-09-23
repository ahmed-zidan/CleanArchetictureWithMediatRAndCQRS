using Application.Blogs.Queries.GetBlogs;
using AutoMapper;
using Core.IRepo;
using MediatR;


namespace Application.Blogs.Queries.GetBlogById
{
    public class GetBlogByIdHandler : IRequestHandler<GetBlogByIdQeuery, BlogVm>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOFWork _uow;
        public GetBlogByIdHandler(IMapper mapper , IUnitOFWork unitOFWork)
        {
            _mapper = mapper;
            _uow = unitOFWork;
        }
        public async Task<BlogVm> Handle(GetBlogByIdQeuery request, CancellationToken cancellationToken)
        {
            var res = await _uow._blogRepo.getBlogByIdAsync(request.BlogId);
            return _mapper.Map<BlogVm>(res);
        }
    }
}
