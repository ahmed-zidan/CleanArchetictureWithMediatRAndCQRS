using AutoMapper;
using Core.IRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Blogs.Queries.GetBlogs
{
    public class GetQueryHandler : IRequestHandler<getBogQuery, List<BlogVm>>
    {
        private readonly IUnitOFWork _uow;
        private readonly IMapper _mapper;

        public GetQueryHandler(IUnitOFWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<List<BlogVm>> Handle(getBogQuery request, CancellationToken cancellationToken)
        {
            var blogs = await _uow._blogRepo.getBlogsAsync();
            var blogsDto = _mapper.Map<List<BlogVm>>(blogs);
            return blogsDto;
        }
    }
}
