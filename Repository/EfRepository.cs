using WebApiTutorial.Data;

namespace WebApiTutorial.Repository
{
    public class EfRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private readonly DatabaseContext _context;
        private readonly DbSet<T> _dbSet;


        public EfRepository(DatabaseContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();

        }
        public T Add(T entity)
        {
            var result=new T();
            _dbSet.Add(entity);
            _context.SaveChanges();
            result = entity;
            return result;
        }

        public T Delete(T entity)
        {
            var result=new T();
            _dbSet.Delete(entity);
            _context.SaveChanges();
            result=entity;
            return result;
        }

        public List<T> GetAll()
        {
            var result=new List<T>();
            var list= _dbSet.ToList();
            if(list != null)
            {
                result = list;
            }
            else {
                result = null;
            }
            return result;
        }

        public T GetById(int id)
        {
            var result = new T();
            result=_dbSet.Find(id);
            return result;
        }

        public T UpdateById(T entity, int id)
        {
            var result=new T();
            var model = _dbSet.Find(id);
            if (model == null)
            {
                return null;
            }

            _context.Entry(model).CurrentValues.SetValue(entity);
            _context.SaveChanges();
            result=model;
            return result;
        }
    }
}
