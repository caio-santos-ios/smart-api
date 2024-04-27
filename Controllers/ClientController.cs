using MediatR;
using Microsoft.AspNetCore.Mvc;
using smartbr_api_clients.Commands.Commands;
using smartbr_api_clients.Models;
using smartbr_api_clients.Queries.Queries;

namespace smartbr_api_clients.Controllers
{
    [ApiController]
    [Route("api/v1/clients")]
    public class ClientController : ControllerBase
    {
        private readonly IMediator _mediator;
        
        public ClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Client>> GetAllAsync()
        {
            var query = new GetAllClientQuery();
            return await _mediator.Send(query);
        }

        [HttpGet("{id}")]
        [ActionName(nameof(GetByIdAsync))]
        public async Task<Client> GetByIdAsync(string id)
        {
            var query = new GetByIdClientQuery(id);
            return await _mediator.Send(query);
        }
        [HttpGet("latest")]
        public async Task<IEnumerable<Client>> GetLatestAsync()
        {
            var query = new GetLatestClientQuery();
            return await _mediator.Send(query);
        }

        [HttpPost]
        [ActionName(nameof(CreateAsync))]
        public async Task<IActionResult> CreateAsync([FromBody] Client client)
        {
            var command = new CreateClientCommand(client);
            var result = await _mediator.Send(command);

            return CreatedAtAction(nameof(CreateAsync), new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(string id, Client client)
        {
            var command = new UpdateClientCommand(id, client); 
            await _mediator.Send(command);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            var command = new DeleteClientCommand(id);
            await _mediator.Send(command);
            return NoContent();
        }
    }
}