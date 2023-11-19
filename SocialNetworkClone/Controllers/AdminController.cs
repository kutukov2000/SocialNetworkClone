using DataAccess.Data;
using DataAccess.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DataAccess.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly SocialNetworkDbContext _context;
        private readonly UserManager<User> userManager;

        public AdminController(SocialNetworkDbContext context, UserManager<User> userManager)
        {
            _context = context;
            this.userManager = userManager;
        }
        [AllowAnonymous]
        public IActionResult AdminPage()
        {
            var Users = _context.Users.ToList();
            return View(Users);
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            user.RegistrationDate = DateTime.Now;

            if (!ModelState.IsValid)
            {
                return View(user);
            }

            _context.Users.Add(user);
            _context.SaveChanges();

            return RedirectToAction(nameof(AdminPage));
        }
        [HttpGet]
        public IActionResult CreatePost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost(Post post)
        {
            if (!ModelState.IsValid)
            {
                return View(post);
            }

            _context.Posts.Add(post);
            _context.SaveChanges();

            return RedirectToAction(nameof(AdminPage));
        }

        [HttpGet]
        public IActionResult EditUser(string id)
        {
            User? user = _context.Users.Find(id);

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

            User userToChange = _context.Users.Find(user.Id)!;

            userToChange.NickName = user.NickName;
            userToChange.FirstName = user.FirstName;
            userToChange.LastName = user.LastName;
            userToChange.BirthdayDate = user.BirthdayDate;
            userToChange.AvatarImageUrl = user.AvatarImageUrl;

            _context.Users.Update(userToChange);
            _context.SaveChanges();

            return RedirectToAction(nameof(AdminPage));
        }
        [AllowAnonymous]
        public IActionResult ShowPosts(string id)
        {
            var posts = _context.Posts.Where(p => p.UserId == id).ToList();

            return View(posts);
        }

        // delete user by ID
        public IActionResult Delete(string id)
        {
            var user = _context.Users.Where(x => x.Id == id).FirstOrDefault();

            if (user == null) return NotFound();

            _context.Users.Remove(user);
            _context.SaveChanges();

            return RedirectToAction("AdminPage");
        }
    }
}
