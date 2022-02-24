using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuizCreateWepApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizCreateWepApp.Controllers
{
    [Authorize]
    public class AppUserController : BaseController
    {
        private DatabaseContext databaseContext;
        public AppUserController( DatabaseContext _databaseContext)
        {
            databaseContext = _databaseContext;
        }

        
       
        public IActionResult Index()
        {
            List<AppUser> appUser = databaseContext.AppUsers.ToList();
            return View(appUser);
        }
    }
}
