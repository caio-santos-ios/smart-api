using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using smartbr_api_clients.Interfaces;
using smartbr_api_clients.Models;

namespace smartbr_api_clients.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly IMongoCollection<Client> _clientCollection;
        public ClientRepository(IMongoDatabase database)
        {
            _clientCollection = database.GetCollection<Client>("clients");
        }
        public async Task<IEnumerable<Client>> GetAllAsync()
        
        {
            return await _clientCollection.Find(_ => true).ToListAsync();
        }
        public async Task<Client> GetByIdAsync(string id)
        
        {
            return await _clientCollection.Find(client => client.Id == id).FirstOrDefaultAsync();
        }

        // Busca os ultimos clientes
        public async Task<IEnumerable<Client>> GetLatestAsync() {
            return await _clientCollection.Find(_ => true)
            .SortByDescending(client => client.CreatedAt)
            .Limit(5)
            .ToListAsync();
        }

        public async Task CreateAsync(Client client)
        {
            await _clientCollection.InsertOneAsync(client);
        }
        public async Task UpdateAsync(string id, Client client)
        {
            await _clientCollection.ReplaceOneAsync(client => client.Id == id, client);
        }
        public async Task DeleteAsync(string id)
        {
            await _clientCollection.DeleteOneAsync(client => client.Id == id);
        }
    }
}