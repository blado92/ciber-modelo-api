using DataManager;
using DBManager;
using ModelManager;

namespace BusinessManager
{
    public class QueryTypeBM
    {
        private readonly QueryTypeDM queryTypeDM;
        private readonly UserAuditDM userAuditDM;

        public QueryTypeBM(ApplicationDbContext context)
        {
            queryTypeDM = new QueryTypeDM(context);
            userAuditDM = new UserAuditDM(context);
        }

        public async Task<List<QueryTypeModel>> GetQueryTypesByUserAndDeceasedAsync(int userId, int deceasedId)
        {
            UserAuditModel userAudit = new UserAuditModel
            {
                UserId = userId,
                DeceasedId = deceasedId,
                EventDescription = "Consulta de los tipos de consultar por usuario y fallecido"
            };
            await userAuditDM.InsertUserAuditAsync(userAudit);
            return await queryTypeDM.GetQueryTypesByUserAndDeceasedAsync(userId, deceasedId);
        }
    }
}
