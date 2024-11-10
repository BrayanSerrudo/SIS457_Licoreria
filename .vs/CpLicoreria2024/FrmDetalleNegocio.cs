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
    public partial class FrmDetalleNegocio : Form
    {
		public FrmDetalleNegocio()
		{
			InitializeComponent();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			var detalle = new DetalleNegocio
			{
				nombre = txtNombre.Text.Trim(),
				direccion = txtDireccion.Text.Trim(),
				nit = txtNit.Text.Trim(),
				// No se guarda la imagen, solo se muestra
			};

			DetalleNegocioCln.Insertar(detalle);
			MessageBox.Show("Detalles guardados correctamente.");
			LimpiarCampos();
		}

		private void LimpiarCampos()
		{
			txtNombre.Clear();
			txtDireccion.Clear();
			txtNit.Clear();
			picLogo.Image = null; // Limpiar la imagen
		}

		private void FrmDetalleNegocio_Load(object sender, EventArgs e)
		{
			// Cargar datos si es necesario
			var detalle = DetalleNegocioCln.Obtener();
			if (detalle != null)
			{
				txtNombre.Text = detalle.nombre;
				txtDireccion.Text = detalle.direccion;
				txtNit.Text = detalle.nit;
				// Cargar la imagen si es necesario
			}
		}

		private void ibtnCargarImagen_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					picLogo.Image = Image.FromFile(openFileDialog.FileName);
				}
			}
		}
	}
}
