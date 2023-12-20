using Retail.Shared;
using System.Net;
namespace Retail.Client.Services;

public class CategoryService : IService
{
    HttpClient _httpClient;
    public CategoryService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<CategoryDto>> GetAllCategories()
    {
        try
        {
            List<CategoryDto> CategoryList = await _httpClient.GetFromJsonAsync<List<CategoryDto>>("api/Category");
            return CategoryList;
        }
        catch (Exception)
        {
            return new List<CategoryDto>();
        }
    }
    public async Task<CategoryDto> GetCategoryById(Guid categoryId)
    {

        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"api/Category/{categoryId}");

            if (response.IsSuccessStatusCode)
            {
                CategoryDto category = await response.Content.ReadFromJsonAsync<CategoryDto>();
                return category;
                ;
            }
            else if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }
            else
            {
                string errorMessage = $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                throw new HttpRequestException(errorMessage);
            }
        }

        catch (Exception ex)
        {
            throw ex;
        }

    }
    public async Task<string> AddCategory(CategoryDto category)
    {

        try
        {
            var response = await _httpClient.PostAsJsonAsync<CategoryDto>("api/Category/Add", category);

            if (response.IsSuccessStatusCode)
            {
                return "OK";
            }
            else
            {
                var message = await response.Content.ReadAsStringAsync();
                throw new Exception($"Http status:{response.StatusCode} Message -{message}");
            }
        }

        catch (Exception ex)
        {

            throw ex;
        }

    }
    public async Task<string> UpdateCategory(CategoryDto category)
    {

        try
        {
            var response = await _httpClient.PutAsJsonAsync<CategoryDto>("api/Category", category);

            if (response.IsSuccessStatusCode)
            {
                return "OK";
            }
            else
            {
                var message = await response.Content.ReadAsStringAsync();
                throw new Exception($"Http status:{response.StatusCode} Message -{message}");
            }
        }

        catch (Exception ex)
        {

            throw ex;
        }
    }
    public async Task<string> DeleteCategory(Guid CategoryId)
    {

        try
        {
            var response = await _httpClient.DeleteAsync($"api/Category/{CategoryId}");
            if (response.StatusCode == HttpStatusCode.NoContent)

            {
                return "OK";
            }
            else
            {
                var message = await response.Content.ReadAsStringAsync();
                throw new Exception($"Http status:{response.StatusCode} Message -{message}");

            }
        }

        catch (Exception ex)
        {

            throw ex;
        }

    }
}
