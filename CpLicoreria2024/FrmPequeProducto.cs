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
    public partial class FrmPequeProducto : Form
    {
        private FrmCompra frmCompra;
        public FrmPequeProducto(FrmCompra compra)
        {
            InitializeComponent();
            frmCompra = compra;
        }
        public void listar()
        {
            var lista = ProductoCln.listoPa(txtParametropequeño.Text);
            dgvLista.DataSource = lista;
            dgvLista.Columns["id"].Visible = false;
           // dgvLista.Columns["razonSocial"].HeaderText = "Razón Social";
           // dgvLista.Columns["documento"].HeaderText = "N° Documento";

            if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["codigo"];
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FrmPequeProducto_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void iBtnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtParametropequeño.Text = string.Empty;
        }

        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que se haya hecho clic en una fila válida
            {
                // Obtener los datos de la fila
                string idProducto = dgvLista.Rows[e.RowIndex].Cells["id"].Value.ToString();
                string codigo = dgvLista.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                string nombre = dgvLista.Rows[e.RowIndex].Cells["nombre"].Value.ToString();


                // Llamar al método en el formulario de compra para establecer los datos
                frmCompra.SetProductoData(idProducto, codigo, nombre);

                // Cerrar el segundo formulario
                this.Close();
            }
        }

        private void txtParametropequeño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }
    }
}
