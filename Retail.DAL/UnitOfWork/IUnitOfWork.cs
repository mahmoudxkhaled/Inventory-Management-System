namespace Retail.DAL;

public interface IUnitOfWork
{
    IProductRepo ProductRepo { get; }
    ICategoryRepo CategoryRepo { get; }
    Task<int> SaveChanges();
}

