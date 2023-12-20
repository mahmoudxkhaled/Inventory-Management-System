using Microsoft.AspNetCore.Mvc;
using Retail.BL;
using Retail.Shared;

namespace Retail.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryManager _categoryManager;

        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> AllCategories()
        {
            try
            {
                var Categories = await _categoryManager.AllCategories();

                if (Categories is null || !Categories.Any())
                {
                    return NoContent();
                    throw new Exception("No categories exist in the system");

                }

                return Ok(Categories);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }

        }


        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult> AddCategory(CategoryDto category)
        {
            try
            {
                var newCategory = await _categoryManager.AddCategory(category);

                if (!newCategory)
                {
                    return BadRequest();
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }

        }


        [HttpPut]
        public async Task<ActionResult<bool>> UpdateCategory(CategoryDto categoryDto)
        {
            try
            {
                var updatedCategory = await _categoryManager.UpdateCategory(categoryDto);

                if (!updatedCategory)
                {
                    return NotFound();
                }

                return Ok(true);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [HttpGet]
        [Route("{categoryId:Guid}")]
        public async Task<ActionResult<CategoryDto>> GetCategoryByID(Guid categoryId)
        {
            try
            {
                var categoryDetails = await _categoryManager.CategoryDetails(categoryId);

                if (categoryDetails == null)
                {
                    return NotFound();
                }

                return Ok(categoryDetails);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [HttpDelete]
        [Route("{categoryId:Guid}")]
        public async Task<ActionResult> DeleteCategory(Guid categoryId)
        {
            try
            {
                bool deletionCategory = await _categoryManager.DeleteCategory(categoryId);

                if (deletionCategory)
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



    }
}
