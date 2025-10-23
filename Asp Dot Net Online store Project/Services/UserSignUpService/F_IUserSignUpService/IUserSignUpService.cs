using Asp_Dot_Net_Online_store_Project.DTOS.F_UserDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Asp_Dot_Net_Online_store_Project.Services.UserSignUpService.F_IUserSignUpSerice
{
    public interface IUserSignUpService
    {
        Task AddUser(UserInsertDTO userInsertDTO);
    }
}