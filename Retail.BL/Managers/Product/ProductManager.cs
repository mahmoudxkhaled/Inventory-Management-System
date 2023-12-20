using Microsoft.Extensions.Logging;
using Retail.BL.Extensions;
using Retail.DAL;
using Retail.Shared;

namespace Retail.BL;

public class ProductManager : IProductManager
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<ProductManager> _logger;

    public ProductManager(IUnitOfWork unitOfWork, ILogger<ProductManager> logger)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
    }
    public async Task<IEnumerable<ProductDto>> AllProducts()
    {
        try
        {
            var productsFromDB = await _unitOfWork.ProductRepo.GetAllProducts();

            if (productsFromDB == null || !productsFromDB.Any())
            {
                return Enumerable.Empty<ProductDto>();
            }

            var productsDto = productsFromDB.ConvertToDto();

            return productsDto;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while retrieving all products.");
            return Enumerable.Empty<ProductDto>();
        }
    }
    public async Task<bool> AddProduct(ProductDto productAdd)
    {
        try
        {
            if (productAdd is null)
            {
                return false;
            }

            var existingProductWithSameName = await _unitOfWork.ProductRepo.GetProductByName(productAdd.NAME);

            if (existingProductWithSameName != null && existingProductWithSameName.ID != productAdd.ID)
            {
                return false;
            }

            var newProduct = productAdd.ConvertToDto();

            _unitOfWork.ProductRepo.Add(newProduct);


            await _unitOfWork.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while adding a product.");

            return false;
        }
    }
    public async Task<bool> UpdateProduct(ProductDto updatedProduct)
    {
        try
        {
            var productFromDB = await _unitOfWork.ProductRepo.GetProductById(updatedProduct.ID);

            if (productFromDB == null)
            {
                return false;
            }

            productFromDB.NAME = updatedProduct.NAME;
            productFromDB.DESCRIPTION = updatedProduct.DESCRIPTION;
            productFromDB.PRICE = updatedProduct.PRICE;
            productFromDB.QTY = updatedProduct.QTY;
            productFromDB.CATEGORY_ID = updatedProduct.CATEGORY_ID;


            await _unitOfWork.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while updating a product.");
            return false;
        }
    }
    public async Task<bool> DeleteProduct(Guid productId)
    {
        try
        {
            var productFromDB = await _unitOfWork.ProductRepo.GetProductById(productId);

            if (productFromDB == null)
            {
                return false;
            }

            _unitOfWork.ProductRepo.Delete(productFromDB);

            await _unitOfWork.SaveChanges();

            return true;

        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while deleting the product.");

            return false;
        }
    }
    public async Task<ProductDto> ProductDetails(Guid productId)
    {
        try
        {
            var productFromDB = await _unitOfWork.ProductRepo.GetProductById(productId);

            if (productFromDB == null)
            {
                return null;
            }

            var productDto = productFromDB.ConvertToDto();

            return productDto;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while retrieving product details.");
            return null;
        }
    }
    public async Task<IEnumerable<ProductDto>> GetProductsByCategoryId(Guid categoryId)
    {
        try
        {
            var productsFromDB = await _unitOfWork.ProductRepo.GetProductsByCategoryId(categoryId);

            if (productsFromDB == null || !productsFromDB.Any())
            {
                return Enumerable.Empty<ProductDto>();
            }

            var productsDto = productsFromDB.ConvertToDto();

            return productsDto;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while retrieving products.");
            return Enumerable.Empty<ProductDto>();
        }
    }

}

