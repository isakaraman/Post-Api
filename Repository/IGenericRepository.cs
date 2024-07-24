namespace WebApiTutorial.Repository
{
    public interface IGenericRepository<T> where T : class, new()
    {
        T Add(T model);
        T Delete(T model);
        T GetById(int id);
        List<T> GetAll();
        T UpdateById(T entity, int id);
    }
}
