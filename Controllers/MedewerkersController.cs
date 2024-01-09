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
    public class MedewerkersController : Controller
    {
        private readonly GeoProfsContext _context;

        public MedewerkersController(GeoProfsContext context)
        {
            _context = context;
        }

        // GET: Medewerkers
        public async Task<IActionResult> Index()
        {
              return _context.Medewerker != null ? 
                          View(await _context.Medewerker.ToListAsync()) :
                          Problem("Entity set 'GeoProfsContext.Medewerker'  is null.");
        }

        // GET: Medewerkers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Medewerker == null)
            {
                return NotFound();
            }

            var medewerker = await _context.Medewerker
                .FirstOrDefaultAsync(m => m.MedewerkerId == id);
            if (medewerker == null)
            {
                return NotFound();
            }

            return View(medewerker);
        }

        // GET: Medewerkers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Medewerkers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MedewerkerId,AfdelingId,Naam,Functie")] Medewerker medewerker)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medewerker);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medewerker);
        }

        // GET: Medewerkers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Medewerker == null)
            {
                return NotFound();
            }

            var medewerker = await _context.Medewerker.FindAsync(id);
            if (medewerker == null)
            {
                return NotFound();
            }
            return View(medewerker);
        }

        // POST: Medewerkers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MedewerkerId,AfdelingId,Naam,Functie")] Medewerker medewerker)
        {
            if (id != medewerker.MedewerkerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medewerker);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedewerkerExists(medewerker.MedewerkerId))
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
            return View(medewerker);
        }

        // GET: Medewerkers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Medewerker == null)
            {
                return NotFound();
            }

            var medewerker = await _context.Medewerker
                .FirstOrDefaultAsync(m => m.MedewerkerId == id);
            if (medewerker == null)
            {
                return NotFound();
            }

            return View(medewerker);
        }

        // POST: Medewerkers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Medewerker == null)
            {
                return Problem("Entity set 'GeoProfsContext.Medewerker'  is null.");
            }
            var medewerker = await _context.Medewerker.FindAsync(id);
            if (medewerker != null)
            {
                _context.Medewerker.Remove(medewerker);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedewerkerExists(int id)
        {
          return (_context.Medewerker?.Any(e => e.MedewerkerId == id)).GetValueOrDefault();
        }
    }
}
