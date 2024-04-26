using MediatR;

namespace smartbr_api_clients.Commands.Commands
{
    public class DeleteClientCommand : IRequest
    {
        public string id { get; private set; }
        public DeleteClientCommand(string id)
        {
            this.id = id;
        }
    }
}