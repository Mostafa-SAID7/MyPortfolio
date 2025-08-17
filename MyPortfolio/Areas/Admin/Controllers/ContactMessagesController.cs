using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactMessagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactMessagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ContactMessages
        public IActionResult Index()
        {
            var messages = _context.ContactMessages
                                   .OrderByDescending(m => m.CreatedAt)
                                   .ToList();
            return View(messages);
        }

        // GET: Admin/ContactMessages/Details/{id}
        public IActionResult Details(int id)
        {
            var message = _context.ContactMessages.FirstOrDefault(m => m.Id == id);
            if (message == null) return NotFound();
            return View(message);
        }

        // GET: Admin/ContactMessages/Delete/{id}
        public IActionResult Delete(int id)
        {
            var message = _context.ContactMessages.FirstOrDefault(m => m.Id == id);
            if (message == null) return NotFound();
            return View(message);
        }

        // POST: Admin/ContactMessages/DeleteConfirmed
        [HttpPost, ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var message = _context.ContactMessages.FirstOrDefault(m => m.Id == id);
            if (message != null)
            {
                _context.ContactMessages.Remove(message);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
