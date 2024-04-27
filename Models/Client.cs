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
        
        [BsonElement("lastName")]
        public required string LastName { get; set; }
        
        [BsonElement("document")]
        public required string Document { get; set; } // CPF ou CNPJ
        
        [BsonElement("email")]
        public required string Email { get; set; }

        [BsonElement("cellPhone")]
        public required string cellPhone { get; set; }

        [BsonElement("state")]
        public required string State { get; set; }

        [BsonElement("city")]
        public required string City { get; set; }

        [BsonElement("zipCode")]
        public required string ZipCode { get; set; }  

        [BsonElement("number")]
        public required string Number { get; set; } 

        [BsonElement("road")]
        public required string Road { get; set; }

        [BsonElement("neighborhood")]
        public required string Neighborhood { get; set; }

        [BsonElement("reference")]
        public string? Reference { get; set; }

        [BsonElement("isPersonFisic")]
        public required bool IsPersonFisic { get; set; }

        [BsonElement("observation")]
        public string? Observation { get; set; }
        
        [BsonElement("created_at")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [BsonElement("updated_at")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}