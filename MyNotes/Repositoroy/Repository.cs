
using Microsoft.EntityFrameworkCore;
using MyNotes.DbCobtex;

namespace MyNotes.Repositoroy
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public readonly MyDbContex contex;
        public readonly DbSet<T> DbSet;

        public Repository(MyDbContex myDbContex)
        {
          contex = myDbContex;
            DbSet = contex.Set<T>();
        }

        public async Task<T> AddAsync(T entity)
        {
            await DbSet.AddAsync(entity);
            
            await contex.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity=await DbSet.FindAsync(id);
            if (entity !=null) {
                DbSet.Remove(entity);
                await contex.SaveChangesAsync();
            }
            
            
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            
            return await DbSet.FindAsync(id);
        }

       
        public async Task<T> UpdateAsync(T entity)
        {
            DbSet.Update(entity);
            await contex.SaveChangesAsync();
            return entity;
        }
    }
}
