using Asp_Dot_Net_Online_store_Project.Common.ApplicationDbContext;
using Asp_Dot_Net_Online_store_Project.Models.F_UsrModels;
using Asp_Dot_Net_Online_store_Project.Repositorys.UsersignUpRepo.F_IUserSignUpRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Asp_Dot_Net_Online_store_Project.Repositorys.UsersignUpRepo.F_UserSignUpRepo
{
    public class UserSignUpRepo : IUserSignUpRepo
    {
        private readonly AppDbContext _dbContext;

        public UserSignUpRepo(AppDbContext dbContext)
        {
            _dbContext=dbContext;
        }

        public async Task AddUser(UserInsertModel userInsertModel)
        {
            _dbContext.Users.Add(userInsertModel);
            await _dbContext.SaveChangesAsync();
        }
    }
}