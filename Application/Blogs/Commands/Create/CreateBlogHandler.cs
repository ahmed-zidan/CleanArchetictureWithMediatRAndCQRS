using Application.Blogs.Queries.GetBlogs;
using AutoMapper;
using Core.Entity;
using Core.IRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Blogs.Commands.Create
{
    public class CreateBlogHandler : IRequestHandler<CreateBlogCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOFWork _uow;

        public CreateBlogHandler(IMapper mapper, IUnitOFWork uow)
        {
            _mapper = mapper;
            _uow = uow;
        }
        
        public async Task<bool> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            var blog = _mapper.Map<Blog>(request.Blog);
            await _uow._blogRepo.addBlogAsync(blog);
            return await _uow.saveChangesAsync();
        }
    }
}
