using CadLicoreria2024;
using ClnLicoreria2024;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpLicoreria2024
{
    public partial class FrmProducto : Form
    {
        private bool esNuevo = false;
        public FrmProducto()
        {
            InitializeComponent();
        }

        public void listar()
        {
            var lista = ProductoCln.listaaPa(txtParametroProducto.Text);
            dgvListaProducto.DataSource = lista;
            dgvListaProducto.Columns["id"].Visible = false;
            dgvListaProducto.Columns["estado"].Visible = false;
            

            //esto es para cambiar los nombres visibles en la tabla
            dgvListaProducto.Columns["codigo"].HeaderText = "CÓDIGO";
            dgvListaProducto.Columns["Categoria"].HeaderText = "CATEGORIA";
            dgvListaProducto.Columns["nombre"].HeaderText = "NOMBRE";
            dgvListaProducto.Columns["descripcion"].HeaderText = "DESCRIPCION";
            dgvListaProducto.Columns["stock"].HeaderText = "STOCK";
            dgvListaProducto.Columns["precioCompra"].HeaderText = "PRECIO DE COMPRA";
            dgvListaProducto.Columns["precioVenta"].HeaderText = "PRECIO DE VENTA";
            btnEditar.Enabled = lista.Count() > 0;
            btnEliminar.Enabled = lista.Count() > 0;

            if (lista.Count > 0) dgvListaProducto.CurrentCell = dgvListaProducto.Rows[0].Cells["codigo"];
        }

        private void CargarCategorias()
        {
            var categorias = CategoriaCln.listar(); // Asumiendo que este método obtiene todas las categorías
            cbxCategoria.DataSource = categorias;
            cbxCategoria.DisplayMember = "descripcion"; // Cambia según tu modelo de datos
            cbxCategoria.ValueMember = "id"; // Cambia según tu modelo de datos
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
			listar();
            CargarCategorias();
			DesactivarCampos();
        }

		private void DesactivarCampos() 
		{
			txtCodigo.Enabled = false;
			txtNombre.Enabled = false;
			txtDescripcion.Enabled = false;
		
		}
		private void HabilitarCampos() 
		{
			txtCodigo.Enabled = true;
			txtNombre.Enabled = true;
			txtDescripcion.Enabled = true;
	
		}
        private void txtParametroProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }



        //todo lo de abajo va junto 
        private bool validar()
        {
            bool esValido = true;
            erpCodigo.SetError(txtCodigo, "");
            erpNombre.SetError(txtNombre, "");
            erpDescripcion.SetError(txtDescripcion, "");
   

            // evalua si la cadena esta vacia en el espacio de documento, visebersa para todos los campos 
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                esValido = false;
                erpCodigo.SetError(txtCodigo, "El campo documento es obligatorio");
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                esValido = false;
                erpNombre.SetError(txtNombre, "El campo razon social es obligatorio");
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                esValido = false;
                erpDescripcion.SetError(txtDescripcion, "El campo correo es obligatorio");
            }
        
            return esValido;
        }


        private void limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;

        }
        private void limpiarBusqueda() 
        {
           txtParametroProducto.Text = string.Empty;
        }

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			esNuevo = true;
			HabilitarCampos();
			txtCodigo.Focus(); //para que el puntero parpadee en el texto de documento al presionar btnNuevo
			limpiar();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (validar())
			{
				var producto = new Producto();
				producto.codigo = txtCodigo.Text.Trim();
				producto.nombre = txtNombre.Text.Trim();
				producto.descripcion = txtDescripcion.Text.Trim();
				producto.precioCompra =0;
				producto.precioVenta =0;
				producto.stock = 0;
				producto.idCategoria = (int)cbxCategoria.SelectedValue; // Asignar la categoría seleccionada
				producto.usuarioRegistro = Util.usuario.usuario1;

				if (esNuevo)
				{

					if (ProductoCln.ExisteCodigo(producto.codigo))
					{
						MessageBox.Show("NO SE PUEDE AGREGAR, código ya existente.", ":::Licoreria - Mensaje :::",
											MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}

					producto.fechaRegistro = DateTime.Now;
					producto.estado = 1;
					ProductoCln.insertar(producto);
				}
				else
				{
					// Editar producto existente
					int index = dgvListaProducto.CurrentCell.RowIndex;
					int id = Convert.ToInt32(dgvListaProducto.Rows[index].Cells["id"].Value);
					var productoExistente = ProductoCln.obtenerUno(id);

					// Verifica si el código nuevo ya existe y no es el mismo producto
					if (producto.codigo != productoExistente.codigo && ProductoCln.ExisteCodigo(producto.codigo))
					{
						MessageBox.Show("NO SE PUEDE ACTUALIZAR, código ya existente.", ":::Licoreria - Mensaje :::",
							MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return; // Salir del método si el código ya existe
					}

					producto.id = id; // Asigna el ID del producto que se está editando
					ProductoCln.actualizar(producto);
				}
				listar();
				MessageBox.Show("Producto guardado correctamente", ":::Licoreria - Mensaje :::",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			limpiar();
			DesactivarCampos();
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			esNuevo = false;
			int index = dgvListaProducto.CurrentCell.RowIndex;
			int id = Convert.ToInt32(dgvListaProducto.Rows[index].Cells["id"].Value);
			var producto = ProductoCln.obtenerUno(id);
			txtCodigo.Text = producto.codigo;
			txtNombre.Text = producto.nombre;
			txtDescripcion.Text = producto.descripcion;

			HabilitarCampos();


			txtCodigo.Focus();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			int index = dgvListaProducto.CurrentCell.RowIndex;
			int id = Convert.ToInt32(dgvListaProducto.Rows[index].Cells["id"].Value);
			string codigo = dgvListaProducto.Rows[index].Cells["codigo"].Value.ToString();
			DialogResult dialog =
				MessageBox.Show($"¿Está seguro que desea dar de baja al producto con codigo {codigo}?",
				"::: Licoreria - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (dialog == DialogResult.OK)
			{
				ProductoCln.eliminar(id, Util.usuario.usuario1);
				listar();
				MessageBox.Show("Producto dado de baja correctamente", "::: Licoreria - Mensaje :::",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			limpiar();
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			Close();
			
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			listar();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
            limpiarBusqueda();
		}

		private void lblTitulo_Click(object sender, EventArgs e)
		{

		}
	}
}
