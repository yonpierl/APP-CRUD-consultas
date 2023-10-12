using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wap2.data.models.Modules.Customers;

namespace wap2.data.models.servicios
{
    public class SegmentServicio : ISegment
    {
        public SQLiteAsyncConnection _database;

        public SegmentServicio(string DbPath)
        {
            _database = new SQLiteAsyncConnection(DbPath);

        }
        public async Task<bool> AddSegmentAsync(Segment segment)
        {
            segment.Id = Guid.NewGuid();
            await _database.InsertAsync(segment);
            return await Task.FromResult(true); 
        }

        public async Task<bool> UpdateSegmentAsync(Segment segment)
        {
            if (segment.Id == Guid.Empty)
            {
                await _database.UpdateAsync(segment);
            }
            else
            {
                await _database.InsertAsync(segment);
            }
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteSegmentAsync(Guid Id)
        {
            await _database.DeleteAsync<Segment>(Id);
            return await Task.FromResult(true);
        }

        public async Task<Segment> GetSegment(Guid Id)
        {
            throw new NotImplementedException();
        }

       
    }
}
