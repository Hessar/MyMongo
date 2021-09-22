namespace MyMongo.Contexts
{
    public interface IShopexDatabaseSettings
    {
        string UsersCollectionName { set; get; }
        string ConnectionString { set; get; }
        string DatabaseName { set; get; }
    }
}