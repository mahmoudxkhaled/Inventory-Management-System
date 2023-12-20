using Microsoft.EntityFrameworkCore;

namespace Retail.DAL;

public class ProductRepo : GenericRepo<Product>, IProductRepo
{

    private readonly RetailContext _context;

    public ProductRepo(RetailContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        var categories = await _context.Set<Product>().Include(c => c.CATEGORY)
                  .ToListAsync();
        return categories;
    }

    public async Task<Product> GetProductById(Guid id)
    {
        var product = await _context.Set<Product>()
                                   .Include(p => p.CATEGORY)
                                   .SingleOrDefaultAsync(p => p.ID == id);

        return product!;
    }
    public async Task<Product> GetProductByName(string name)
    {
        var product = await _context.Set<Product>()
                                   .Include(p => p.CATEGORY)
                                   .SingleOrDefaultAsync(p => p.NAME == name);

        return product;
    }

    public async Task<IEnumerable<Product>> GetProductsByCategoryId(Guid categoryId)
    {
        var products = await _context.Set<Product>()
                      .Include(c => c.CATEGORY)
                      .Where(p => p.CATEGORY_ID == categoryId)
                      .ToListAsync();

        return products;
    }


}
