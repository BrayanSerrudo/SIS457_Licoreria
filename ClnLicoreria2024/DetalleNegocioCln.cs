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
		public static DetalleNegocio Obtener()
		{
			using (var context = new Labsis457licoreriaEntities2())
			{
				return context.DetalleNegocio.FirstOrDefault();
			}
		}
	}
}
