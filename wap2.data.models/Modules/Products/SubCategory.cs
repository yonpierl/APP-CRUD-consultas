using intCoders.Common.Models;

namespace wap2.data.models.Modules.Products;

public class SubCategory : BaseModel
{
    public string Name { get; set; }

    public Guid CategoryId { get; set; }

    public Category Category { get; set; }

    public string? CustomLabel1 { get; set; }
    
    public string? CustomLabel2 { get; set; }
    
    public string? CustomLabel3 { get; set; }
}