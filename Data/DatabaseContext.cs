using WebApiTutorial.Models;

namespace WebApiTutorial.Data
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbcontextOptions<DatabaseContext>options):base(options)
        {
            
        }


        public DbSet<Posts> Posts { get; set; }
    }
}
