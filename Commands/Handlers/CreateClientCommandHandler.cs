using MediatR;
using smartbr_api_clients.Commands.Commands;
using smartbr_api_clients.Interfaces;
using smartbr_api_clients.Models;

namespace smartbr_api_clients.Commands.Handler
{
    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, Client>
    {
        private readonly IClientRepository _clientRepository;

        public CreateClientCommandHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        
        public async Task<Client> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            await _clientRepository.CreateAsync(request.client);

            return request.client;
        }
    }
}