using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebLicoreria.Models;

namespace WebLicoreria.Controllers
{
    [Authorize]
    public class ProductosController : Controller
    {
        private readonly FinalLicoreriaContext _context;

        public ProductosController(FinalLicoreriaContext context)
        {
            _context = context;
        }

        // GET: Productos
        public async Task<IActionResult> Index()
        {
            var finalLicoreriaContext = _context.Productos.Where(x => x.Estado !=-1).Include(p => p.IdCategoriaNavigation).ToListAsync();


            return View(await finalLicoreriaContext);
         }

        // GET: Productos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .Include(p => p.IdCategoriaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Productos/Create
        public IActionResult Create()
        {
            ViewData["tipoUnidad"] = new SelectList(new List<string> {"Caja","Docena","Paquete","Unidad" });
            ViewData["IdCategoria"] = new SelectList(_context.Categoria, "Id", "Descripcion");
            return View();
        }

        // POST: Productos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdCategoria,Codigo,Nombre,Descripcion,tipoUnidad,Stock,PrecioCompra,PrecioVenta")] Producto producto)
        {
            // Asignar valores predeterminados a Stock, PrecioCompra y PrecioVenta si están vacíos
            if (producto.Stock == null) producto.Stock = 0;
            if (producto.PrecioCompra == null) producto.PrecioCompra = 0;
            if (producto.PrecioVenta == null) producto.PrecioVenta = 0;


            if (!string.IsNullOrEmpty(producto.Codigo) && !string.IsNullOrEmpty(producto.Nombre) && !string.IsNullOrEmpty(producto.Descripcion))
            {
                producto.UsuarioRegistro = User.Identity.Name;
                producto.FechaRegistro = DateTime.Now;
                producto.Estado = 1;
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCategoria"] = new SelectList(_context.Categoria, "Id", "Id", producto.IdCategoria);
            return View(producto);
        }

        // GET: Productos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            
            ViewData["IdCategoria"] = new SelectList(_context.Categoria, "Id", "Descripcion", producto.IdCategoria);
            return View(producto);
        }

        // POST: Productos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdCategoria,Codigo,Nombre,Descripcion,tipoUnidad,Stock,PrecioCompra,PrecioVenta,UsuarioRegistro,FechaRegistro,Estado")] Producto producto)
        {
            if (id != producto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.Id))
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
           
            ViewData["IdCategoria"] = new SelectList(_context.Categoria, "Id", "Descripcion", producto.IdCategoria);
            return View(producto);
        }

        // GET: Productos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .Include(p => p.IdCategoriaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto != null)
            {
                producto.UsuarioRegistro = "Sis457";
                producto.Estado = -1;
                //_context.Productos.Remove(producto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(int id)
        {
            return _context.Productos.Any(e => e.Id == id);
        }
    }
}
