using DBManager;
using ModelManager;

namespace DataManager
{
    public class UserAuditDM
    {
        private readonly ApplicationDbContext _context;

        public UserAuditDM(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Boolean> InsertUserAuditAsync(UserAuditModel userAuditModel)
        {
            try
            {
                UserAudit userAudit = new UserAudit
                {
                    UserId = userAuditModel.UserId,
                    DeceasedId = userAuditModel.DeceasedId,
                    EventDescription = userAuditModel.EventDescription,
                    Created = DateTime.Now
                };
                await _context.UserAudit.AddAsync(userAudit);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                // Aquí puedes loguear el error si es necesario
                throw;
            }
        }
    }
}
