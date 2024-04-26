using MediatR;
using smartbr_api_clients.Interfaces;
using smartbr_api_clients.Models;
using smartbr_api_clients.Queries.Queries;

namespace smartbr_api_clients.Queries.Handlers
{
    public class GetByIdClientQueyHendler : IRequestHandler<GetByIdClientQuery, Client>
    {
        private readonly IClientRepository _clientRepository;
        public GetByIdClientQueyHendler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<Client> Handle(GetByIdClientQuery request, CancellationToken cancellationToken) 
        {
            return await _clientRepository.GetByIdAsync(request.Id);
        }
    }
}