using MediatR;
using smartbr_api_clients.Commands.Commands;
using smartbr_api_clients.Interfaces;

namespace smartbr_api_clients.Commands.Handlers
{
    public class DeleteClientCommandHandler : IRequestHandler<DeleteClientCommand>
    {
        private readonly IClientRepository _clientRepository;
        
        public DeleteClientCommandHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Unit> Handle(DeleteClientCommand request, CancellationToken cancellationToken)
        {
            await _clientRepository.DeleteAsync(request.id);
            return Unit.Value;    
        }
    }
}