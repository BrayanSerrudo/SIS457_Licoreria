using CadLicoreria2024;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnLicoreria2024
{
	public class DetalleCompraDTO
	{
		public int idProducto { get; set; }
		public string codigo { get; set; }
		public string nombre { get; set; }
		public decimal precioCompra { get; set; }
		public decimal precioVenta { get; set; }
		public int cantidad { get; set; }
		public decimal total { get; set; }

		
	
	}
}
