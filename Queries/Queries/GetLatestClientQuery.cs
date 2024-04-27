using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using smartbr_api_clients.Models;

namespace smartbr_api_clients.Queries.Queries
{
    public class GetLatestClientQuery : IRequest<IEnumerable<Client>>
    {
        public GetLatestClientQuery() {}
    }
}