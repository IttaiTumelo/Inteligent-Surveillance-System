global using Microsoft.EntityFrameworkCore;
global using Intelligent_Video_Surveillance_System.Shared.Models;

namespace Intelligent_Video_Surveillance_System.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<VideoEntity> Videos { get; set; } = null!;
        public DbSet<UserEntity> Users { get; set; } = null!;
        public DbSet<ObjectEntity> Objects { get; set; } = null!;
    }
}
