using intCoders.Common.Models;
using wap2.data.models.Modules.Products;

namespace wap2.data.models.Modules.Vehicles;

public class Car : BaseModel
{
    public Guid MakeId { get; set; }

    public Brand Make { get; set; }

    public string Model { get; set; }

    public string Platform { get; set; }

    public string Year { get; set; }

    public string Motor { get; set; }

    public string CC { get; set; }

    public string Transmission { get; set; }

    public string Traction { get; set; }

    public string AssemblyCountry { get; set; }
    
}