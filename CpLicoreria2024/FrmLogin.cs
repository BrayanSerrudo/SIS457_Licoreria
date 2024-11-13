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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.Size = new Size(422, 223);

		}

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool validar() 
        {
            bool esValido = true;
            erpUsuario.SetError(txtUsuario, "");
            erpClave.SetError(txtClave, "");
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                esValido = false;
                erpUsuario.SetError(txtUsuario, "El campo Usuario es obligatorio");
            }
            if (string.IsNullOrEmpty(txtClave.Text))
            { 
               esValido = false;
                erpClave.SetError(txtClave, "El campo clave es obligatorio");
            }
            return esValido;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validar()) 
            {
                var usuario = UsuarioCln.validar(txtUsuario.Text, Util.Encrypt(txtClave.Text));
                if (usuario != null)
                {
                    Util.usuario = usuario;
                    txtClave.Text = string.Empty;
                    txtUsuario.Focus();
                    txtUsuario.Text = string.Empty;
                    Visible = false;
                    new FrmPrincipal(this).ShowDialog();
                }
                else MessageBox.Show("Usuario y/o contraseña incorrecto", " ::: Licoreria - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter) btnIngresar.PerformClick();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                txtClave.Focus();
                e.SuppressKeyPress = true;  

            }
        }
    }
}
