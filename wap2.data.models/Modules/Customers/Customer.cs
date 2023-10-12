
using intCoders.Common.Models;
using Company = wap2.data.models.Modules.Config.Company;

namespace wap2.data.models.Modules.Customers;

public class Customer : BaseModel
{
    public string Name { get; set; }

    public string Address { get; set; }

    public Guid? CompanyId { get; set; }

    public Company? Company { get; set; }
}