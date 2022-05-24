using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EComerce.Data;
using Shopping.Models;

namespace Shopping.Controllers
{
    public class CorreiosController : Controller
    {
        private readonly DBContext _context;

        public CorreiosController(DBContext context)
        {
            _context = context;
        }

        // GET: Correios
        public async Task<IActionResult> Index()
        {
              return _context.Correios != null ? 
                          View(await _context.Correios.ToListAsync()) :
                          Problem("Entity set 'DBContext.Correio'  is null.");
        }

        // GET: Correios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Correios == null)
            {
                return NotFound();
            }

            var correio = await _context.Correios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (correio == null)
            {
                return NotFound();
            }

            return View(correio);
        }

        // GET: Correios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Correios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Prazo,Valor")] Correio correio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(correio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(correio);
        }

        // GET: Correios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Correios == null)
            {
                return NotFound();
            }

            var correio = await _context.Correios.FindAsync(id);
            if (correio == null)
            {
                return NotFound();
            }
            return View(correio);
        }

        // POST: Correios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Prazo,Valor")] Correio correio)
        {
            if (id != correio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(correio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CorreioExists(correio.Id))
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
            return View(correio);
        }

        // GET: Correios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Correios == null)
            {
                return NotFound();
            }

            var correio = await _context.Correios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (correio == null)
            {
                return NotFound();
            }

            return View(correio);
        }

        // POST: Correios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Correios == null)
            {
                return Problem("Entity set 'DBContext.Correio'  is null.");
            }
            var correio = await _context.Correios.FindAsync(id);
            if (correio != null)
            {
                _context.Correios.Remove(correio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CorreioExists(int id)
        {
          return (_context.Correios?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
