using INVENTORY.CLIENT.Services.Interfaces;
using INVENTORY.SHARED.Dto;
using Microsoft.AspNetCore.Components;

namespace INVENTORY.CLIENT.Pages.Product
{
    public class CreateProductModel : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        [Parameter]
        public ProductCreateDto ProductCreate { get; set; } = new ProductCreateDto();

        public async Task AddNewProduct()
        {
            await ProductService.CreateProduct(ProductCreate);
        }
    }
}
