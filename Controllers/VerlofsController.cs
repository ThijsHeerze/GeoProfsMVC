using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GeoProfs.Data;
using GeoProfs.Models;

namespace GeoProfs.Controllers
{
    public class VerlofsController : Controller
    {
        private readonly GeoProfsContext _context;

        public VerlofsController(GeoProfsContext context)
        {
            _context = context;
        }

        // GET: Verlofs
        public async Task<IActionResult> Index()
        {
              return _context.Verlof != null ? 
                          View(await _context.Verlof.ToListAsync()) :
                          Problem("Entity set 'GeoProfsContext.Verlof'  is null.");
        }

        // GET: Verlofs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Verlof == null)
            {
                return NotFound();
            }

            var verlof = await _context.Verlof
                .FirstOrDefaultAsync(m => m.Id == id);
            if (verlof == null)
            {
                return NotFound();
            }

            return View(verlof);
        }

        // GET: Verlofs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Verlofs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,WerknemerId,ManagerId,RedenVerlof,Datum")] Verlof verlof)
        {
            if (ModelState.IsValid)
            {
                _context.Add(verlof);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(verlof);
        }

        // GET: Verlofs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Verlof == null)
            {
                return NotFound();
            }

            var verlof = await _context.Verlof.FindAsync(id);
            if (verlof == null)
            {
                return NotFound();
            }
            return View(verlof);
        }

        // POST: Verlofs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,WerknemerId,ManagerId,RedenVerlof,Datum")] Verlof verlof)
        {
            if (id != verlof.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(verlof);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VerlofExists(verlof.Id))
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
            return View(verlof);
        }

        // GET: Verlofs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Verlof == null)
            {
                return NotFound();
            }

            var verlof = await _context.Verlof
                .FirstOrDefaultAsync(m => m.Id == id);
            if (verlof == null)
            {
                return NotFound();
            }

            return View(verlof);
        }

        // POST: Verlofs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Verlof == null)
            {
                return Problem("Entity set 'GeoProfsContext.Verlof'  is null.");
            }
            var verlof = await _context.Verlof.FindAsync(id);
            if (verlof != null)
            {
                _context.Verlof.Remove(verlof);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VerlofExists(int id)
        {
          return (_context.Verlof?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
