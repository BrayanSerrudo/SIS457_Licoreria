﻿using CadLicoreria2024;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpLicoreria2024
{
    public partial class FrmPrincipal : Form
    {
        private FrmLogin frmLogin;
        public FrmPrincipal(FrmLogin frmLogin)
        {
            InitializeComponent();
            this.frmLogin = frmLogin;
            // comprobar si hay usuario logueado
            if (Util.usuario != null)
            {
				// Obtener el empleado asociado con el usuario
				lblUsuario.Text = "" + Util.usuario.usuario1;
                using (var context = new Labsis457licoreriaEntities2())
                {
                    var empleado = context.Empleado
                                          .FirstOrDefault(e => e.id == Util.usuario.idEmpleado);  // Obtenemos el empleado con el id del usuario

					// Verificamos si el empleado existe y tiene el cargo "propietario"
					if (empleado != null && empleado.cargo != "Propietario")
                    {
                        menuUsuario.Enabled = false;  // Deshabilitar menú si no es "propietario"

                    }
                }
            }
			this.frmLogin = frmLogin;
			// Agregar el manejador del evento FormClosing
			this.FormClosing += FrmPrincipal_FormClosing;
		}
        ///experimento cargar formulario a panel funciona



        private void menuProveedores_Click(object sender, EventArgs e)
        {
            //CargarFormularioEnPanel(new FrmProveedor()); //cargar a panelcontenedor
            new FrmProveedor().ShowDialog();
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {

            //CargarFormularioEnPanel(new FrmCliente()); //cargar a panelcontenedor
            new FrmCliente().ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CargarFormularioEnPanel(new FrmCategoria()); //cargar a panelcontenedor
            new FrmCategoria().ShowDialog();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
			var result = MessageBox.Show("¿Estás seguro de que quieres cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo);

			if (result == DialogResult.Yes)
			{
				// Si el usuario confirma que quiere salir, se cierra la aplicación
				Application.Exit();
			}
			else
			{
				// Si el usuario no quiere salir, se cancela el cierre del formulario
				e.Cancel = true;
			}

		}

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CargarFormularioEnPanel(new FrmEmpleado()); //cargar a panelcontenedor
            new FrmEmpleado().ShowDialog();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CargarFormularioEnPanel(new FrmProducto()); //cargar a panelcontenedor
            new FrmProducto().ShowDialog();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //CargarFormularioEnPanel(new FrmCompra()); //cargar a panelcontenedor
            new FrmCompra().ShowDialog();
        }

        private void negocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CargarFormularioEnPanel(new FrmDetalleNegocio()); //cargar a panelcontenedor
            new FrmDetalleNegocio().ShowDialog();
        }

		private void FrmPrincipal_Load(object sender, EventArgs e)
		{

		}

		private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
		{
            new FrmVenta().ShowDialog();
		}

		private void verDetalleToolStripMenuItem1_Click(object sender, EventArgs e)
		{
            new FrmDetalleCompra().ShowDialog();    
		}

		private void reportesComprasToolStripMenuItem_Click(object sender, EventArgs e)
		{
            new FrmRegistroCompras().ShowDialog();  
		}


	}
}
