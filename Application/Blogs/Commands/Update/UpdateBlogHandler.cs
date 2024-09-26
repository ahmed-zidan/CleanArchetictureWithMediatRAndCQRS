using AutoMapper;
using Core.Entity;
using Core.IRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Blogs.Commands.Update
{
    public class UpdateBlogHandler : IRequestHandler<UpdateBlogCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOFWork _unitOfWork;

        public UpdateBlogHandler(IMapper mapper, IUnitOFWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var blog = _mapper.Map<Blog>(request.model);
            _unitOfWork._blogRepo.updateBlog(blog);
            return await _unitOfWork.saveChangesAsync();
        }
    }
}
