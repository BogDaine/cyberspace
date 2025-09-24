namespace cyberspace.Services
{
    public interface ICollectionService<T>
    {
        List<T> GetAll();
        T Get(Guid id);
        bool Create(T model);
    }
}
