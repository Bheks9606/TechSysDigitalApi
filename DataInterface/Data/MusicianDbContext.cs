using Microsoft.EntityFrameworkCore;
using TechSysDigitalApi.Models;

namespace TechSysDigitalApi.Data
{
    public class MusicianDbContext : DbContext 
    {
        public MusicianDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Musician> Musicians { get; set; } 
    }
}
