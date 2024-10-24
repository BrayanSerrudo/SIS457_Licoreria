using CadLicoreria2024;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnLicoreria2024
{
	public class VentaCln
	{
		public static int RegistrarVenta(Venta venta)
		{
			using (var context = new Labsis457licoreriaEntities2())
			{
				context.Venta.Add(venta);
				context.SaveChanges();
				return venta.id;
			}
		}

		public static bool ExisteNumeroDocumento(string numeroDocumento)
		{
			using (var context = new Labsis457licoreriaEntities2())
			{
				return context.Venta.Any(v => v.numeroDocumento == numeroDocumento);
			}
		}

		public static Venta ObtenerVentaPorNumeroDocumento(string numeroDocumento)
		{
			using (var context = new Labsis457licoreriaEntities2())
			{
				return context.Venta
			
				.FirstOrDefault(v => v.numeroDocumento == numeroDocumento);
			}
		}
	}
}
