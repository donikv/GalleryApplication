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
        private readonly GalleryDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(GalleryDbContext context,
        UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context=context;
        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            ApplicationUser currentApplicationUserUser = await _userManager.GetUserAsync(HttpContext.User);
            var currentId = Guid.Parse(currentApplicationUserUser.Id);
            var currentUser = _context.Users.FirstOrDefault(s => s.Id.Equals(currentId));
            return View(currentUser);
        }

        [Authorize]
        [HttpGet("{Id}")]
        public IActionResult ShowAlbum(Guid Id)
        {
            var album = _context.Albums.FirstOrDefault(s => s.Id.Equals(Id));
            return View();
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
