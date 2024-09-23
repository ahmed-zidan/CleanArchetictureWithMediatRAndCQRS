using Application.Blogs.Queries.GetBlogs;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    
    public class BlogsController : BaseController
    {
        private readonly IMediator _mediator;
        public BlogsController(IMediator mediator) { 
            _mediator = mediator;
        }
        [HttpGet("getBlogs")]
        public async Task<IActionResult> getBlogs() {
            //var res = await _mediator.Send(GetQueryHandler);
            return Ok();
        }
    }
}
