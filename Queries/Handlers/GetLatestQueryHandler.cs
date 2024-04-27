using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using smartbr_api_clients.Interfaces;
using smartbr_api_clients.Models;
using smartbr_api_clients.Queries.Queries;

namespace smartbr_api_clients.Queries.Handlers
{
    public class GetLatestQueryHandler : IRequestHandler<GetLatestClientQuery, IEnumerable<Client>>
    {
        private readonly IClientRepository _clientRepository;
        public GetLatestQueryHandler(IClientRepository clientService) {
            _clientRepository = clientService;
        }
        public async Task<IEnumerable<Client>> Handle(GetLatestClientQuery request, CancellationToken cancellationToken)
        {
            return await _clientRepository.GetLatestAsync();
        }
    }
}