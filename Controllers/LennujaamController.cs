using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lennujaam.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Lennujaam.Controllers
{
    public class LennujaamController : Controller
    {
        private readonly ApplicationDbContext _context;
        public LennujaamController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Lennujaam = await _context.Lennujaam .FirstOrDefaultAsync(m => m.Id == id);

            if (Lennujaam == null)
            {
                return NotFound();
            }

            return View(Lennujaam);
        }

    }
}
