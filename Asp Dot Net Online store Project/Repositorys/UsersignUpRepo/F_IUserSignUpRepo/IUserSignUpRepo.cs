using Asp_Dot_Net_Online_store_Project.DTOS.F_UserDTOS;
using Asp_Dot_Net_Online_store_Project.Models.F_UsrModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Asp_Dot_Net_Online_store_Project.Repositorys.UsersignUpRepo.F_IUserSignUpRepo
{
    public interface IUserSignUpRepo
    {
        Task AddUser(UserInsertModel userInsertModel);

    }
}