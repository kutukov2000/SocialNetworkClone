using Microsoft.AspNetCore.Mvc;
using SocialNetworkClone.Data;

namespace SocialNetworkClone.Controllers
{
    public class AdminController : Controller
    {
        SocialNetworkDbContext context = new SocialNetworkDbContext();
        public IActionResult AdminPage()
        {
            var Users = context.Users.ToList();
            return View(Users);
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
