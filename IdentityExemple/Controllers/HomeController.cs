using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityExemple.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        public HomeController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Secret()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> Login(string username, string password)
        {
            //Login functionality

            var user = await _userManager.FindByNameAsync(username);

            if(user != null)
            {
                //sign in
            }

            return RedirectToAction("Index");
        }

        public IActionResult Register()
        {
            return View();
        }

        public async Task<IActionResult> Register(string username, string password)
        {
            //Register functionality

            var user = new IdentityUser
            {
                UserName = username,
                Email = ""

            };

            var result = await _userManager.CreateAsync(user, password);

            if(result.Succeeded)
            {
                //sign user here
            }

            return RedirectToAction("Index");
        }
    }
}

