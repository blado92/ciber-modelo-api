using DataManager;
using DBManager;
using ModelManager;

namespace BusinessManager
{
    public class DeceasedDocumentsBM
    {
        private readonly DeceasedDocumentsDM deceasedDocumentsDM;

        public DeceasedDocumentsBM(ApplicationDbContext context)
        {
            deceasedDocumentsDM = new DeceasedDocumentsDM(context);
        }

        public async Task<List<DeceasedDocumentsModel>> GetDocumentsByDeceasedIdAsync(int deceasedId)
        {
            return await deceasedDocumentsDM.GetDocumentsByDeceasedIdAsync(deceasedId);
        }
    }
}
