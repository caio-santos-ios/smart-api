using MediatR;
using smartbr_api_clients.Models;

namespace smartbr_api_clients.Queries.Queries
{
    public class GetByIdClientQuery : IRequest<Client>
    {
        public string Id { get; set; }
        public GetByIdClientQuery(string id)
        {
            Id = id;
        }
    }
}