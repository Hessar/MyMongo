using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MyMongo.Repo.Collections;

namespace MyMongo.Models.Collections.Users
{
    public class User : Base
    {

        [BsonElement("UserName")]
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}
