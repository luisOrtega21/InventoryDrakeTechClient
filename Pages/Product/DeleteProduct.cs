using INVENTORY.CLIENT.Services.Interfaces;
using INVENTORY.SHARED.Dto;
using Microsoft.AspNetCore.Components;

namespace INVENTORY.CLIENT.Pages.Product
{
    public class DeleteProductModel : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        [Parameter]
        public string ProductId { get; set; }
        [Parameter]
        public ProductDto Product { get; set; } = new ProductDto();

        public async Task DeleteProductById()
        {
            await ProductService.DeleteProduct(new Guid(ProductId));
        }
    }
}
