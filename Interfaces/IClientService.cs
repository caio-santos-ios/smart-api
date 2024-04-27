using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using smartbr_api_clients.Models;

namespace smartbr_api_clients.Interfaces
{
    public interface IClientService
    {
        Task<IEnumerable<Client>> GetAllAsync();
        Task<Client> GetByIdAsync(string id);
        Task<IEnumerable<Client>> GetLatestAsync();
        Task CreateAsync(Client client);
        Task UpdateAsync(string id, Client client);
        Task DeleteAsync(string id);
    }
}