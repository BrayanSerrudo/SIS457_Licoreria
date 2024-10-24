using CadLicoreria2024;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnLicoreria2024
{
    public class UsuarioCln
    {
        public static Usuario obtenerUno(int id)
        {
            using (var context = new Labsis457licoreriaEntities2())
            {
                return context.Usuario
                    .Include(e => e.Empleado)
                    .Where(e => e.id == id)
                    .FirstOrDefault();
            }
        }

        public static Usuario validar(string usuario, string clave) 
        {
            using (var context = new Labsis457licoreriaEntities2())
            { 
                //verificar si el ususario esta activo y su empleado tambien lo esta
                var usuarioValidado = context.Usuario
                    .Include(u => u.Empleado)
                    .Where(x => x.estado == 1 && x.usuario1 == usuario && x.clave == clave)
                    .FirstOrDefault();
				//verificar que el empleado asociado no este eliminado
				if (usuarioValidado != null && usuarioValidado.Empleado != null && usuarioValidado.Empleado.estado == -1)
				{
					return null; // Retornamos null si el empleado está eliminado
				}
                return usuarioValidado;
			}
        }
    }
}
