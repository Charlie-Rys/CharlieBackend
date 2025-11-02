using CharlieBackend.API.Controllers;
using CharlieBackend.Application.Features.Library.Authors.Commands.Create;
using CharlieBackend.Application.Features.Library.Authors.Commands.Delete;
using CharlieBackend.Application.Features.Library.Authors.Commands.Update;
using CharlieBackend.Application.Features.Library.Authors.Commands.Update.UpdateAuthorAge;
using CharlieBackend.Application.Features.Library.Authors.Queries.GetAllPaged;
using CharlieBackend.Application.Features.Library.Authors.Queries.GetById;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CharlieBackend.Api.Controllers.v1.Library
{
    [Route("api/v1/library/[controller]")]
    public class AuthorController : BaseApiController<AuthorController>
    {
        [HttpGet]
        public async Task<IActionResult> GetAll(int pageNumber, int pageSize)
        {
            var author = await _mediator.Send(new GetAllAuthorQuery(pageNumber, pageSize));
            return Ok(author);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var author = await _mediator.Send(new GetAuthorByIdQuery() { Id = id });
            return Ok(author);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(CreateAuthorCommand command)
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
        public async Task<IActionResult> Put(int id, UpdateAuthorCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await _mediator.Send(command));
        }



        [HttpPatch("{id}/birthdate")]
        public async Task<IActionResult> UpdateBirthDate(int id, [FromBody] UpdateAuthorAgeCommand command)
        {
            if (id != command.Id)
                return BadRequest("ID mismatch");

            var result = await _mediator.Send(command);
            if (result.Succeeded)
                return Ok(result);

            return BadRequest(result);
        }



        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteAuthorCommand { Id = id }));
        }
    }
}
