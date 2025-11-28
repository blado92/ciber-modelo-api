using DataManager;
using DBManager;
using ModelManager;

namespace BusinessManager
{
    public class DeceasedBM
    {
        private readonly DeceasedDM deceasedDM;
        private readonly UserAuditDM userAuditDM;

        public DeceasedBM(ApplicationDbContext context)
        {
            deceasedDM = new DeceasedDM(context);
            userAuditDM = new UserAuditDM(context);
        }

        public async Task<List<DeceasedModel>> GetDeceasedByUserIdAsync(int userId)
        {
            UserAuditModel userAudit = new UserAuditModel
            {
                UserId = userId,
                EventDescription = "Consulta de fallecidos por usuario"
            };
            await userAuditDM.InsertUserAuditAsync(userAudit);
            return await deceasedDM.GetDeceasedByUserIdAsync(userId);
        }
    }
}
