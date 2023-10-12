using intCoders.Common.Models;

namespace wap2.data.models.Modules.UserManagement;

public class UserCompany : BaseModel
{
    public Guid CompanyId { get; set; }

    public Guid UserId { get; set; }

    public User User { get; set; }

    public Company Company { get; set; }
    
}