using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using smartbr_api_clients.Interfaces;
using smartbr_api_clients.Models;

namespace smartbr_api_clients.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        // QUERIES
         public Task<IEnumerable<Client>> GetAllAsync()
        {
            return _clientRepository.GetAllAsync();
        }

        public Task<Client> GetByIdAsync(string id)
        {
            return _clientRepository.GetByIdAsync(id);
        }

        public Task<IEnumerable<Client>> GetLatestAsync()
        {
            return _clientRepository.GetLatestAsync();
        }


        // COMMANDS
        public async Task CreateAsync(Client client)
        {
            await _clientRepository.CreateAsync(client);
        }
        public async Task UpdateAsync(string id, Client client)
        {
            await _clientRepository.UpdateAsync(id, client);
        }
        public async Task DeleteAsync(string id)
        {
            await _clientRepository.DeleteAsync(id);
        }
    }
}