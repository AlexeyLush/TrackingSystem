using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.DataAccess;
using Domain.Models;

namespace WorkingTimeTracking.Controllers
{
    public class PersonalStaticsController : Controller
    {
        private readonly TrackingDb _context;

        public PersonalStaticsController(TrackingDb context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var user = _context.Users.FirstOrDefault(x => x.Email == User.Identity.Name);
            return View(await _context.Tasks.Where(x => x.UserId.ToString() == user.Id).ToListAsync());
        }

        public async Task<IActionResult> Complete(Guid id)
        {
            var task = _context.Tasks.FirstOrDefault(x => x.Id == id);
            task.isEnd = true;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
