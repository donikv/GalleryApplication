using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationClasses;
using ApplicationClasses.Interfaces;
using ApplicationClasses.Models;
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
        private readonly IUserRepository _repository;
        private readonly IAlbumRepository _albumRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserController(IUserRepository repository,IAlbumRepository albumRepository,
        UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _repository=repository;
            _albumRepository = albumRepository;
        }
        [Authorize]

        public async Task<IActionResult> Index()
        {
            ApplicationUser currentApplicationUserUser = await _userManager.GetUserAsync(HttpContext.User);
            var currentId = Guid.Parse(currentApplicationUserUser.Id);
            var currentUser = new User(currentId, currentApplicationUserUser.UserName, _albumRepository.GetUserAlbums(currentId));
            return View(currentUser);
        }

        [Authorize]
        [HttpGet("User/AccountDetails/{Id}")]
        public async Task<IActionResult> AccountDetails(Guid Id)
        {
            ApplicationUser currentApplicationUserUser = await _userManager.GetUserAsync(HttpContext.User);
            var currentId = Guid.Parse(currentApplicationUserUser.Id);
            var currentUser = new User(currentId, currentApplicationUserUser.UserName);
            return View(currentUser);
        }
        [Authorize]
        [HttpGet("User/ShowFriends/{Id}")]
        public async Task<IActionResult> ShowFriends(Guid Id)
        {
            ApplicationUser currentApplicationUserUser = await _userManager.GetUserAsync(HttpContext.User);
            var currentId = Guid.Parse(currentApplicationUserUser.Id);
            var friends = _repository.GetSubscribed(currentId);
            return View(friends);
        }
    }
}