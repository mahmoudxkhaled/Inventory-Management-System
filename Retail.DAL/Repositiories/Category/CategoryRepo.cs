using Microsoft.EntityFrameworkCore;

namespace Retail.DAL;

public class CategoryRepo : GenericRepo<Category>, ICategoryRepo
{

    private readonly RetailContext _context;

    public CategoryRepo(RetailContext context) : base(context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Category>> GetAllCategories()
    {
        var categories = await _context.Set<Category>()
                                    .Include(p => p.PRODUCTS)
                                    .ToListAsync();

        return categories;
    }

    public async Task<Category> GetCategoryById(Guid id)
    {
        var category = await _context.Set<Category>()
                                   .Include(p => p.PRODUCTS)
                                   .SingleOrDefaultAsync(c => c.ID == id);

        return category;
    }

    public async Task<Category> GetCategoryByName(string name)
    {
        var category = await _context.Set<Category>()
                                   .Include(p => p.PRODUCTS)
                                   .SingleOrDefaultAsync(c => c.NAME == name);

        return category;
    }

}
