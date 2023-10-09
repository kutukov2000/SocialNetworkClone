using DataAccess.Data;
using DataAccess.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace SocialNetworkClone.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly SocialNetworkDbContext _context;
        private string _currentUserId => User.FindFirstValue(ClaimTypes.NameIdentifier);
        public UserController(SocialNetworkDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            User currentUser = _context.Users.Include(x => x.Posts).Where(x => x.Id == _currentUserId).FirstOrDefault();

            return View(currentUser);
        }
        [HttpGet]
        public IActionResult CreatePost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost(Post post)
        {
            post.UserId = _currentUserId;
            if (!ModelState.IsValid)
            {
                return View(post);
            }

            _context.Posts.Add(post);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult EditUser()
        {
            User user = _context.Users.Find(_currentUserId);

            if (user == null) return NotFound();

            return View(user);
        }


        [HttpPost]
        public IActionResult EditUser(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            User userToChange = _context.Users.Find(user.Id);

            userToChange.NickName = user.NickName;
            userToChange.FirstName = user.FirstName;
            userToChange.LastName = user.LastName;
            userToChange.BirthdayDate = user.BirthdayDate;
            userToChange.AvatarImageUrl = user.AvatarImageUrl;

            _context.Users.Update(userToChange);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
