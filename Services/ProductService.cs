using INVENTORY.CLIENT.Services.Interfaces;
using INVENTORY.SHARED.Dto;
using System.Net.Http.Json;

namespace INVENTORY.CLIENT.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public ProductCreateDto ProductCreate { get; set; }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/Product");
        }

        public async Task<ProductDto> CreateProduct(ProductCreateDto productCreate)
        {
            var response = await _httpClient.PostAsJsonAsync("/api/Product", productCreate);
            var result = await response.Content.ReadFromJsonAsync<ProductDto>();
            return result;
        }

        public async Task<ProductDto> GetProductById(Guid id)
        {
            var response = await _httpClient.GetFromJsonAsync<ProductDto>($"api/Product/{id}");
            return response;
        }

        public async Task<ProductDto> UpdateProduct(string id, ProductDto product)
        {
            await _httpClient.PutAsJsonAsync($"api/Product/{id}", product);
            return product;
        }

        public async Task<ProductDto> DeleteProduct(Guid ids)
        {
            await _httpClient.DeleteAsync ($"api/Product/{ids}");
            return null;
        }
    }
}
