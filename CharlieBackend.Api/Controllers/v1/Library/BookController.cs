using CharlieBackend.API.Controllers;
using CharlieBackend.Application.Features.Library.Authors.Commands.Create;
using CharlieBackend.Application.Features.Library.Authors.Commands.Delete;
using CharlieBackend.Application.Features.Library.Authors.Commands.Update;
using CharlieBackend.Application.Features.Library.Authors.Queries.GetAllPaged;
using CharlieBackend.Application.Features.Library.Authors.Queries.GetById;
using CharlieBackend.Application.Features.Library.Books.Commands.Create;
using CharlieBackend.Application.Features.Library.Books.Commands.Delete;
using CharlieBackend.Application.Features.Library.Books.Commands.Update;
using CharlieBackend.Application.Features.Library.Books.Queries.GetAllPaged;
using CharlieBackend.Application.Features.Library.Books.Queries.GetById;
using CharlieBackend.Domain.Entities.Library;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CharlieBackend.Api.Controllers.v1.Library
{
    [Route("api/v1/library/[controller]")]
    public class BookController : BaseApiController<BookController>
    {
        [HttpGet]
        public async Task<IActionResult> GetAll(int pageNumber, int pageSize)
        {
            var Book = await _mediator.Send(new GetAllBookQuery(pageNumber, pageSize));
            return Ok(Book);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var Book = await _mediator.Send(new GetBookByIdQuery() { Id = id });
            return Ok(Book);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(CreateBookCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        //[HttpPost("bulk-post")]

        //public async Task<IActionResult> BulkPost(BulkCreatePurchaseOrderCommand command)
        //{
        //    return Ok(await _mediator.Send(command));
        //}

        //[HttpPost("bulk-update-insert")]

        //public async Task<IActionResult> BulkUpSert(BulkUpSertPurchaseOrderCommand command)
        //{
        //    return Ok(await _mediator.Send(command));
        //}

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UpdateBookCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await _mediator.Send(command));
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteBookCommand { Id = id }));
        }
    }
}
