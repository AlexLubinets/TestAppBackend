using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestAppBackend.DAL.Entities;

namespace TestAppBackend.DAL.EF
{
    public class ApplicationContext : IdentityDbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        
    }
}
