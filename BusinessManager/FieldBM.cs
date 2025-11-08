using DataManager;
using DBManager;
using ModelManager;

namespace BusinessManager
{
    public class FieldBM
    {
        private readonly FieldDM fieldDM;

        public FieldBM(ApplicationDbContext context)
        {
            fieldDM = new FieldDM(context);
        }

        public async Task<List<FieldModel>> GetFieldsByQueryTypeAndAccessLevelAsync(int queryTypeId, int accessLevelId)
        {
            return await fieldDM.GetFieldsByQueryTypeAndAccessLevelAsync(queryTypeId, accessLevelId);
        }
    }
}
