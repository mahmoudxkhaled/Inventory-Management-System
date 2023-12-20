using Retail.Shared;

namespace Retail.BL;

public interface ICategoryManager
{

    Task<IEnumerable<CategoryDto>> AllCategories();
    Task<bool> AddCategory(CategoryDto categoryAdd);
    Task<CategoryDto> CategoryDetails(Guid CategoryId);
    Task<bool> UpdateCategory(CategoryDto updatedCategory);
    Task<bool> DeleteCategory(Guid CategoryId);

}
