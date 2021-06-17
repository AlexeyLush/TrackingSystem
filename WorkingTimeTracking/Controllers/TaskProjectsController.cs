using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.DataAccess;
using Domain.Models;
using ClosedXML.Excel;
using System.IO;

namespace WorkingTimeTracking.Controllers
{
    public class TaskProjectsController : Controller
    {
        private readonly TrackingDb _context;

        public TaskProjectsController(TrackingDb context)
        {
            _context = context;
        }

        public RedirectResult Redirect()
        {
            return Redirect("~/PersonalStatics/Index");
        }


        public async Task<IActionResult> Index(string search)
        {
            ViewData["GetNamesdetails"] = search;

            var query = from x in _context.Tasks select x;
            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(x => x.Title.Contains(search));
            }

            return View(await query.AsNoTracking().ToListAsync());
        }
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


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TaskProject taskProject)
        {
            if (ModelState.IsValid)
            {

                if (taskProject.StartDate < DateTime.Now)
                {
                    ModelState.AddModelError(string.Empty, "Дата началы должна быть как минимум со следующего дня");
                    return View(taskProject);
                }

                if (taskProject.EndDate <= taskProject.StartDate)
                {
                   ModelState.AddModelError(string.Empty, "Дата окончания должна быть больше даты начала");
                   return View(taskProject);
                }
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


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, TaskProject taskProject)
        {
            if (id != taskProject.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (taskProject.StartDate < DateTime.Now)
                {
                    ModelState.AddModelError(string.Empty, "Дата началы должна быть как минимум со следующего дня");
                    return View(taskProject);
                }

                if (taskProject.EndDate <= taskProject.StartDate)
                {
                    ModelState.AddModelError(string.Empty, "Дата окончания должна быть больше даты начала");
                    return View(taskProject);
                }
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

            var taskProject = await _context.Tasks.FindAsync(id);
            if (taskProject == null)
            {
                return NotFound();
            }

            _context.Tasks.Remove(taskProject);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool TaskProjectExists(Guid id)
        {
            return _context.Tasks.Any(e => e.Id == id);
        }

        public IActionResult Excel()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Задачи");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Проект";
                worksheet.Cell(currentRow, 2).Value = "Задача";
                worksheet.Cell(currentRow, 3).Value = "Пользователь";
                worksheet.Cell(currentRow, 4).Value = "Начло";
                worksheet.Cell(currentRow, 5).Value = "Конец";
                worksheet.Cell(currentRow, 6).Value = "Тип";
                worksheet.Cell(currentRow, 7).Value = "Статус";
                foreach (var task in _context.Tasks.ToList())
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = _context.Projects.FirstOrDefault(x => x.Id == task.ProjectId).Title;
                    worksheet.Cell(currentRow, 2).Value = task.Title;
                    worksheet.Cell(currentRow, 3).Value = _context.Users.FirstOrDefault(x => x.Id == task.UserId.ToString()).Email;
                    worksheet.Cell(currentRow, 4).Value = task.StartDate.ToString("dd/MM/yyyy");
                    worksheet.Cell(currentRow, 5).Value = task.EndDate.ToString("dd/MM/yyyy");

                    if (task.TaskType == TaskType.Analytics)
                    {
                        worksheet.Cell(currentRow, 6).Value = "Аналитика";
                    }
                    else if (task.TaskType == TaskType.Documenting)
                    {
                        worksheet.Cell(currentRow, 6).Value = "Документирование";
                    }
                    else if (task.TaskType == TaskType.Programming)
                    {
                        worksheet.Cell(currentRow, 6).Value = "Программирование";
                    }

                    worksheet.Cell(currentRow, 7).Value = "Активно";
                    if ((task.EndDate - DateTime.Now).TotalDays < 3)
                    {
                        worksheet.Cell(currentRow, 7).Value = "Менее 3 дней";
                    }
                    if ((task.EndDate - DateTime.Now).TotalDays < 1)
                    {
                        worksheet.Cell(currentRow, 7).Value = "Менее дня";
                    }
                    if ((task.EndDate - DateTime.Now).TotalDays < 0)
                    {
                        worksheet.Cell(currentRow, 7).Value = "Просрочено";
                    }
                    if (task.isEnd)
                    {
                        worksheet.Cell(currentRow, 7).Value = "Выполнено";
                    }
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "tasks.xlsx");
                }
            }
        }
    }
}
