using CadLicoreria2024;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClnLicoreria2024
{
    public class ProductoCln
    {
       
        public static int insertar(Producto producto)
        {
            using (var context = new Labsis457licoreriaEntities2())
            {
                context.Producto.Add(producto);
                context.SaveChanges();
                return producto.id;
            }
        }

        public static int actualizar(Producto producto)
        {
            using (var context = new Labsis457licoreriaEntities2())
            {
                var existente = context.Producto.Find(producto.id);
                if (existente != null)
                {
                    existente.codigo = producto.codigo;
                    existente.nombre = producto.nombre;
                    existente.descripcion = producto.descripcion;
                    existente.idCategoria = producto.idCategoria;
                    existente.precioCompra = producto.precioCompra;
                    existente.precioVenta = producto.precioVenta;
                    existente.stock = producto.stock;

                    existente.usuarioRegistro = producto.usuarioRegistro;
                    return context.SaveChanges();
                }
                return 0;
            }
        }

        public static int eliminar(int id, string usuario)
        {
            using (var context = new Labsis457licoreriaEntities2())
            {
                var producto = context.Producto.Find(id);
                if (producto != null)
                {
                    producto.estado = -1;
                    producto.usuarioRegistro = usuario;
                    return context.SaveChanges();
                }
                return 0;
            }
        }

        public static Producto obtenerUno(int id)
        {
            using (var context = new Labsis457licoreriaEntities2())
            {
                return context.Producto.Find(id);
            }
        }

        public static List<Producto> listar()
        {
            using (var context = new Labsis457licoreriaEntities2())
            {
                return context.Producto.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paProductooListar_Result> listaaPa(string parametro)
        {
            using (var context = new Labsis457licoreriaEntities2())
            {
                return context.paProductooListar(parametro).ToList();
            }
        }

        public static List<paProductoPequenoListar_Result> listoPa(string parametro)
        {
            using (var context = new Labsis457licoreriaEntities2())
            {
                return context.paProductoPequenoListar(parametro).ToList();
            }
        }

		public static List<paProductoPequeListar_Result> listuPa(string parametro)
		{
			using (var context = new Labsis457licoreriaEntities2())
			{
				return context.paProductoPequeListar(parametro).ToList();
			}
		}





		// Nuevo método para obtener un producto por ID
		public static Producto ObtenerProductoPorId(int idProducto)
        {
            return obtenerUno(idProducto); // Puedes reutilizar obtenerUno
        }






		// Nuevo método para actualizar el stock
		public static bool ActualizarStock(int idProducto, decimal precioCompra, decimal precioVenta, int cantidad)
		{
			using (var context = new Labsis457licoreriaEntities2())
			{
				var producto = context.Producto.Find(idProducto);
				if (producto != null && producto.estado != -1)
				{
					// Solo actualizar el stock
					producto.stock += cantidad;

					// Actualizar precios solo si son diferentes (opcional)
					if (producto.precioCompra != precioCompra)
					{
						producto.precioCompra = precioCompra;
					}
					if (producto.precioVenta != precioVenta)
					{
						producto.precioVenta = precioVenta;
					}

					// Guardar los cambios en la base de datos
					context.SaveChanges();
					return true; // Indica éxito
				}
				else
				{
					throw new Exception("El producto no existe o está inactivo.");
				}
			}
		}

		public static bool ExisteCodigo(string codigo)
		{
			using (var context = new Labsis457licoreriaEntities2())
			{
                return context.Producto.Any(p => p.codigo == codigo && p.estado != -1);
			}
		}

		public static bool ActualizarDisminuirStock(int idProducto, int cantidad)
		{
			using (var context = new Labsis457licoreriaEntities2())
			{
				var producto = context.Producto.Find(idProducto);
				if (producto != null && producto.estado != -1)
				{
					// Reducir el stock
					if (producto.stock >= cantidad) // Verifica que haya suficiente stock
					{
						producto.stock -= cantidad;
					}
					else
					{
						throw new Exception("No hay suficiente stock para realizar la venta.");
					}

					// Guardar los cambios en la base de datos
					context.SaveChanges();
					return true; // Indica éxito
				}
				else
				{
					throw new Exception("El producto no existe o está inactivo.");
				}
			}
		}







	}  
}
