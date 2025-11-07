using DataManager;
using DBManager;
using ModelManager;

namespace BusinessManager
{
    public class QueryTypeBM
    {
        private readonly QueryTypeDM queryTypeDM;

        public QueryTypeBM(ApplicationDbContext context)
        {
            queryTypeDM = new QueryTypeDM(context);
        }

        public async Task<List<QueryTypeModel>> GetQueryTypesByUserAndDeceasedAsync(int userId, int deceasedId)
        {
            return await queryTypeDM.GetQueryTypesByUserAndDeceasedAsync(userId, deceasedId);
        }
    }
}
