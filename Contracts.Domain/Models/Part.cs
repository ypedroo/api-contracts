﻿using MongoDB.Bson.Serialization.Attributes;

namespace Contracts.Domain.Models
{
    public sealed class Part
    {
        [BsonId]
        public int PartId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
