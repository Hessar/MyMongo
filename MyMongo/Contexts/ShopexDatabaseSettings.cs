namespace MyMongo.Contexts
{
    public class ShopexDatabaseSettings : IShopexDatabaseSettings
    {
        public string UsersCollectionName { set; get; }
        public string ConnectionString { set; get; }
        public string DatabaseName { set; get; }
    }
}
