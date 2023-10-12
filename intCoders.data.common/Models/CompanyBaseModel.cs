using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intCoders.Common.Models
{
    public abstract class CompanyBaseModel : BaseModel
    {
        public Guid CompanyId { get; set; }
    }
}
