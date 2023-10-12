using intCoders.Common.Models;

namespace wap2.data.models.Modules.Products;

public class ProductExchangeCode : BaseModel
{
    public string Code { get; set; }

    public Guid ProductId { get; set; }

    public Product Product { get; set; }
    
}