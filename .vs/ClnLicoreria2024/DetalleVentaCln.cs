using CadLicoreria2024;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnLicoreria2024
{
	public class DetalleVentaCln
	{
		public static void RegistrarDetalleVenta(DetalleVenta detalle)
		{
			using (var context = new Labsis457licoreriaEntities2())
			{
				try
				{
					context.DetalleVenta.Add(detalle);
					context.SaveChanges();
				}
				catch (Exception ex)
				{
					// Manejar excepciones, puedes registrar el error o lanzar una excepción específica
					throw new Exception("Error al registrar detalle de venta: " + ex.Message);
				}
			}
		}

		public static List<DetalleVentaDTO> ObtenerDetallesPorIdVenta(int idVenta)
		{
			using (var context = new Labsis457licoreriaEntities2())
			{
				return context.DetalleVenta
					.Where(d => d.idVenta == idVenta)
					.Select(d => new DetalleVentaDTO
					{
						idProducto = d.idProducto,
						codigo = d.Producto.codigo,
						nombre = d.Producto.nombre,
						precioVenta = (decimal)d.precioVenta,
						cantidad = d.cantidad,
						total = (decimal)d.precioVenta * (decimal)d.cantidad
					}).ToList();
			}
		}
	}
}
