using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GymManager.Data;
using GymManager.Models;
using Microsoft.AspNetCore.Authorization;

namespace GymManager.Controllers
{
    public class PlanesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlanesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Planes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Planes.Include(c => c.Moneda);
            return View(await applicationDbContext.OrderBy(a => a.DuracionDias).ToListAsync());
        }

        // GET: Planes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planes = await _context.Planes
                .Include(c => c.Moneda)
                .FirstOrDefaultAsync(m => m.IdPlan == id);
            if (planes == null)
            {
                return NotFound();
            }

            return View(planes);
        }

        // GET: Planes/Create
        public IActionResult Create()
        {
            ViewData["IdMoneda"] = new SelectList(_context.Monedas, "IdMoneda", "Nombre");
            return View();
        }

        // POST: Planes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPlan,Descripcion1,Descripcion2,CodigoAlterno,DuracionDias,Precio,Descuento,IdMoneda")] Planes planes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdMoneda"] = new SelectList(_context.Monedas, "IdMoneda", "Nombre", planes.IdMoneda);
            return View(planes);
        }
        // GET: Planes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planes = await _context.Planes.FindAsync(id);
            if (planes == null)
            {
                return NotFound();
            }
            ViewData["IdMoneda"] = new SelectList(_context.Monedas, "IdMoneda", "Nombre", planes.IdMoneda);
            return View(planes);
        }

        // POST: Planes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPlan,Descripcion1,Descripcion2,CodigoAlterno,DuracionDias,Precio,Descuento,IdMoneda")] Planes planes)
        {
            if (id != planes.IdPlan)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanesExists(planes.IdPlan))
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
            ViewData["IdMoneda"] = new SelectList(_context.Ciudades, "IdMoneda", "Nombre", planes.IdMoneda);
            return View(planes);
        }

        // GET: Planes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planes = await _context.Planes
                .Include(c => c.Moneda)
                .FirstOrDefaultAsync(m => m.IdPlan == id);
            if (planes == null)
            {
                return NotFound();
            }
            
            return View(planes);
        }

        // POST: Planes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var planes = await _context.Planes.FindAsync(id);
            _context.Planes.Remove(planes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanesExists(int id)
        {
            return _context.Planes.Any(e => e.IdPlan == id);
        }
    }
}
