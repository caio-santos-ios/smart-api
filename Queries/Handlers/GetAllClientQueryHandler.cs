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
    public class GetAllClientQueryHandler : IRequestHandler<GetAllClientQuery, IEnumerable<Client>>
    {
        private readonly IClientRepository _clientRepository;
        public GetAllClientQueryHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<IEnumerable<Client>> Handle(GetAllClientQuery request, CancellationToken cancellationToken)
        {
            return await _clientRepository.GetAllAsync();
        }
    }
}