using Retail.Shared;
using System.Net;
namespace Retail.Client.Services;

public class ProductService : IService
{

    HttpClient _httpClient;
    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<List<ProductDto>> GetAllProducts()
    {
        try
        {
            List<ProductDto> ProductList = await _httpClient.GetFromJsonAsync<List<ProductDto>>("api/Product");
            return ProductList;
        }
        catch (Exception)
        {
            return new List<ProductDto>();
        }
    }

    public async Task<ProductDto> GetProductById(Guid productId)
    {
        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"api/Product/{productId}");

            if (response.IsSuccessStatusCode)
            {
                ProductDto product = await response.Content.ReadFromJsonAsync<ProductDto>();
                return product;
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

    public async Task<string> AddProduct(ProductDto product)
    {
        try
        {
            var response = await _httpClient.PostAsJsonAsync("api/Product/Add", product);

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

    public async Task<string> UpdatePrdouct(Guid id, ProductDto product)
    {

        try
        {
            var response = await _httpClient.PutAsJsonAsync<ProductDto>("api/Product/" + id, product);

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

    public async Task<string> DeletePrdouct(Guid productId)
    {

        try
        {
            var response = await _httpClient.DeleteAsync($"api/Product/{productId}");


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

    public async Task<List<ProductDto>> GetProductsByCategoryId(Guid categoryId)
    {
        try
        {
            var response = await _httpClient.GetFromJsonAsync<List<ProductDto>>($"api/Product/GetProductsByCategory/{categoryId}");

            if (response != null && response.Count > 0)
            {
                return response;
            }
            else
            {
                return null;
            }
        }
        catch (Exception)
        {
            return null;

        }
    }











}
