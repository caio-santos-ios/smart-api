using MediatR;
using smartbr_api_clients.Models;

namespace smartbr_api_clients.Commands.Commands
{
    public class CreateClientCommand : IRequest<Client>
    {
        public Client client { get; private set; }

        public CreateClientCommand(Client client)
        {
            this.client = client;
        }
    }
}