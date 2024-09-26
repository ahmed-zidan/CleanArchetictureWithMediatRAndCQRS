using AutoMapper;
using Core.IRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Blogs.Commands.Delete
{
    public class DeleteCommandHandler : IRequestHandler<DeleteCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOFWork _uow;

        public DeleteCommandHandler(IMapper mapper, IUnitOFWork uow)
        {
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteCommand request, CancellationToken cancellationToken)
        {
            _uow._blogRepo.deleteBlog(request.BlogId);
            return await _uow.saveChangesAsync();
        }
    }
}
