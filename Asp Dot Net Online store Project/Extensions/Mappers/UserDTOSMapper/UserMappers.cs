using Asp_Dot_Net_Online_store_Project.DTOS.F_UserDTOS;
using Asp_Dot_Net_Online_store_Project.Models.F_UsrModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp_Dot_Net_Online_store_Project.Extensions.Mappers.UserDTOSMapper
{
    public static class UserMappers
    {
       public static UserInsertModel map(this UserInsertDTO userInsertDto)
        {
            if (userInsertDto == null) return null;
            return new UserInsertModel
            {
                UserId = Guid.NewGuid(),
                UserName = userInsertDto.UserName,
                Email = userInsertDto.Email,
                City = userInsertDto.City,
                ContactNumber = userInsertDto.ContactNumber,
                Country = userInsertDto.Country,
                Gender = userInsertDto.Gender,
                Role = userInsertDto.Role 
                

            };
        }
    }
}