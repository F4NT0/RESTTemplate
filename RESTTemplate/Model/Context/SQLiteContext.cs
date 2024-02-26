using Microsoft.EntityFrameworkCore;

namespace RESTTemplate.Model.Context
{
    public class SQLiteContext : DbContext
    {
        public SQLiteContext() 
        { 
            
        }

        public SQLiteContext(DbContextOptions<SQLiteContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
