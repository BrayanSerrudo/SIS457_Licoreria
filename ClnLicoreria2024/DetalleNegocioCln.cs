using CadLicoreria2024;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnLicoreria2024
{
	public class DetalleNegocioCln
	{
		public static void Insertar(DetalleNegocio detalle)
		{
			using (var context = new Labsis457licoreriaEntities2())
			{
				context.DetalleNegocio.Add(detalle);
				context.SaveChanges();
			}
		}

		public static DetalleNegocio Obtener()
		{
			using (var context = new Labsis457licoreriaEntities2())
			{
				return context.DetalleNegocio.FirstOrDefault(); // Suponiendo que solo hay un registro
			}
		}

		public static void Actualizar(DetalleNegocio detalle)
		{
			using (var context = new Labsis457licoreriaEntities2())
			{
				var existente = context.DetalleNegocio.Find(detalle.Id); // Asegúrate de que tienes el ID
				if (existente != null)
				{
					existente.nombre = detalle.nombre;
					existente.direccion = detalle.direccion;
					existente.nit = detalle.nit;
					context.SaveChanges();
				}
			}
		}

		public static void Eliminar(int id)
		{
			using (var context = new Labsis457licoreriaEntities2())
			{
				var detalle = context.DetalleNegocio.Find(id);
				if (detalle != null)
				{
					context.DetalleNegocio.Remove(detalle);
					context.SaveChanges();
				}
			}
		}
	}
}
