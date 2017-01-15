using System;
using System.Threading.Tasks;
using ApplicationClasses.Models;
using ApplicationClasses.Interfaces;
using GalleryApplication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GalleryApplication.Controllers
{
    public class SubsriptionsController : Controller
    {
        private readonly IUserRepository _repository;
        private readonly UserManager<ApplicationUser> _users;
        private readonly User _currentUser;

        public SubsriptionsController(IUserRepository repository,
            UserManager<ApplicationUser> userManager,User currentUser)
        {
            _repository = repository;
            _users = userManager;
            _currentUser = currentUser;
        }

        public async Task<IActionResult> Index()
        {
            ApplicationUser currentApplicationUser = await _users.GetUserAsync(HttpContext.User);
            var currentId = Guid.Parse(currentApplicationUser.Id);
            var currentUser = _repository.Get(currentId);
            return View(currentUser);
        }
    }
}