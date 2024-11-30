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
    public class ComprasController : Controller
    {
        private readonly FinalLicoreriaContext _context;

        public ComprasController(FinalLicoreriaContext context)
        {
            _context = context;
        }

        // GET: Compras
        public async Task<IActionResult> Index()
        {
            var finalLicoreriaContext = _context.Compras.Include(c => c.IdProveedorNavigation);
            return View(await finalLicoreriaContext.ToListAsync());
        }

        // GET: Compras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.Compras
                .Include(c => c.IdProveedorNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (compra == null)
            {
                return NotFound();
            }

            return View(compra);
        }

        // GET: Compras/Create
        public IActionResult Create()
        {

            var proveedores = _context.Proveedors.ToList();
            if (proveedores == null || proveedores.Count == 0)
            {
                // Si no hay proveedores, puedes asignar una lista vacía o algún valor por defecto.
                ViewData["IdProveedor"] = new SelectList(new List<Proveedor>(), "Id", "razonSocial");
            }
            else
            {
                ViewData["IdProveedor"] = new SelectList(proveedores, "Id", "razonSocial");
            }
            // Cargar productos correctamente, no SelectListItem
            var productos = _context.Productos.ToList();  // Obtener los productos directamente
            ViewBag.Productos = productos;  // Asignar productos a ViewBag para pasarlos a la vista

            // Cargar las opciones de TipoDocumento
            var tipoDocumentoOptions = new List<SelectListItem>
    {
        new SelectListItem { Value = "Factura", Text = "Factura" },
        new SelectListItem { Value = "Recibo", Text = "Recibo" }
    };

            ViewData["TipoDocumento"] = tipoDocumentoOptions;  // Pasar las opciones a la vista


            return View();
        }

        // POST: Compras/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Compra compra, List<DetalleCompra> detallesCompra)
        {
            if (ModelState.IsValid)
            {
                // Registrar la compra
                _context.Add(compra);
                await _context.SaveChangesAsync();

                // Registrar los detalles de la compra
                foreach (var detalle in detallesCompra)
                {
                    detalle.IdCompra = compra.Id;  // Asignar el IdCompra a cada detalle
                    _context.DetalleCompras.Add(detalle);  // Asegúrate de que la tabla se llama DetalleCompras
                }

                await _context.SaveChangesAsync();

                // Redirigir al listado de compras
                return RedirectToAction(nameof(Index));
            }

            // Si hay un error en el modelo, recargar los datos
            ViewData["IdProveedor"] = new SelectList(_context.Proveedors, "Id", "Nombre", compra.IdProveedor);
            ViewData["Productos"] = new SelectList(_context.Productos, "Id", "Nombre");
            return View(compra);
        }

        // GET: Compras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.Compras.FindAsync(id);
            if (compra == null)
            {
                return NotFound();
            }

            ViewData["IdProveedor"] = new SelectList(_context.Proveedors, "Id", "Nombre", compra.IdProveedor);
            return View(compra);
        }

        // POST: Compras/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdProveedor,TipoDocumento,NumeroDocumento,MontoTotal,UsuarioRegistro,FechaRegistro,Estado")] Compra compra)
        {
            if (id != compra.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(compra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompraExists(compra.Id))
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
            ViewData["IdProveedor"] = new SelectList(_context.Proveedors, "Id", "Nombre", compra.IdProveedor);
            return View(compra);
        }

        // GET: Compras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.Compras
                .Include(c => c.IdProveedorNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (compra == null)
            {
                return NotFound();
            }

            return View(compra);
        }

        // POST: Compras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var compra = await _context.Compras.FindAsync(id);
            if (compra != null)
            {
                _context.Compras.Remove(compra);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompraExists(int id)
        {
            return _context.Compras.Any(e => e.Id == id);
        }
    }
}