using Microsoft.EntityFrameworkCore;
using Simulator.Models;

namespace Simulator.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) 
            : base(options) 
        {}

        public DbSet<User> User { get; set; }


    }
}
