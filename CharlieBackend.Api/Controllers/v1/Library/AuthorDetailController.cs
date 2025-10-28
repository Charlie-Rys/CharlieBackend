using CharlieBackend.API.Controllers;
using CharlieBackend.Application.Features.Library.AuthorDetails.Queries.GetAllPaged;
using CharlieBackend.Application.Features.Library.AuthorDetails.Queries.GetById;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CharlieBackend.Api.Controllers.v1.Library
{
    [Route("api/v1/library/[controller]")]
    public class AuthorDetailController : BaseApiController<AuthorDetailController>
    {
        [HttpGet]
        public async Task<IActionResult> GetAll(int pageNumber, int pageSize)
        {
            var authorDetail = await _mediator.Send(new GetAllAuthorDetailQuery(pageNumber, pageSize));
            return Ok(authorDetail);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var authorDetail = await _mediator.Send(new GetAuthorDetailByIdQuery() { Id = id });
            return Ok(authorDetail);
        }
    }
}
