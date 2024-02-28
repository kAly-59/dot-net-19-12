
public interface IRepository<T>
{
    IEnumerable<T> GetAll();
    T GetById(int id);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}

public class Repository<T> : IRepository<T> where T : class
{
    private List<T> entities;

    public Repository()
    {
        entities = new List<T>();
    }

    public IEnumerable<T> GetAll()
    {
        return entities;
    }

    public T GetById(int id)
    {
        return entities.FirstOrDefault(e => e.GetHashCode() == id);
    }

    public void Add(T entity)
    {
        entities.Add(entity);
    }

    public void Update(T entity)
    {
    }

    public void Delete(T entity)
    {
        entities.Remove(entity);
    }
}
