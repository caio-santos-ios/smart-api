using MediatR;
using smartbr_api_clients.Commands.Commands;
using smartbr_api_clients.Interfaces;

namespace smartbr_api_clients.Commands.Handlers
{
    public class UpdateClientCommandHandler : IRequestHandler<UpdateClientCommand>
    {
        private readonly IClientRepository _clientRepository;
        
        public UpdateClientCommandHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Unit> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
        {
            await _clientRepository.UpdateAsync(request.id, request.client);
            return Unit.Value;
        }
    }
}