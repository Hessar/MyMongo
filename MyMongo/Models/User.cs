﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyMongo.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("UserName")]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
