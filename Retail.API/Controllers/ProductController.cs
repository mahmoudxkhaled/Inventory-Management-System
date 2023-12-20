using Microsoft.AspNetCore.Mvc;
using Retail.BL;
using Retail.Shared;

namespace Retail.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductManager _productManager;
        private readonly ICategoryManager _categoryManager;

        public ProductController(IProductManager productManager, ICategoryManager categoryManager)
        {
            _productManager = productManager;
            _categoryManager = categoryManager;
        }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> AllProducts()
        {
            try
            {
                var Products = await _productManager.AllProducts();

                if (Products is null || !Products.Any())
                {
                    return NoContent();
                    throw new Exception("No products exist in the system");

                }

                return Ok(Products);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }

        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<bool>> AddProduct(ProductDto product)
        {
            try
            {
                var newProduct = await _productManager.AddProduct(product);

                if (!newProduct)
                {
                    return BadRequest(false);
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }

        }


        [HttpPut]
        [Route("{productId:Guid}")]
        public async Task<ActionResult<bool>> UpdateProduct(ProductDto productDto)
        {
            try
            {
                var updatedProduct = await _productManager.UpdateProduct(productDto);

                if (!updatedProduct)
                {
                    return NotFound();
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [HttpDelete]
        [Route("{productId:Guid}")]
        public async Task<ActionResult> DeleteProduct(Guid productId)
        {
            try
            {
                bool deletionProduct = await _productManager.DeleteProduct(productId);

                if (deletionProduct)
                {
                    return NoContent();
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [HttpGet]
        [Route("{productId:Guid}")]
        public async Task<ActionResult<ProductDto>> GetProductByID(Guid productId)
        {
            try
            {
                var productDetails = await _productManager.ProductDetails(productId);

                if (productDetails == null)
                {
                    return NotFound();
                }

                return Ok(productDetails);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [HttpGet]
        [Route("GetProductsByCategory/{categoryId:Guid}")]
        public async Task<ActionResult<ProductDto>> GetProductsByCategoryId(Guid categoryId)
        {
            try
            {
                var products = await _productManager.GetProductsByCategoryId(categoryId);

                if (products == null || !products.Any())
                {
                    return NotFound();
                }

                return Ok(products);
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }


        [HttpGet]
        [Route("GetName/{productId:Guid}")]
        public async Task<ActionResult<string>> GetProductNameById(Guid productId)
        {
            try
            {
                var product = await _productManager.ProductDetails(productId);

                if (product == null)
                {
                    return NotFound();
                }

                return Ok(product.NAME);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
