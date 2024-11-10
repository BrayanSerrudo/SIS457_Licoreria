using CadLicoreria2024;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnLicoreria2024
{
    public class CompraCln
    {
        public static int RegistrarCompra(Compra compra)
        {
            using (var context = new Labsis457licoreriaEntities2())
            {
                context.Compra.Add(compra);
                context.SaveChanges();
                return compra.id;
            }
        }

		public static bool ExisteNumeroFactura(string numeroFactura)
		{
			using (var context = new Labsis457licoreriaEntities2())
			{
				return context.Compra.Any(c => c.numeroDocumento == numeroFactura);
			}
		}





		//prueba puede ser desechado
		public static Compra ObtenerCompraPorNumeroDocumento(string numeroDocumento)
		{
			using (var context = new Labsis457licoreriaEntities2())
			{
				return context.Compra
			.Include(c => c.Proveedor) // Asegúrate de que la relación está configurada en el modelo
			.FirstOrDefault(c => c.numeroDocumento == numeroDocumento);
			}
		}
	}
}
