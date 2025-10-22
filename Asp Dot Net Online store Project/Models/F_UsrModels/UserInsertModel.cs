using Asp_Dot_Net_Online_store_Project.Common.Enums.F_EnumRoles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp_Dot_Net_Online_store_Project.Models.F_UsrModels
{
    public class UserInsertModel
    {
        [Key]
        public Guid UserId { get; set; }//Pk
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public Role Role { get; set; }
    }
}