namespace Retail.DAL;


public interface ICategoryRepo : IGenericRepo<Category>
{
    Task<Category> GetCategoryById(Guid id);
    Task<Category> GetCategoryByName(string name);
    Task<IEnumerable<Category>> GetAllCategories();

}
