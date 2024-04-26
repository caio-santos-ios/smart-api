using MediatR;
using smartbr_api_clients.Models;

namespace smartbr_api_clients.Commands.Commands
{
    public class UpdateClientCommand : IRequest
    {
        public string id { get; set; }
        public Client client{ get; set; }

        public UpdateClientCommand(string id, Client client)
        {
            this.id = id;
            this.client = client;
        }
    }
}