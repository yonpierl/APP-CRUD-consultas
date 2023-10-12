using intCoders.Common.Models;
using wap2.data.models.Modules.Vehicles;

namespace wap2.data.models.Modules.Products;

public class ProductCar : BaseModel
{
    public Guid CarId { get; set; }

    public Car Car { get; set; }

    public Guid ProductId { get; set; }

    public Product Pro { get; set; }
    
}