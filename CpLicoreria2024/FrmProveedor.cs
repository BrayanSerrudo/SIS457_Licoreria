using CadLicoreria2024;
using ClnLicoreria2024;
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
    public partial class FrmProveedor : Form
    {
        private bool esNuevo = false;
        public FrmProveedor()
        {
            InitializeComponent();
            txtParametroProveedor.KeyPress += new KeyPressEventHandler(txtParametroProveedor_KeyPress);
        }

        private void listar()
        {
            var lista = ProveedorCln.listarPa(txtParametroProveedor.Text);
            dgvLista.DataSource = lista;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            //esto es para cambiar los nombres visibles en la tabla
            dgvLista.Columns["razonSocial"].HeaderText = "Razón Social";
            dgvLista.Columns["documento"].HeaderText = "N° Documento";
            dgvLista.Columns["email"].HeaderText = "Correo";
            dgvLista.Columns["telefono"].HeaderText = "Teléfono";


            btnEditar.Enabled = lista.Count() > 0;
            btnEliminar.Enabled = lista.Count() > 0;

            if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["documento"];
        }


        private void FrmProveedor_Load(object sender, EventArgs e)
        {
			txtDocumento.KeyPress += Util.onlyNumbers;
			txtRazonSocial.KeyPress += Util.onlyLetters;
			txtTelefono.KeyPress += Util.onlyNumbers;
			DesactivarCampos();
			listar();
        }

		private void DesactivarCampos()
		{
			txtDocumento.Enabled = false;
			txtRazonSocial.Enabled = false;
			txtCorreo.Enabled = false;
			txtTelefono.Enabled = false;
		}
		private void HabilitarCampos()
		{
			txtDocumento.Enabled = true;
			txtRazonSocial.Enabled = true;
			txtCorreo.Enabled = true;
			txtTelefono.Enabled = true;
		}

		private bool validar()
        {
            bool esValido = true;
            erpDocumento.SetError(txtDocumento, "");
            erpRazonSocial.SetError(txtRazonSocial, "");
            erpCorreo.SetError(txtCorreo, "");
            erpTelefono.SetError(txtTelefono, "");

            // evalua si la cadena esta vacia en el espacio de documento, visebersa para todos los campos 
            if (string.IsNullOrEmpty(txtDocumento.Text))
            {
                esValido = false;
                erpDocumento.SetError(txtDocumento, "El campo documento es obligatorio");
            }
            if (string.IsNullOrEmpty(txtRazonSocial.Text))
            {
                esValido = false;
                erpRazonSocial.SetError(txtRazonSocial, "El campo razon social es obligatorio");
            }
            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                esValido = false;
                erpCorreo.SetError(txtCorreo, "El campo correo es obligatorio");
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                esValido = false;
                erpTelefono.SetError(txtTelefono, "El campo telefono es obligatorio");
            }
            return esValido;
        }

		private void limpiar()
        {
            txtDocumento.Text = string.Empty;
            txtRazonSocial.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }
        private void limpiarlista() 
        {
           txtParametroProveedor.Text = string.Empty;
        }


        private void txtParametroProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter) listar();
        }
        //---------------------------------------------------------------------
		private void btnNuevo_Click(object sender, EventArgs e)
		{
			esNuevo = true;
			txtDocumento.Focus(); //para que el puntero parpadee en el texto de documento al presionar btnNuevo
			HabilitarCampos();
			limpiar();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (validar())
			{
				var proveedor = new Proveedor();
				proveedor.documento = txtDocumento.Text.Trim();
				proveedor.razonSocial = txtRazonSocial.Text.Trim();
				proveedor.email = txtCorreo.Text.Trim();
				proveedor.telefono = txtTelefono.Text.Trim();
				proveedor.usuarioRegistro = Util.usuario.usuario1;
				if (esNuevo)
				{
					proveedor.fechaRegistro = DateTime.Now;
					proveedor.estado = 1;
					ProveedorCln.insertar(proveedor);
				}
				else
				{
					int index = dgvLista.CurrentCell.RowIndex;
					proveedor.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
					ProveedorCln.actualizar(proveedor);
				}
				listar();
				MessageBox.Show("Proveedor guardado correctamente", ":::Licoreria - Mensaje :::",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			limpiar();
			DesactivarCampos();
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			esNuevo = false;
			int index = dgvLista.CurrentCell.RowIndex;
			int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
			var proveedor = ProveedorCln.obtenerUno(id);
			txtDocumento.Text = proveedor.documento;
			txtRazonSocial.Text = proveedor.razonSocial;
			txtCorreo.Text = proveedor.email;
			txtTelefono.Text = proveedor.telefono;
			txtDocumento.Focus();
			HabilitarCampos();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			int index = dgvLista.CurrentCell.RowIndex;
			int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
			string documento = dgvLista.Rows[index].Cells["documento"].Value.ToString();
			DialogResult dialog =
				MessageBox.Show($"¿Está seguro que desea dar de baja al proveedor con N° de documento {documento}?",
				"::: Licoreria - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (dialog == DialogResult.OK)
			{
				ProveedorCln.eliminar(id, Util.usuario.usuario1);
				listar();
				MessageBox.Show("Proveedor dado de baja correctamente", "::: Licoreria - Mensaje :::",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
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
			limpiarlista();
		}
	}
}
