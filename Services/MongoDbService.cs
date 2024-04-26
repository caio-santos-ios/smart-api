using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using smartbr_api_clients.Models;

namespace smartbr_api_clients.Services
{
    public class MongoDbService
    {
        private readonly IMongoCollection<Client> _clientCollection;
        public MongoDbService(IConfiguration configuration)
        {
            var client = new MongoClient(configuration["MongoDBSettings:ConnectionString"]);
            var database = client.GetDatabase(configuration["MongoDBSettings:DatabaseName"]);
            _clientCollection = database.GetCollection<Client>("clients");
        }
    }
}