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
	public partial class FrmPequeCliente : Form
	{
		private FrmVenta frmVenta;
		public FrmPequeCliente(FrmVenta venta)
		{
			InitializeComponent();
			frmVenta = venta;
		}
		public void listar() 
		{
			var lista = ClienteCln.listerPa(txtParametropequeño.Text);
			dgvLista.DataSource = lista;
			dgvLista.Columns["id"].Visible = true;
			// dgvLista.Columns["razonSocial"].HeaderText = "Razón Social";
			// dgvLista.Columns["documento"].HeaderText = "N° Documento";

			if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["documento"];
		}
		private void txtParametropequeño_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter) listar();
		}

		private void FrmPequeCliente_Load(object sender, EventArgs e)
		{
			listar();
		}

		private void iBtnBuscar_Click(object sender, EventArgs e)
		{
			listar();
		}
		private void limpiar() 
		{
			txtParametropequeño.Text = string.Empty;
		}

		private void ibtnclear_Click(object sender, EventArgs e)
		{
			limpiar();
		}

		private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0) // Verifica que se haya hecho clic en una fila válida
			{
				// Obtener los datos de la fila
				string idCliente = dgvLista.Rows[e.RowIndex].Cells["id"].Value.ToString();
				string documento = dgvLista.Rows[e.RowIndex].Cells["documento"].Value.ToString();
				string nombreCompleto = dgvLista.Rows[e.RowIndex].Cells["nombreCompleto"].Value.ToString();


				// Llamar al método en el formulario de compra para establecer los datos
				frmVenta.SetClientePequeData(idCliente, documento, nombreCompleto);

				// Cerrar el segundo formulario
				this.Close();
			}
		}
	}
}
