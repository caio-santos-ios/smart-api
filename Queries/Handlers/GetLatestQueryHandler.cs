using MediatR;
using smartbr_api_clients.Interfaces;
using smartbr_api_clients.Models;
using smartbr_api_clients.Queries.Queries;

namespace smartbr_api_clients.Queries.Handlers
{
    public class GetLatestQueryHandler : IRequestHandler<GetLatestClientQuery, IEnumerable<Client>>
    {
        private readonly IClientRepository _clientRepository;
        public GetLatestQueryHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public Task<IEnumerable<Client>> Handle(GetLatestClientQuery request, CancellationToken cancellationToken)
        {
            return _clientRepository.GetLatestAsync();
        }
    }
}