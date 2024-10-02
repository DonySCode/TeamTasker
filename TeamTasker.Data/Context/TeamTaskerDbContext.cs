using Microsoft.EntityFrameworkCore;
using TeamTasker.Data.Models;

namespace TeamTasker.Data
{
    public class TeamTaskerDbContext : DbContext
    {
        public TeamTaskerDbContext(DbContextOptions<TeamTaskerDbContext> options)
            : base(options)
        {
        }

        public DbSet<TeamTasker.Data.Models.Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
