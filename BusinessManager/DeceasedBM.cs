using DataManager;
using DBManager;
using ModelManager;

namespace BusinessManager
{
    public class DeceasedBM
    {
        private readonly DeceasedDM deceasedDM;

        public DeceasedBM(ApplicationDbContext context)
        {
            deceasedDM = new DeceasedDM(context);
        }

        public async Task<List<DeceasedModel>> GetDeceasedByUserIdAsync(int userId)
        {
            return await deceasedDM.GetDeceasedByUserIdAsync(userId);
        }
    }
}
