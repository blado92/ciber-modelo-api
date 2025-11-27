using DBManager;
using Microsoft.EntityFrameworkCore;
using ModelManager;

namespace DataManager
{
    public class DeceasedDM
    {
        private readonly ApplicationDbContext _context;

        public DeceasedDM(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<DeceasedModel>> GetDeceasedByUserIdAsync(int userId)
        {
            var result = await(
                from vs in _context.ValidationState
                join d in _context.Deceased on vs.DeceasedId equals d.Id
                where vs.UserId == userId && vs.State == true
                select new DeceasedModel
                {
                    Id = d.Id,
                    Name = d.Name,
                    LastName = d.LastName,
                    Email = d.Email,
                    Address = d.Address,
                    EPS = d.EPS,
                    Birthday = d.Birthday,
                    DeceasedDate = d.DeceasedDate,
                    Created = d.Created,
                    BankingInstitution = d.BankingInstitution,
                    Nationality = d.Nationality,
                    Gender = d.Gender,
                    RetirementFund = d.RetirementFund,
                    Arl = d.Arl,
                    SeveranceFund = d.SeveranceFund,
                    IdentityDocument = d.IdentityDocument,
                    IdentityDocumentType = d.IdentityDocumentType,
                    MaritalStatus = d.MaritalStatus
                }
            ).ToListAsync();

            return result;
        }
    }
}
