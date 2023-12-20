using Retail.Shared;

namespace Retail.BL;

public interface IProductManager
{

    Task<IEnumerable<ProductDto>> AllProducts();
    Task<bool> AddProduct(ProductDto productAdd);
    Task<bool> DeleteProduct(Guid productId);
    Task<ProductDto> ProductDetails(Guid productId);
    Task<bool> UpdateProduct(ProductDto updatedProduct);
    Task<IEnumerable<ProductDto>> GetProductsByCategoryId(Guid categoryId);


}
