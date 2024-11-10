using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnLicoreria2024
{
	public class DetalleVentaDTO
	{
		public int idProducto { get; set; }
		public string codigo { get; set; }
		public string nombre { get; set; }
		public decimal precioVenta { get; set; } // Solo precio de venta, ya que no se necesita precio de compra
		public int cantidad { get; set; }
		public decimal total { get; set; }

		// Puedes agregar más propiedades si es necesario, como el ID de la venta, etc.
	}
}
