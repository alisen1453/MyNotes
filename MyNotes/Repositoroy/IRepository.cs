namespace MyNotes.Repositoroy
{
    public interface IRepository<T> where T : class
    {   
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task <T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
    }
}
