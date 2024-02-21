using Microsoft.EntityFrameworkCore;
using TechSysDigitalApi.Contracts;
using TechSysDigitalApi.Data;

namespace TechSysDigitalApi.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly MusicianDbContext context;

        public GenericRepository(MusicianDbContext context)
        {
            this.context = context;
        }
        public async Task<T> AddAsync(T entity)
        {
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            context.Set<T>().Remove(entity!);
            await context.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await GetAsync(id);
            return entity != null;
        }

        public Task<List<T>> GetAllAsync()
        {
            return context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetAsync(int? id)
        {
            if (id == null)
            {
                return null;
            }
            return await context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
