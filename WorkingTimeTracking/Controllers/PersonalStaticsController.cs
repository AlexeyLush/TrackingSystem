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
            PersonalStatic personalStatic = new PersonalStatic();
            TaskProject taskProject = new TaskProject();
            personalStatic.NameOfProject = taskProject.Title;
            personalStatic.NameofTask = taskProject.Title;
            personalStatic.TimeOfWorkToday = DateTime.Now;
            personalStatic.TimeOfWorkAllTime = DateTime.Now;
            personalStatic.StatusOfTask = true;
            return View(await _context.PersonalStatics.ToListAsync());
        }


    }
}
