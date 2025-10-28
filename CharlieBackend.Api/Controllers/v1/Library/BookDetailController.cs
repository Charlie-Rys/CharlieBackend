using CharlieBackend.API.Controllers;
using CharlieBackend.Application.Features.Library.AuthorDetails.Queries.GetAllPaged;
using CharlieBackend.Application.Features.Library.AuthorDetails.Queries.GetById;
using CharlieBackend.Application.Features.Library.BookDetails.Queries.GetAllPaged;
using CharlieBackend.Application.Features.Library.BookDetails.Queries.GetById;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CharlieBackend.Api.Controllers.v1.Library
{
    [Route("api/v1/library/[controller]")]
    public class BookDetailController : BaseApiController<BookDetailController>
    {
        [HttpGet]
        public async Task<IActionResult> GetAll(int pageNumber, int pageSize)
        {
            var bookDetail = await _mediator.Send(new GetAllBookDetailQuery(pageNumber, pageSize));
            return Ok(bookDetail);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var bookDetail = await _mediator.Send(new GetBookDetailByIdQuery() { Id = id });
            return Ok(bookDetail);
        }
    }
}
