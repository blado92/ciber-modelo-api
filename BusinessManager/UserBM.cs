using DataManager;
using DBManager;
using ModelManager;

namespace BusinessManager
{
    public class UserBM
    {

        private readonly UserDM userDM;

        public UserBM(ApplicationDbContext context)
        {
            userDM = new UserDM(context);
        }

        public async Task<UserModel?> GetUserByEmailPasswordAsync(string email, string password)
        {
            return await userDM.GetUserByEmailPasswordAsync(email, password);
        }

    }
}
