using MongoDB.Bson;
using MongoDB.Driver;
using MyMongo.Contexts;
using MyMongo.Models;

namespace MyMongo.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _user;
        public ObjectId _objectid;
        public UserService(IShopexDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _user = database.GetCollection<User>(settings.UsersCollectionName);

        }
        public List<User> Get() =>
            _user.Find(user => true).ToList();

        public User Get(string id) =>
            _user.Find<User>(user => user.Id == id).FirstOrDefault();

        public User Create(User user)
        {
            _objectid = MongoDB.Bson.ObjectId.GenerateNewId();
            user.Id = _objectid.ToString();
            _user.InsertOne(user);
            return user;
        }

        public void Update(string id, User user) =>
            _user.ReplaceOne(user => user.Id == id, user);

        public void Remove(User userIn) =>
            _user.DeleteOne(user => user.Id == userIn.Id);

        public void Remove(string id) =>
            _user.DeleteOne(user => user.Id == id);
    }
}
