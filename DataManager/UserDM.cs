using DBManager;
using Microsoft.EntityFrameworkCore;
using ModelManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public class UserDM
    {

        private readonly ApplicationDbContext _context;

        public UserDM(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<UserModel?> GetUserByEmailPasswordAsync(string email, string password)
        {
            return await _context.User
                .Where(u => u.Email == email && u.Password == password)
                .Select(u => new UserModel
                {
                    Id = u.Id,
                    Name = u.Name,
                    LastName = u.LastName,
                    Email = u.Email,
                    Created = u.Created
                })
            .FirstOrDefaultAsync();
        }

    }
}
