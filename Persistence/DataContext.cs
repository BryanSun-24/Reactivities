using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    // we will be using this as a service and we want to be able to inject data context into other classes in our application
    public class DataContext : DbContext
    {
        // base(options): pass parameter options to the constructor of class DbContext
        public DataContext( DbContextOptions options) : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; }
    }
}