using Application.Blogs.Commands.Create;
using Application.Blogs.Commands.Delete;
using Application.Blogs.Commands.Update;
using Application.Blogs.Queries.GetBlogById;
using Application.Blogs.Queries.GetBlogs;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{

    public class BlogsController : BaseController
    {
        /*private readonly IMediator _mediator;
        public BlogsController(IMediator mediator) { 
            _mediator = mediator;
        }*/
        [HttpGet("getBlogs")]
        public async Task<IActionResult> getBlogs() {
            var res = await mediator.Send(new getBogQuery());
            return Ok(res);
        }
        [HttpGet("getBlogById/{id}")]
        public async Task<IActionResult> getBlogs(int id)
        {
            var res = await mediator.Send(new GetBlogByIdQeuery(id));
            return Ok(res);
        }
        [HttpPost("addBlog")]
        public async Task<IActionResult> addBlog(CreateBlogVm blog)
        {
            var res = await mediator.Send(new CreateBlogCommand(blog));
            if(res == true)
            {
                return StatusCode(StatusCodes.Status201Created);
            }
            return BadRequest();
        }

        [HttpPut("updateBlog")]
        public async Task<IActionResult> updateBlog(UpdateBlogVm blog)
        {
            var res = await mediator.Send(new UpdateBlogCommand(blog));
            if (res == true)
            {
                return NoContent();
            }
            return BadRequest();
        }

        [HttpDelete("deleteBlog/{id}")]
        public async Task<IActionResult> deleteBlog(int id)
        {
            var res = await mediator.Send(new DeleteCommand(id));
            if(res == true)
            {
                return NoContent();
            }
            return BadRequest();
        }

    }
}
