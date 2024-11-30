using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebLicoreria.Models;

namespace WebLicoreria.Controllers
{
    public class DetalleComprasController : Controller
    {
        private readonly FinalLicoreriaContext _context;

        public DetalleComprasController(FinalLicoreriaContext context)
        {
            _context = context;
        }

        // GET: DetalleCompras
        public async Task<IActionResult> Index()
        {
            var finalLicoreriaContext = _context.DetalleCompras.Include(d => d.IdCompraNavigation).Include(d => d.IdProductoNavigation);
            return View(await finalLicoreriaContext.ToListAsync());
        }

        // GET: DetalleCompras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleCompra = await _context.DetalleCompras
                .Include(d => d.IdCompraNavigation)
                .Include(d => d.IdProductoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (detalleCompra == null)
            {
                return NotFound();
            }

            return View(detalleCompra);
        }

        // GET: DetalleCompras/Create
        public IActionResult Create()
        {
            ViewData["IdCompra"] = new SelectList(_context.Compras, "Id", "Id");
            ViewData["IdProducto"] = new SelectList(_context.Productos, "Id", "Id");
            return View();
        }

        // POST: DetalleCompras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdCompra,IdProducto,PrecioCompra,PrecioVenta,Cantidad,Total,UsuarioRegistro,FechaRegistro,Estado")] DetalleCompra detalleCompra)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detalleCompra);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCompra"] = new SelectList(_context.Compras, "Id", "Id", detalleCompra.IdCompra);
            ViewData["IdProducto"] = new SelectList(_context.Productos, "Id", "Id", detalleCompra.IdProducto);
            return View(detalleCompra);
        }

        // GET: DetalleCompras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleCompra = await _context.DetalleCompras.FindAsync(id);
            if (detalleCompra == null)
            {
                return NotFound();
            }
            ViewData["IdCompra"] = new SelectList(_context.Compras, "Id", "Id", detalleCompra.IdCompra);
            ViewData["IdProducto"] = new SelectList(_context.Productos, "Id", "Id", detalleCompra.IdProducto);
            return View(detalleCompra);
        }

        // POST: DetalleCompras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdCompra,IdProducto,PrecioCompra,PrecioVenta,Cantidad,Total,UsuarioRegistro,FechaRegistro,Estado")] DetalleCompra detalleCompra)
        {
            if (id != detalleCompra.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detalleCompra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetalleCompraExists(detalleCompra.Id))
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
            ViewData["IdCompra"] = new SelectList(_context.Compras, "Id", "Id", detalleCompra.IdCompra);
            ViewData["IdProducto"] = new SelectList(_context.Productos, "Id", "Id", detalleCompra.IdProducto);
            return View(detalleCompra);
        }

        // GET: DetalleCompras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleCompra = await _context.DetalleCompras
                .Include(d => d.IdCompraNavigation)
                .Include(d => d.IdProductoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (detalleCompra == null)
            {
                return NotFound();
            }

            return View(detalleCompra);
        }

        // POST: DetalleCompras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detalleCompra = await _context.DetalleCompras.FindAsync(id);
            if (detalleCompra != null)
            {
                _context.DetalleCompras.Remove(detalleCompra);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetalleCompraExists(int id)
        {
            return _context.DetalleCompras.Any(e => e.Id == id);
        }
    }
}
