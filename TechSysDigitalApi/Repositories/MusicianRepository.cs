using TechSysDigitalApi.Contracts;
using TechSysDigitalApi.Data;
using TechSysDigitalApi.Models;

namespace TechSysDigitalApi.Repositories
{
    public class MusicianRepository : GenericRepository<Musician>, IMusicianRepository
    {
        public MusicianRepository(MusicianDbContext context) : base(context)
        {
        }
    }
}
