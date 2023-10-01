using Microsoft.AspNetCore.Mvc;
using DataAccess.Data;
using DataAccess.Data.Entities;

namespace DataAccess.Controllers
{
    public class AdminController : Controller
    {
        SocialNetworkDbContext context = new SocialNetworkDbContext();
        public IActionResult AdminPage()
        {
            var Users = context.Users.ToList();
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


            context.Users.Add(user);
            context.SaveChanges();

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

            context.Posts.Add(post);
            context.SaveChanges();

            return RedirectToAction(nameof(AdminPage));
        }

        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var item = context.Users.Find(id);

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

            context.Users.Update(user);
            context.SaveChanges();

            return RedirectToAction(nameof(AdminPage));
        }

        public IActionResult ShowPosts(int id)
        {
            var posts = context.Posts.Where(p => p.UserId == id).ToList();

            if (posts.Count == 0) return NotFound();

            return View(posts);
        }

        // delete user by ID
        public IActionResult Delete(int id)
        {
            var item = context.Users.Find(id);

            if (item == null) return NotFound();

            context.Users.Remove(item);
            context.SaveChanges();

            return RedirectToAction("AdminPage");
        }
    }
}
