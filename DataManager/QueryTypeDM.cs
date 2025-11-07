using DBManager;
using Microsoft.EntityFrameworkCore;
using ModelManager;

namespace DataManager
{
    public class QueryTypeDM
    {
        private readonly ApplicationDbContext _context;

        public QueryTypeDM(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<QueryTypeModel>> GetQueryTypesByUserAndDeceasedAsync(int userId, int deceasedId)
        {
            var result = await (
                from udr in _context.UserDeceasedRole
                join r in _context.Role on udr.RoleId equals r.Id
                join am in _context.AccessMatrix on r.Id equals am.RoleId
                join qt in _context.QueryType on am.QueryTypeId equals qt.Id
                where udr.UserId == userId && udr.DeceasedId == deceasedId
                select new QueryTypeModel
                {
                    Id = qt.Id,
                    Name = qt.Name,
                    Role = new RoleModel
                    {
                        Id = r.Id,
                        Name = r.Name,
                        Description = r.Description
                    }
                }
            ).ToListAsync();

            return result;
        }
    }
}
