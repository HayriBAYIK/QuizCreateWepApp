using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace QuizCreateWepApp.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //var adminUserEMail = User.Claims.ToArray()[0].Value;

            var userClaim = User.Claims.FirstOrDefault(q => q.Type == ClaimTypes.Email);

            if (userClaim != null)
            {
                ViewBag.Email = userClaim.Value;
            }


        }
    }
}
