using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GymManager.Data;
using GymManager.Models;

namespace GymManager.Controllers
{
    public class MetodosPagosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MetodosPagosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MetodosPagos
        public async Task<IActionResult> Index()
        {
            return View(await _context.MetodosPagos.ToListAsync());
        }

        // GET: MetodosPagos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var metodosPagos = await _context.MetodosPagos
                .FirstOrDefaultAsync(m => m.IdMetodoPago == id);
            if (metodosPagos == null)
            {
                return NotFound();
            }

            return View(metodosPagos);
        }

        // GET: MetodosPagos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MetodosPagos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMetodoPago,Nombre")] MetodosPagos metodosPagos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(metodosPagos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(metodosPagos);
        }

        // GET: MetodosPagos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var metodosPagos = await _context.MetodosPagos.FindAsync(id);
            if (metodosPagos == null)
            {
                return NotFound();
            }
            return View(metodosPagos);
        }

        // POST: MetodosPagos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMetodoPago,Nombre")] MetodosPagos metodosPagos)
        {
            if (id != metodosPagos.IdMetodoPago)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(metodosPagos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MetodosPagosExists(metodosPagos.IdMetodoPago))
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
            return View(metodosPagos);
        }

        // GET: MetodosPagos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var metodosPagos = await _context.MetodosPagos
                .FirstOrDefaultAsync(m => m.IdMetodoPago == id);
            if (metodosPagos == null)
            {
                return NotFound();
            }

            return View(metodosPagos);
        }

        // POST: MetodosPagos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var metodosPagos = await _context.MetodosPagos.FindAsync(id);
            _context.MetodosPagos.Remove(metodosPagos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MetodosPagosExists(int id)
        {
            return _context.MetodosPagos.Any(e => e.IdMetodoPago == id);
        }
    }
}
