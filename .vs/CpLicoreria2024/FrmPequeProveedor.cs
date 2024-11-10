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
    public partial class FrmPequeProveedor : Form
    {
        private FrmCompra frmCompra;
        public FrmPequeProveedor(FrmCompra compra)
        {
            InitializeComponent();
            frmCompra = compra;
        }

        public void listar() 
        {
            var lista = ProveedorCln.listarpPa(txtParametro.Text);
            dgvLista.DataSource = lista;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["razonSocial"].HeaderText = "Razón Social";
            dgvLista.Columns["documento"].HeaderText = "N° Documento";

            if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["documento"];
        }
        private void FrmPequeProveedor_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void iBtnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            txtParametro.Text = string.Empty;
        }

        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que se haya hecho clic en una fila válida
            {
                // Obtener los datos de la fila
                string idProveedor = dgvLista.Rows[e.RowIndex].Cells["id"].Value.ToString();
                string documento = dgvLista.Rows[e.RowIndex].Cells["documento"].Value.ToString();
                string razonSocial = dgvLista.Rows[e.RowIndex].Cells["razonSocial"].Value.ToString();

                // Llamar al método en el formulario de compra para establecer los datos
                frmCompra.SetProveedorData(idProveedor, documento, razonSocial);

                // Cerrar el segundo formulario
                this.Close();
            }
        }
    }
}
