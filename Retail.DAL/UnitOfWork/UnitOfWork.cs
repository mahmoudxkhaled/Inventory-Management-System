namespace Retail.DAL;
public class UnitOfWork : IUnitOfWork
{
    private readonly RetailContext _context;

    public IProductRepo ProductRepo { get; }
    public ICategoryRepo CategoryRepo { get; }

    public UnitOfWork(RetailContext context, IProductRepo productRepo, ICategoryRepo categoryRepo)
    {
        _context = context;
        ProductRepo = productRepo;
        CategoryRepo = categoryRepo;
    }

    public async Task<int> SaveChanges()
    {
        return await _context.SaveChangesAsync();
    }
}

