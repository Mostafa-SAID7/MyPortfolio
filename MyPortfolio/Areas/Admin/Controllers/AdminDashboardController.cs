using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolio.Data;
using MyPortfolio.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminDashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminDashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // ✅ Dashboard counters
            ViewBag.ProjectCount = await _context.Projects.CountAsync();
            ViewBag.BlogCount = await _context.BlogPosts.CountAsync();
            ViewBag.MessageCount = await _context.ContactMessages.CountAsync();

            // ✅ Recent activity (latest 5 items from each table)
            var recentProjects = await _context.Projects
                .OrderByDescending(p => p.CreatedAt)
                .Take(5)
                .ToListAsync();

            var recentBlogs = await _context.BlogPosts
                .OrderByDescending(b => b.CreatedAt)
                .Take(5)
                .ToListAsync();

            var recentMessages = await _context.ContactMessages
                .OrderByDescending(m => m.CreatedAt)
                .Take(5)
                .ToListAsync();

            // Put them in a ViewModel to simplify the view
            var dashboardData = new DashboardViewModel
            {
                RecentProjects = recentProjects,
                RecentBlogs = recentBlogs,
                RecentMessages = recentMessages
            };

            return View(dashboardData);
        }
    }

    // ✅ Simple ViewModel for dashboard
    public class DashboardViewModel
    {
        public List<Project> RecentProjects { get; set; }
        public List<BlogPost> RecentBlogs { get; set; }
        public List<ContactMessage> RecentMessages { get; set; }
    }
}
