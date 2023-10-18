using DataAccess.Data;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DataAccess.Controllers
{
    public class HomeController : Controller
    {
        private readonly SocialNetworkDbContext _context;
        public HomeController(SocialNetworkDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var postsWithUsers = _context.Posts.Include(p => p.User).Include(p => p.Comments).ToList();

            return View(postsWithUsers);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
