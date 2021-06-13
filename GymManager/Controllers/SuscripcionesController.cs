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
    public class SuscripcionesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SuscripcionesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Suscripciones
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Suscripciones.Include(s => s.Clientes).Include(s => s.MetodosPagos).Include(s => s.Planes);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Suscripciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suscripciones = await _context.Suscripciones
                .Include(s => s.Clientes)
                .Include(s => s.MetodosPagos)
                .Include(s => s.Planes)
                .FirstOrDefaultAsync(m => m.IdSuscripcion == id);
            if (suscripciones == null)
            {
                return NotFound();
            }

            return View(suscripciones);
        }

        // GET: Suscripciones/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "FullName");
            ViewData["IdMetodoPago"] = new SelectList(_context.MetodosPagos, "IdMetodoPago", "Nombre");
            ViewData["IdPlan"] = new SelectList(_context.Planes, "IdPlan", "Descripcion1");
            return View();
        }

        // POST: Suscripciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSuscripcion,Fecha,IdCliente,Estado,IdMetodoPago,IdPlan,FechaInicio,FechaFin,Cantidad,PrecioUnit,SubTotal,Descuento,Total")] Suscripciones suscripciones)
        {
            if (ModelState.IsValid)
            {
                _context.Add(suscripciones);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Apellidos", suscripciones.IdCliente);
            ViewData["IdMetodoPago"] = new SelectList(_context.MetodosPagos, "IdMetodoPago", "Nombre", suscripciones.IdMetodoPago);
            ViewData["IdPlan"] = new SelectList(_context.Planes, "IdPlan", "Descripcion1", suscripciones.IdPlan);
            return View(suscripciones);
        }

        // GET: Suscripciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suscripciones = await _context.Suscripciones.FindAsync(id);
            if (suscripciones == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Apellidos", suscripciones.IdCliente);
            ViewData["IdMetodoPago"] = new SelectList(_context.MetodosPagos, "IdMetodoPago", "Nombre", suscripciones.IdMetodoPago);
            ViewData["IdPlan"] = new SelectList(_context.Planes, "IdPlan", "Descripcion1", suscripciones.IdPlan);
            return View(suscripciones);
        }

        // POST: Suscripciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdSuscripcion,Fecha,IdCliente,Estado,IdMetodoPago,IdPlan,FechaInicio,FechaFin,Cantidad,PrecioUnit,SubTotal,Descuento,Total")] Suscripciones suscripciones)
        {
            if (id != suscripciones.IdSuscripcion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suscripciones);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuscripcionesExists(suscripciones.IdSuscripcion))
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
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Apellidos", suscripciones.IdCliente);
            ViewData["IdMetodoPago"] = new SelectList(_context.MetodosPagos, "IdMetodoPago", "Nombre", suscripciones.IdMetodoPago);
            ViewData["IdPlan"] = new SelectList(_context.Planes, "IdPlan", "Descripcion1", suscripciones.IdPlan);
            return View(suscripciones);
        }

        // GET: Suscripciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suscripciones = await _context.Suscripciones
                .Include(s => s.Clientes)
                .Include(s => s.MetodosPagos)
                .Include(s => s.Planes)
                .FirstOrDefaultAsync(m => m.IdSuscripcion == id);
            if (suscripciones == null)
            {
                return NotFound();
            }

            return View(suscripciones);
        }

        // POST: Suscripciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var suscripciones = await _context.Suscripciones.FindAsync(id);
            _context.Suscripciones.Remove(suscripciones);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuscripcionesExists(int id)
        {
            return _context.Suscripciones.Any(e => e.IdSuscripcion == id);
        }
    }
}
