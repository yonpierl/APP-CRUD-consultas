using intCoders.Common.Models;

namespace wap2.data.models.Modules.Products;

public class ProductImage : BaseModel
{
    public string ImagePath { get; set; }

    public Guid ProductId { get; set; }
    
    public Product Product { get; set; }
}