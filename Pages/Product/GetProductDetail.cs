using INVENTORY.CLIENT.Services.Interfaces;
using INVENTORY.SHARED.Dto;
using Microsoft.AspNetCore.Components;

namespace INVENTORY.CLIENT.Pages.Product
{
    public class GetProductDetailModel : ComponentBase
    {
        [Parameter]
        public string ProductId { get; set; }
        [Inject]
        public IProductService ProductService { get; set; }
        [Parameter]
        public ProductDto Product { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Product = await ProductService.GetProductById(new Guid(ProductId));
        }
    }
}
