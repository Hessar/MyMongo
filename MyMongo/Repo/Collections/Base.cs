using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyMongo.Repo.Collections
{
    public class Base
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string? CreatedBy {  get; set; }
        public DateTime CreatedOn {  get; set; }
        public string? ModifiedOn {  get; set; }
        public DateTime ModifiedBy {  get; set; }
        public int StatusId { get; set; }
        public long? ParentId { get; set; }
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
