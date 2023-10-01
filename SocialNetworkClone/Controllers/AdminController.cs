using DataAccess.Data;
using DataAccess.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DataAccess.Controllers
{
    public class AdminController : Controller
    {
        private readonly SocialNetworkDbContext _context;
        public AdminController(SocialNetworkDbContext context)
        {
            _context = context;
        }
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
        public IActionResult EditUser(int id)
        {
            var item = _context.Users.Find(id);

            if (item == null) return NotFound();

            return View(item);
        }

        [HttpPost]
        public IActionResult EditUser(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            _context.Users.Update(user);
            _context.SaveChanges();

            return RedirectToAction(nameof(AdminPage));
        }

        public IActionResult ShowPosts(int id)
        {
            var posts = _context.Posts.Where(p => p.UserId == id).ToList();

            if (posts.Count == 0) return NotFound();

            return View(posts);
        }

        // delete user by ID
        public IActionResult Delete(int id)
        {
            var item = _context.Users.Find(id);

            if (item == null) return NotFound();

            _context.Users.Remove(item);
            _context.SaveChanges();

            return RedirectToAction("AdminPage");
        }
    }
}
