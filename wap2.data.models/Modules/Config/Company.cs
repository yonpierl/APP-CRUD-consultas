using intCoders.Common.Models;

namespace wap2.data.models.Modules.Config;

public class Company : BaseModel
{
    public string Name { get; set; }

    public string LeadContact { get; set; }
}