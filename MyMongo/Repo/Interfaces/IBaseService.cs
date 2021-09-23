namespace MyMongo.Repo.Interfaces
{
    public interface IBaseService<T>
    {
        List<T> Get();
        T Get(string id);
        T Create(T data);
        void Update(string id, T data);
        void Remove(T dataIn);
        void Remove(string id);

    }
}
