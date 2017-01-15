using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationClasses;
using GalleryApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace GalleryApplication.Controllers
{
    /*
     * Mozemo li predati usera (ovog naseg) u konstruktor za ovaj controller.
     *Jer ovako ga trazimo trazimo po svim userima na osnovu id-a koji dobivamo na ovaj njihov nacin, a to se sigurno tak ne radi.
     * Isti sistem bi trebali imati na svim kontrolerima, ak znamo.
     */
    public class UserController : Controller
    {
        private readonly GalleryDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserController(GalleryDbContext context,
        UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
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
        [HttpGet("User/AccountDetails/{Id}")]
        public IActionResult AccountDetails(Guid Id)
        {
            var currentUser = _context.Users.FirstOrDefault(s => s.Id.Equals(Id));
            return View(currentUser);
        }
        [Authorize]
        [HttpGet("User/ShowFriends/{Id}")]
        public IActionResult ShowFriends(Guid Id)
        {
            var user = _context.Users.FirstOrDefault(s => s.Id.Equals(Id));
            var friends = user.SubscribedTo.ToList();
            return View(friends);
        }
    }
}