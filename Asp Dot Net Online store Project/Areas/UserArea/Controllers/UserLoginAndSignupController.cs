using Asp_Dot_Net_Online_store_Project.DTOS.F_UserDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp_Dot_Net_Online_store_Project.Areas.UserArea.Controllers
{
    public class UserLoginAndSignupController : Controller
    {
        // GET: UserArea/UserLoginAndSignup
        public ActionResult SignUpView()
        {
            return View();
        }
        public ActionResult UserSignUp(UserInsertDTO userInsertDTO)
        {
            return View();
        }
    }
}