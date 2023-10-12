using intCoders.Common.Models;

namespace wap2.data.models.Modules.Products;

public class Product : BaseModel
{
    public string Code { get; set; }
    
    public string Name { get; set; }

    public Guid CategoryId { get; set; }

    public Guid SubCategoryId { get; set; }

    public Category Category { get; set; }

    public SubCategory SubCategory { get; set; }

    public Guid BrandId { get; set; }

    public Brand Brand { get; set; }
}