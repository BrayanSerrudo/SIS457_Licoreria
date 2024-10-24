using CadLicoreria2024;
using ClnLicoreria2024;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpLicoreria2024
{
	public partial class FrmVenta : Form
	{
		public FrmVenta()
		{
			InitializeComponent();
		}

		private void btnBuscarProducto_Click(object sender, EventArgs e)
		{
			FrmProductoPequenoVenta productoFrm = new FrmProductoPequenoVenta(this);
			productoFrm.ShowDialog();
		}

		private void btnBuscarCliente_Click(object sender, EventArgs e)
		{
			FrmPequeCliente clienteFrm = new FrmPequeCliente(this);
			clienteFrm.ShowDialog();
		}

		public void SetProducto2Data(string idProducto, string codigo, string nombre, string stock, string precioVenta) 
		{
			txtIdProducto.Text = idProducto;
			txtCodigoProducto.Text = codigo;
			txtProducto.Text = nombre;
			txtStock.Text = stock;
			txtPrecioVenta .Text = precioVenta;
		}
		public void SetClientePequeData(string idCliente, string documento, string nombreCompleto)
		{
			txtIdCliente.Text = idCliente;
			txtDocuCliente.Text = documento;
			txtNombreCliente.Text = nombreCompleto;


		}
		private void FrmVenta_Load(object sender, EventArgs e)
		{
			txtNumeroDocumento.KeyPress += Util.onlyNumbers;
		
			txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
			txtIdProducto.Text = "0";
			txtIdCliente.Text = "0";
			txtPagaCon.Visible = false; // Esconde el control al iniciar
			dgvVentas.Columns.Add("IdProducto", "ID Producto");
			dgvVentas.Columns.Add("Codigo", "Código");
			dgvVentas.Columns.Add("Nombre", "Nombre");
			dgvVentas.Columns.Add("PrecioVenta", "Precio de Venta");
			dgvVentas.Columns.Add("Cantidad", "Cantidad");
			dgvVentas.Columns.Add("Total", "Total");
		}

		private bool validar()
		{
			bool esValido = true;
			erpTipoDocumento.SetError(cbxTipoDocumento, "");
			erpNfactura.SetError(txtNumeroDocumento, "");
			erpDocuCliente.SetError(txtDocuCliente, "");
			erpCodigoProducto.SetError(txtCodigoProducto, "");
			erpCantidadVender.SetError(nudCantidadVender, "");
			erpPagaCon.SetError(txtPagaCon,"");

			if (string.IsNullOrEmpty(cbxTipoDocumento.Text))
			{
				esValido = false;
				erpTipoDocumento.SetError(cbxTipoDocumento, "El campo Tipo Documento es obligatorio");
			}
			if (string.IsNullOrEmpty(txtNumeroDocumento.Text))
			{
				esValido = false;
				erpNfactura.SetError(txtNumeroDocumento, "Este campo es obligatorio");
			}
			if (string.IsNullOrEmpty(txtDocuCliente.Text))
			{
				esValido = false;
				erpDocuCliente.SetError(txtDocuCliente, "Este campo no debe estar vacio");
			}
			if (string.IsNullOrEmpty(txtCodigoProducto.Text))
			{
				esValido = false;
				erpCodigoProducto.SetError(txtCodigoProducto, "Este campo no debe estar vacio");
			}
		
			if (nudCantidadVender.Value <= 0)
			{
				esValido = false;
				erpCantidadVender.SetError(nudCantidadVender, "El campo Cantidad no debe ser negativo");
			}
			
			return esValido;
		}


		private void ibtnAgregar_Click(object sender, EventArgs e)
		{
			if (!validar())
			{
				// Si no es válido, muestra un mensaje y no continúa
				MessageBox.Show("Por favor, corrige los errores antes de agregar el producto.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return; // Detiene la ejecución si la validación falla
			}
			var idProducto = txtIdProducto.Text;
			var codigo = txtCodigoProducto.Text;
			var nombre = txtProducto.Text;			
			var precioVenta = decimal.Parse(txtPrecioVenta.Text);
			var cantidad = int.Parse(nudCantidadVender.Text);
			var total = precioVenta * cantidad;

			// Agregar una nueva fila al DataGridView
			dgvVentas.Rows.Add(idProducto, codigo, nombre, precioVenta, cantidad, total);

			// Limpiar los campos después de agregar
			LimpiarCampos();
			CalcularTotalPagar();
		}

		private void LimpiarCampos()
		{
			txtIdProducto.Text = string.Empty;
			txtCodigoProducto.Text = string.Empty;
			txtProducto.Text = string.Empty;
			txtStock.Text = string.Empty;
			txtPrecioVenta.Text = string.Empty;
			nudCantidadVender.Text = string.Empty;
		}

		private void iBtnQuitar_Click(object sender, EventArgs e)
		{
			// Verificar si hay una fila seleccionada
			if (dgvVentas.SelectedRows.Count > 0)
			{
				// Eliminar la fila seleccionada
				foreach (DataGridViewRow row in dgvVentas.SelectedRows)
				{
					dgvVentas.Rows.RemoveAt(row.Index);
				}

				// Calcular el nuevo total a pagar después de eliminar el producto
				CalcularTotalPagar();
			}
			else
			{
				MessageBox.Show("Por favor, selecciona un producto para quitar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void CalcularTotalPagar()
		{
			decimal totalPagar = 0;

			foreach (DataGridViewRow row in dgvVentas.Rows)
			{
				// Asegurarse de que la fila no sea una fila de nuevo
				if (row.Cells["Total"].Value != null)
				{
					totalPagar += Convert.ToDecimal(row.Cells["Total"].Value);
				}
			}

			// Mostrar el total en el TextBox
			txtMontoAPagar.Text = totalPagar.ToString("0.00"); // Formato con dos decimales
		}

		private void iBtnCrearVenta_Click(object sender, EventArgs e)
		{

			// Verifica que haya al menos un producto en el DataGridView
			if (dgvVentas.Rows.Count == 0)
			{
				MessageBox.Show("No hay productos para registrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string numeroDocumento = txtNumeroDocumento.Text.Trim();

			// Verifica si el número de factura ya existe
			if (CompraCln.ExisteNumeroFactura(numeroDocumento))
			{
				MessageBox.Show("El número de factura ya existe. Por favor, ingrese un número único.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Verifica que el tipo de documento seleccionado sea válido
			if (cbxTipoDocumento.SelectedItem == null || !cbxTipoDocumento.Items.Contains(cbxTipoDocumento.SelectedItem))
			{
				MessageBox.Show("Por favor, seleccione un tipo de documento válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Muestra el control de pago
			txtPagaCon.Visible = true; // Asegúrate de que esto esté oculto al inicio

			// Intentar convertir txtMontoAPagar a decimal
			decimal montoTotal;
			if (!decimal.TryParse(txtMontoAPagar.Text, out montoTotal))
			{
				MessageBox.Show("El monto total a pagar no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Verifica si el monto de pago es válido
			decimal montoPago;
			if (string.IsNullOrEmpty(txtPagaCon.Text) || !decimal.TryParse(txtPagaCon.Text, out montoPago))
			{
				MessageBox.Show("El monto de pago no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Verifica que el monto de pago sea suficiente
			if (montoPago < montoTotal)
			{
				MessageBox.Show("El monto de pago debe ser mayor o igual al total a pagar.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Calcular el cambio
			decimal montoCambio = montoPago - montoTotal;

			// Obtener información de la venta
			var venta = CrearVenta(numeroDocumento, montoTotal, montoPago, montoCambio);

			if (venta == null)
			{
				return; // Se generó un error en la creación de la venta
			}

			try
			{
				// Registrar la venta en la base de datos
				int idVentaRegistrada = VentaCln.RegistrarVenta(venta);
				RegistrarDetallesVenta(idVentaRegistrada);
				ActualizarStockVenta();

				MessageBox.Show("Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				ManejarErrorRegistro(ex, "Error al registrar la venta");
			}

			// Limpiar el DataGridView y el total
			dgvVentas.Rows.Clear();
			txtMontoAPagar.Text = "0.00";
			txtPagaCon.Text = string.Empty; // Limpiar el campo de pago
			txtCambio.Text = "0.00"; // Limpiar el campo de cambio
			LimpiarTodo();
		}
		private Venta CrearVenta(string numeroDocumento, decimal montoTotal, decimal montoPago, decimal montoCambio)
		{
			string tipoDocumento = cbxTipoDocumento.SelectedItem.ToString();
			string documentoCliente = txtDocuCliente.Text;
			string nombreCliente = txtNombreCliente.Text;
			string usuarioRegistro = Util.usuario.usuario1 ?? "Usuario Desconocido";

			return new Venta
			{
				tipoDocumento = tipoDocumento,
				numeroDocumento = numeroDocumento,
				documentoCliente = documentoCliente,
				nombreCliente = nombreCliente,
				montoTotal = montoTotal,
				montoPago = montoPago,
				montoCambio = montoCambio,
				fechaRegistro = DateTime.Now,
				usuarioRegistro = usuarioRegistro,
				estado = 1
			};
		}

		private void LimpiarTodo()
		{
			txtIdProducto.Text = string.Empty;
			txtCodigoProducto.Text = string.Empty;
			txtProducto.Text = string.Empty;
			txtPrecioVenta.Text = string.Empty;
			nudCantidadVender.Text = string.Empty;
			cbxTipoDocumento.Text = string.Empty;
			txtNumeroDocumento.Text = string.Empty;
			txtDocuCliente.Text = string.Empty;
			txtNombreCliente.Text = string.Empty;
			txtIdCliente.Text = string.Empty;
		}

		private Venta CrearVenta(string numeroDocumento)
		{
			string tipoDocumento = cbxTipoDocumento.SelectedItem.ToString();
			decimal montoTotal = decimal.Parse(txtMontoAPagar.Text);
			decimal montoPago = decimal.Parse(txtPagaCon.Text); // Nuevo
			decimal montoCambio = montoPago - montoTotal; // Nuevo
			string documentoCliente = txtDocuCliente.Text;
			string nombreCliente = txtNombreCliente.Text;
			string usuarioRegistro = Util.usuario.usuario1 ?? "Usuario Desconocido";

			return new Venta
			{
				tipoDocumento = tipoDocumento,
				numeroDocumento = numeroDocumento,
				documentoCliente = documentoCliente,
				nombreCliente = nombreCliente,
				montoTotal = montoTotal,
				montoPago = montoPago, // Nuevo
				montoCambio = montoCambio, // Nuevo

				fechaRegistro = DateTime.Now,
				usuarioRegistro = usuarioRegistro,
				estado = 1
			};
		}

		private void RegistrarDetallesVenta(int idVentaRegistrada)
		{
			foreach (DataGridViewRow row in dgvVentas.Rows)
			{
				if (row.Cells["idProducto"].Value != null)
				{
					// Similar a ValidarDetallesCompra, adapta para ventas
					var detalleVenta = new DetalleVenta
					{
						idVenta = idVentaRegistrada,
						idProducto = Convert.ToInt32(row.Cells["idProducto"].Value),
						precioVenta = Convert.ToDecimal(row.Cells["precioVenta"].Value),
						cantidad = Convert.ToInt32(row.Cells["cantidad"].Value),
						subTotal = Convert.ToDecimal(row.Cells["total"].Value),
						// Otros campos si es necesario
					};

					// Registrar el detalle
					try
					{
						DetalleVentaCln.RegistrarDetalleVenta(detalleVenta);
					}
					catch (Exception ex)
					{
						ManejarErrorRegistro(ex, "Error al registrar detalle de venta");
					}
				}
			}
		}

		private void ActualizarStockVenta()
		{
			foreach (DataGridViewRow row in dgvVentas.Rows)
			{
				if (row.Cells["IdProducto"].Value != null)
				{
					var idProducto = Convert.ToInt32(row.Cells["IdProducto"].Value);
					var cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

					try
					{
						// Llama al método ActualizarStock para reducir el stock
						bool actualizado = ProductoCln.ActualizarDisminuirStock(idProducto, cantidad); // Asumiendo que este método ahora reduce el stock

						if (!actualizado)
						{
							MessageBox.Show($"No se pudo actualizar el stock para el producto ID {idProducto}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Error al actualizar el producto ID {idProducto}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void ManejarErrorValidacion(DbEntityValidationException validationEx, string mensaje)
		{
			StringBuilder errorDetails = new StringBuilder();
			foreach (var validationErrors in validationEx.EntityValidationErrors)
			{
				foreach (var validationError in validationErrors.ValidationErrors)
				{
					errorDetails.AppendLine($"{mensaje}: Propiedad: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
				}
			}
			MessageBox.Show(errorDetails.ToString(), "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void ManejarErrorRegistro(Exception ex, string mensaje)
		{
			MessageBox.Show($"{mensaje}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void txtPagaCon_TextChanged(object sender, EventArgs e)
		{
			decimal montoTotal;
			if (!decimal.TryParse(txtMontoAPagar.Text, out montoTotal))
			{
				txtCambio.Text = "0.00"; // Si no se puede convertir, se pone 0
				return; // Salimos del método si la conversión falla
			}

			decimal montoPago;
			if (decimal.TryParse(txtPagaCon.Text, out montoPago))
			{
				decimal montoCambio = montoPago - montoTotal;
				txtCambio.Text = montoCambio >= 0 ? montoCambio.ToString("0.00") : "0.00";
			}
			else
			{
				txtCambio.Text = "0.00"; // Si no se puede convertir, se pone 0
			}
		}


	}
}
