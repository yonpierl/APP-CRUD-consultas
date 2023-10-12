using intCoders.Common.Models;
using System.Collections.ObjectModel;

namespace wap2.data.models.Modules.Products;

public  class Category : BaseModel
{
    public required string Name { get; set; }

    public string? Description { get; set; }

    public Category()
    {
       
    }

   
}
