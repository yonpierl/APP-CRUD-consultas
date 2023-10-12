using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wap2.data.models.Modules.Customers;

namespace wap2.data.models.servicios
{
    public interface ISegment
    {
        Task<bool> UpdateSegmentAsync(Segment segment);

        Task<bool> AddSegmentAsync(Segment segment);

        Task<bool> DeleteSegmentAsync(Guid Id);

        Task<Segment> GetSegment(Guid Id);
    }
}
