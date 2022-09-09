using INVENTORY.CLIENT.Services.Interfaces;
using INVENTORY.SHARED.Dto;
using Microsoft.AspNetCore.Components;

namespace INVENTORY.CLIENT.Pages.Product
{
    public class GetProductsModel : ComponentBase
    {
        [Inject]
        public IProductService productService { get; set; }

        public IEnumerable<ProductDto> Products { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Products = await productService.GetProducts();
        }
    }
}
