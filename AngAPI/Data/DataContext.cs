using Microsoft.EntityFrameworkCore;
using AngAPI.Entities;

namespace AngAPI.Data
{
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AppUser> Users {get;set;}
        
    }
}