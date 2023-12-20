using Microsoft.EntityFrameworkCore;

namespace Retail.DAL;

public class GenericRepo<T> : IGenericRepo<T> where T : class
{
    private readonly RetailContext _context;

    public GenericRepo(RetailContext dbContext)
    {
        _context = dbContext;
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetById(Guid id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task Add(T item)
    {
        _context.Set<T>().Add(item);
    }

    public async Task Update(T item)
    {
        //Empty
    }

    public async Task Delete(T item)
    {
        _context.Set<T>().Remove(item);
    }
}

