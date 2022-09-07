using BeActive.Shared.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BeActive.AuthDbSet
{
    public class ApplicationUserContext : IdentityDbContext
    {
        public ApplicationUserContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
