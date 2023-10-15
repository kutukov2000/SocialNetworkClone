using DataAccess.Data;
using DataAccess.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace SocialNetworkClone.Controllers
{

    public class UserController : Controller
    {
        private readonly SocialNetworkDbContext _context;
        private string _currentUserId => User.FindFirstValue(ClaimTypes.NameIdentifier);
        public UserController(SocialNetworkDbContext context)
        {
            _context = context;
        }
        [Authorize]
        public IActionResult Index()
        {
            User currentUser = _context.Users.Include(x => x.Posts).Where(x => x.Id == _currentUserId).FirstOrDefault();

            ViewBag.CurrentUserId = _currentUserId;

            return View(currentUser);
        }
        public IActionResult ShowUserPage(string userId)
        {
            User currentUser = _context.Users.Include(x => x.Posts).Where(x => x.Id == userId).FirstOrDefault();

            ViewBag.CurrentUserId = _currentUserId;

            return View(nameof(Index), currentUser);
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

        [HttpGet]
        public IActionResult EditPost(int id)
        {
            Post post = _context.Posts.Find(id);

            if (post == null) return NotFound();

            return View(post);
        }


        [HttpPost]
        public IActionResult EditPost(Post post)
        {
            if (!ModelState.IsValid)
            {
                return View(post);
            }

            Post postToChange = _context.Posts.Find(post.Id);

            postToChange.UserId = _currentUserId;
            postToChange.TextContent = post.TextContent;
            postToChange.ImageLink = post.ImageLink;

            _context.Posts.Update(postToChange);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
