using Retail.DAL;
using Retail.Shared;

namespace Retail.BL.Extensions;
public static class DtoConversions
{


    // I could have done that easily without using the Auto Mapper Package,
    // saving my project from loading additional packages. 

    #region Product Covnert
    public static IEnumerable<ProductDto> ConvertToDto(this IEnumerable<Product> products)
    {
        return (from product in products
                select new ProductDto
                {
                    ID = product.ID,
                    NAME = product.NAME,
                    DESCRIPTION = product.DESCRIPTION,
                    PRICE = product.PRICE,
                    QTY = product.QTY,
                    PIC = product.PIC,
                    CATEGORY_ID = product.CATEGORY.ID,
                    CATEGORY_NAME = product.CATEGORY.NAME,
                    CATEGORY_DESCRIPTION = product.CATEGORY.DESCRIPTION

                }).ToList();

    }
    public static ProductDto ConvertToDto(this Product product)

    {
        return new ProductDto
        {
            ID = product.ID,
            NAME = product.NAME,
            DESCRIPTION = product.DESCRIPTION,
            PIC = product.PIC,
            PRICE = product.PRICE,
            QTY = product.QTY,
            CATEGORY_ID = product.CATEGORY.ID,
            CATEGORY_NAME = product.CATEGORY.NAME,
            CATEGORY_DESCRIPTION = product.CATEGORY.DESCRIPTION
        };

    }
    public static Product ConvertToDto(this ProductDto productDto)

    {
        return new Product
        {
            ID = productDto.ID,
            NAME = productDto.NAME,
            DESCRIPTION = productDto.DESCRIPTION,
            PIC = productDto.PIC,
            PRICE = productDto.PRICE,
            QTY = productDto.QTY,
            CATEGORY_ID = productDto.CATEGORY_ID
        };

    }

    #endregion


    #region Category Covnert
    public static IEnumerable<CategoryDto> ConvertToDto(this IEnumerable<Category> categories)
    {
        return (from category in categories
                select new CategoryDto
                {
                    ID = category.ID,
                    NAME = category.NAME,
                    DESCRIPTION = category.DESCRIPTION
                }).ToList();
    }
    public static CategoryDto ConvertToDto(this Category category)
    {
        return new CategoryDto
        {
            ID = category.ID,
            NAME = category.NAME,
            DESCRIPTION = category.DESCRIPTION
        };
    }
    public static Category ConvertToDto(this CategoryDto categoryDto)

    {
        return new Category
        {
            ID = categoryDto.ID,
            NAME = categoryDto.NAME,
            DESCRIPTION = categoryDto.DESCRIPTION
        };

    }

    #endregion

}

