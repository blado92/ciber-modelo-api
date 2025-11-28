using DBManager;
using Microsoft.EntityFrameworkCore;
using ModelManager;

namespace DataManager
{
    public  class FieldDM
    {
        private readonly ApplicationDbContext _context;

        public FieldDM(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<FieldModel>> GetFieldsByQueryTypeAndAccessLevelAsync(int queryTypeId, int accessLevelId)
        {
            var result = await (
                from fal in _context.FieldAccessLevel
                join f in _context.Fields on fal.FieldId equals f.Id
                where fal.QueryTypeId == queryTypeId && fal.AccessLevelId == accessLevelId
                orderby f.Order
                select new FieldModel
                {
                    Id = f.Id,
                    Name = f.Name
                }
            ).ToListAsync();

            return result;
        }
    }
}
