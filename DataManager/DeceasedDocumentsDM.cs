using DBManager;
using Microsoft.EntityFrameworkCore;
using ModelManager;

namespace DataManager
{
    public class DeceasedDocumentsDM
    {
        private readonly ApplicationDbContext _context;

        public DeceasedDocumentsDM(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<DeceasedDocumentsModel>> GetDocumentsByDeceasedIdAsync(int deceasedId)
        {
            var result = await (
                from dd in _context.DeceasedDocuments
                where dd.DeceasedId == deceasedId
                select new DeceasedDocumentsModel
                {
                    Id = dd.Id,
                    Name = dd.Name,
                    Url = dd.Url,
                    Created = dd.Created
                }
            ).ToListAsync();

            return result;
        }
    }
}
