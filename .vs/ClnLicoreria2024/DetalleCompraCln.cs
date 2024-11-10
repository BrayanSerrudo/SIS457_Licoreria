using CadLicoreria2024;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnLicoreria2024
{
	public class DetalleCompraCln
	{
		public static void RegistrarDetalleCompra(DetalleCompra detalle)
		{
			using (var context = new Labsis457licoreriaEntities2())
			{
				try
				{
					context.DetalleCompra.Add(detalle);
					context.SaveChanges();
				}
				catch (Exception ex)
				{
					// Manejar excepciones, puedes registrar el error o lanzar una excepción específica
					throw new Exception("Error al registrar detalle de compra: " + ex.Message);
				}
			}
		}

		// prueba puede ser desechado
		public static List<DetalleCompraDTO> ObtenerDetallesPorIdCompra(int idCompra)
		{
			using (var context = new Labsis457licoreriaEntities2())
			{
				return context.DetalleCompra
					.Where(d => d.idCompra == idCompra)
					.Select(d => new DetalleCompraDTO
					{
						idProducto = d.idProducto,
						codigo = d.Producto.codigo,
						nombre = d.Producto.nombre,
						precioCompra = (decimal)d.precioCompra,
						precioVenta = (decimal)d.precioVenta,
						cantidad = d.cantidad,
						total = (decimal)d.precioCompra * (decimal)d.cantidad
					}).ToList();
			}
		}
	}
}
