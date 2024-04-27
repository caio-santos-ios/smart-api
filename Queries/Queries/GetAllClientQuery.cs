using MediatR;
using smartbr_api_clients.Models;

namespace smartbr_api_clients.Queries.Queries
{
    public class GetAllClientQuery : IRequest<IEnumerable<Client>>
    {
        public GetAllClientQuery() {}        
    }
}
