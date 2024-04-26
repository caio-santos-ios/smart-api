using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace smartbr_api_clients.Models
{
    public class Client
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("name")]
        public string? Name { get; set; }
        [BsonElement("document")]
        public required string Document { get; set; } // CPF ou CNPJ
        [BsonElement("isPersonFisic")]
        public required bool IsPersonFisic { get; set; }
        [BsonElement("email")]
        public required string Email { get; set; }
    }
}