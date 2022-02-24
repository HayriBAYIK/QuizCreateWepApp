using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using QuizCreateWepApp.Entities;
using QuizCreateWepApp.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace QuizCreateWepApp.Controllers
{
    public class LoginController : Controller
    {
        private DatabaseContext databaseContext;
        public LoginController(DatabaseContext _databaseContext)
        {
            databaseContext = _databaseContext;
        }
        public IActionResult Index()
        {
            LoginVM loginVM = new LoginVM();

            return View(loginVM);
        }


        [HttpPost]
        public async Task<IActionResult> Index(LoginVM model)
        {
            if (ModelState.IsValid)
            {

                AppUser appUser = databaseContext.AppUsers.FirstOrDefault(q => q.Email == model.Email && q.Password == model.Password);


                if (appUser != null)
                {


                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, appUser.Email),
                    new Claim(ClaimTypes.Name, appUser.Id.ToString())
                };

                    var userIdentity = new ClaimsIdentity(claims, "login");

                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                    await HttpContext.SignInAsync(principal);


                    return RedirectToAction("ExamList", "Exam");

                }

            }

            return View(model);
        }


        public async Task<IActionResult> Logout()
        {

            await HttpContext.SignOutAsync();

            return RedirectToAction("Index", "Login");

        }
    }
}