using INVENTORY.CLIENT.Services.Interfaces;
using INVENTORY.SHARED.Dto;
using Microsoft.AspNetCore.Components;

namespace INVENTORY.CLIENT.Pages.Product
{
    public class UpdateProductModel : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }
        [Parameter]
        public string ProductId { get; set; }

        [Parameter]
        public ProductDto Product { get; set; } = new ProductDto();

        protected override async Task OnParametersSetAsync()
        {
            Product = await ProductService.GetProductById(new Guid(ProductId));
        }

        public async Task UpdateProductById()
        {
            await ProductService.UpdateProduct(ProductId, Product);
        }
    }
}
