using Asp_Dot_Net_Online_store_Project.DTOS.F_UserDTOS;
using Asp_Dot_Net_Online_store_Project.Extensions.Mappers.UserDTOSMapper;
using Asp_Dot_Net_Online_store_Project.Services.UserSignUpService.F_IUserSignUpSerice;
using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Asp_Dot_Net_Online_store_Project.Services.UserSignUpService.F_UserSignUpService
{
    public class UserSignUpService : IUserSignUpService
    {
        private readonly IUserSignUpService _userSignUpService;
        public UserSignUpService(IUserSignUpService userSignUpService)
        {
            _userSignUpService= userSignUpService;
        }
        public async Task AddUser(UserInsertDTO userInsertDTO)
        {
            var userInsertModel = userInsertDTO.map();
            await _userSignUpService.AddUser(userInsertDTO);
        }
    }
}