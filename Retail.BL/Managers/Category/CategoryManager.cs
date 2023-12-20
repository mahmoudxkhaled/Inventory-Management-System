using Microsoft.Extensions.Logging;
using Retail.BL.Extensions;
using Retail.DAL;
using Retail.Shared;

namespace Retail.BL;

public class CategoryManager : ICategoryManager
{

    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<CategoryManager> _logger;

    public CategoryManager(IUnitOfWork unitOfWork, ILogger<CategoryManager> logger)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
    }


    public async Task<IEnumerable<CategoryDto>> AllCategories()
    {
        try
        {
            var categoriesFromDB = await _unitOfWork.CategoryRepo.GetAllCategories();

            var categoriesDto = categoriesFromDB.ConvertToDto();

            return categoriesDto;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while retrieving all categories.");
            return Enumerable.Empty<CategoryDto>();
        }
    }
    public async Task<bool> AddCategory(CategoryDto categoryAdd)
    {
        try
        {
            if (categoryAdd is null)
            {
                return false;
            }

            var newCategory = categoryAdd.ConvertToDto();

            _unitOfWork.CategoryRepo.Add(newCategory);

            await _unitOfWork.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while adding a category.");

            return false;
        }

    }
    public async Task<CategoryDto> CategoryDetails(Guid CategoryId)
    {

        try
        {
            var categoryFromDB = await _unitOfWork.CategoryRepo.GetCategoryById(CategoryId);

            if (categoryFromDB == null)
            {
                return null;
            }

            var catewgoryDto = categoryFromDB.ConvertToDto();

            return catewgoryDto;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while retrieving categorycategory details.");
            return null;
        }


    }
    public async Task<bool> UpdateCategory(CategoryDto updatedCategory)
    {

        try
        {
            var categoryFromDB = await _unitOfWork.CategoryRepo.GetCategoryById(updatedCategory.ID);

            if (categoryFromDB == null)
            {
                return false;
            }

            categoryFromDB.NAME = updatedCategory.NAME;
            categoryFromDB.DESCRIPTION = updatedCategory.DESCRIPTION;

            await _unitOfWork.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while updating a category.");
            return false;
        }
    }
    public async Task<bool> DeleteCategory(Guid CategoryId)
    {
        try
        {
            var categoryFromDB = await _unitOfWork.CategoryRepo.GetCategoryById(CategoryId);

            if (categoryFromDB == null)
            {
                return false;
            }

            _unitOfWork.CategoryRepo.Delete(categoryFromDB);

            await _unitOfWork.SaveChanges();

            return true;

        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while deleting the product.");

            return false;
        }
    }

}
