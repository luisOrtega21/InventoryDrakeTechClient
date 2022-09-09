using INVENTORY.SHARED.Dto;

namespace INVENTORY.CLIENT.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(Guid id);
        Task<ProductDto> CreateProduct(ProductCreateDto productCreate);
        Task<ProductDto> UpdateProduct(string id, ProductDto productDto);
        Task<ProductDto> DeleteProduct(Guid id);
    }
}
