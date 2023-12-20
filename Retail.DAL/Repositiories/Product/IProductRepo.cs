namespace Retail.DAL;

public interface IProductRepo : IGenericRepo<Product>
{
    Task<IEnumerable<Product>> GetAllProducts();
    Task<Product> GetProductById(Guid id);
    Task<Product> GetProductByName(string name);
    Task<IEnumerable<Product>> GetProductsByCategoryId(Guid categoryId);

}
