using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using smartbr_api_clients.Models;

namespace smartbr_api_clients.Interfaces
{
    public interface IClientRepository
    {
        public Task<IEnumerable<Client>> GetAllAsync();
        public Task<Client> GetByIdAsync(string id);
        public Task<IEnumerable<Client>> GetLatestAsync();
        public Task CreateAsync(Client client);
        public Task UpdateAsync(string id, Client client);
        public Task DeleteAsync(string id);
    }
}