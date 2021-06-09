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
    public class TaskProjectsController : Controller
    {
        private readonly TrackingDb _context;

        public TaskProjectsController(TrackingDb context)
        {
            _context = context;
        }

        //GET: TaskProjects
        //GET: TaskProjects
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Tasks.ToListAsync());
        //}

        public async Task<IActionResult> Index(string search)
        {
            ViewData["GetNamesdetails"] = search;

            var query = from x in _context.Tasks select x;
            if(!String.IsNullOrEmpty(search))
            {
                query = query.Where(x => x.Title.Contains(search));
            }

            return View(await query.AsNoTracking().ToListAsync());
        }

        //[HttpPost]
        //public string Index(string searchString, bool notUsed)
        //{
        //    return "From [HttpPost]Index: filter on " + searchString;
        //}

        // GET: TaskProjects/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskProject = await _context.Tasks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (taskProject == null)
            {
                return NotFound();
            }

            return View(taskProject);
        }

        // GET: TaskProjects/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TaskProjects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,StartDate,EndDate,TaskType")] TaskProject taskProject)
        {
            if (ModelState.IsValid)
            {
                taskProject.Id = Guid.NewGuid();
                _context.Add(taskProject);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(taskProject);
        }

        // GET: TaskProjects/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskProject = await _context.Tasks.FindAsync(id);
            if (taskProject == null)
            {
                return NotFound();
            }
            return View(taskProject);
        }

        // POST: TaskProjects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Title,StartDate,EndDate,TaskType")] TaskProject taskProject)
        {
            if (id != taskProject.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taskProject);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaskProjectExists(taskProject.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(taskProject);
        }

        // GET: TaskProjects/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskProject = await _context.Tasks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (taskProject == null)
            {
                return NotFound();
            }

            return View(taskProject);
        }

        // POST: TaskProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var taskProject = await _context.Tasks.FindAsync(id);
            _context.Tasks.Remove(taskProject);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaskProjectExists(Guid id)
        {
            return _context.Tasks.Any(e => e.Id == id);
        }
    }
}
