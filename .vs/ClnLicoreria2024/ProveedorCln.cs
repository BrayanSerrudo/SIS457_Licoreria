using CadLicoreria2024;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnLicoreria2024
{
    public class ProveedorCln
    {
        public static int insertar(Proveedor proveedor)
        {
            using (var context = new Labsis457licoreriaEntities2())
            {
                context.Proveedor.Add(proveedor);
                context.SaveChanges();
                return proveedor.id;
            }
        }

        public static int actualizar(Proveedor proveedor)
        {
            using (var context = new Labsis457licoreriaEntities2())
            {
                var existente = context.Proveedor.Find(proveedor.id);
                existente.documento = proveedor.documento;
                existente.razonSocial = proveedor.razonSocial;
                existente.email = proveedor.email;
                existente.telefono = proveedor.telefono;
                existente.usuarioRegistro = proveedor.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuario)
        {
            using (var context = new Labsis457licoreriaEntities2())
            {
                var proveedor = context.Proveedor.Find(id);
                proveedor.estado = -1;
                proveedor.usuarioRegistro = usuario;
                return context.SaveChanges();
            }
        }

        public static Proveedor obtenerUno(int id)
        {
            using (var context = new Labsis457licoreriaEntities2())
            {
                return context.Proveedor.Find(id);
            }
        }

        public static List<Proveedor> listar()
        {
            using (var context = new Labsis457licoreriaEntities2())
            {
                return context.Proveedor.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paProveedorListar_Result> listarPa(string parametro)
        {
            using (var context = new Labsis457licoreriaEntities2())
            {
                return context.paProveedorListar(parametro).ToList();
            }
        }

        public static List<paProveedorPListar_Result> listarpPa(string parametro) 
        {
            using (var context = new Labsis457licoreriaEntities2()) 
            {
                return context.paProveedorPListar(parametro).ToList();
            }
        }



        //prueba sera desechado
		public static Proveedor ObtenerProveedorPorId(int idProveedor)
		{
			using (var context = new Labsis457licoreriaEntities2())
			{
				return context.Proveedor.Find(idProveedor);
			}
		}
	}
}
