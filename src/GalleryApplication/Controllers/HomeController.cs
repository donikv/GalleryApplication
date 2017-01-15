using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Threading.Tasks;
using ApplicationClasses;
using GalleryApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GalleryApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<User> _users;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(List<User> users,
        UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _users = users;
        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            ApplicationUser currentApplicationUserUser = await _userManager.GetUserAsync(HttpContext.User);
            var currentUser = _users.Find(s => s.Id == (Guid.Parse(currentApplicationUserUser.Id)));
            return View(currentUser);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
