using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        private ISender _mediator;
        protected ISender mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
    }
}
