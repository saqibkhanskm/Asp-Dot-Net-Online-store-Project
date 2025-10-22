using Asp_Dot_Net_Online_store_Project.Common.Enums.F_EnumRoles;
using System;

namespace Asp_Dot_Net_Online_store_Project.DTOS.F_UserDTOS
{
    public class UserInsertDTO
    {

        public Guid UserId { get; set; }//Pk
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public Role Role { get; set; }
    }
    public class UserUpdateDTO
    {
        public Guid UserId { get; set; }//Pk
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public Role Role { get; set; }
    }
    public class GetUserDTO
    {
        public Guid UserId { get; set; }//Pk
        public string FullName {  get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public Role Role { get; set; }
    }
    public class RemoveUserDTO
    {
        public Guid UserId { get; set; }//Pk
    }
}