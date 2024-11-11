namespace CpLicoreria2024
{
    partial class FrmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
			this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
			this.txtParametroCliente = new System.Windows.Forms.TextBox();
			this.lblBusqueda = new System.Windows.Forms.Label();
			this.lblSubtitulo = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblTelefono = new System.Windows.Forms.Label();
			this.txtCorreoCliente = new System.Windows.Forms.TextBox();
			this.lblCorreo = new System.Windows.Forms.Label();
			this.txtNombreCompleto = new System.Windows.Forms.TextBox();
			this.lblNombreCompleto = new System.Windows.Forms.Label();
			this.txtDocumentoCliente = new System.Windows.Forms.TextBox();
			this.lblDocumento = new System.Windows.Forms.Label();
			this.dgvListaCliente = new System.Windows.Forms.DataGridView();
			this.erpCorreoCliente = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpNombreCompleto = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpDocumentoCliente = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpTelefonoCliente = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCorreoCliente)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpNombreCompleto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDocumentoCliente)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpTelefonoCliente)).BeginInit();
			this.SuspendLayout();
			// 
			// txtTelefonoCliente
			// 
			this.txtTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefonoCliente.Location = new System.Drawing.Point(17, 257);
			this.txtTelefonoCliente.Name = "txtTelefonoCliente";
			this.txtTelefonoCliente.Size = new System.Drawing.Size(219, 29);
			this.txtTelefonoCliente.TabIndex = 84;
			// 
			// txtParametroCliente
			// 
			this.txtParametroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtParametroCliente.Location = new System.Drawing.Point(515, 38);
			this.txtParametroCliente.Name = "txtParametroCliente";
			this.txtParametroCliente.Size = new System.Drawing.Size(340, 29);
			this.txtParametroCliente.TabIndex = 83;
			this.txtParametroCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametroCliente_KeyPress);
			// 
			// lblBusqueda
			// 
			this.lblBusqueda.AutoSize = true;
			this.lblBusqueda.BackColor = System.Drawing.Color.Transparent;
			this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBusqueda.ForeColor = System.Drawing.Color.Lime;
			this.lblBusqueda.Location = new System.Drawing.Point(251, 38);
			this.lblBusqueda.Name = "lblBusqueda";
			this.lblBusqueda.Size = new System.Drawing.Size(258, 60);
			this.lblBusqueda.TabIndex = 82;
			this.lblBusqueda.Text = "Buscar por   N° Documento,\r\n                    Nombre Completo,\r\n               " +
    "     Correo o Teléfono:\r\n";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
			this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.ForeColor = System.Drawing.Color.Lime;
			this.lblSubtitulo.Location = new System.Drawing.Point(250, 8);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(220, 23);
			this.lblSubtitulo.TabIndex = 80;
			this.lblSubtitulo.Text = "Lista de Clientes:";
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
			this.lblTitulo.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.Aqua;
			this.lblTitulo.Location = new System.Drawing.Point(15, 16);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(188, 23);
			this.lblTitulo.TabIndex = 79;
			this.lblTitulo.Text = "Detalle de Clientes";
			// 
			// lblTelefono
			// 
			this.lblTelefono.AutoSize = true;
			this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
			this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelefono.ForeColor = System.Drawing.Color.SpringGreen;
			this.lblTelefono.Location = new System.Drawing.Point(16, 233);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(84, 20);
			this.lblTelefono.TabIndex = 78;
			this.lblTelefono.Text = "Teléfono:";
			// 
			// txtCorreoCliente
			// 
			this.txtCorreoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCorreoCliente.Location = new System.Drawing.Point(18, 201);
			this.txtCorreoCliente.Name = "txtCorreoCliente";
			this.txtCorreoCliente.Size = new System.Drawing.Size(219, 29);
			this.txtCorreoCliente.TabIndex = 77;
			// 
			// lblCorreo
			// 
			this.lblCorreo.AutoSize = true;
			this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
			this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCorreo.ForeColor = System.Drawing.Color.SpringGreen;
			this.lblCorreo.Location = new System.Drawing.Point(17, 178);
			this.lblCorreo.Name = "lblCorreo";
			this.lblCorreo.Size = new System.Drawing.Size(68, 20);
			this.lblCorreo.TabIndex = 76;
			this.lblCorreo.Text = "Correo:";
			// 
			// txtNombreCompleto
			// 
			this.txtNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreCompleto.Location = new System.Drawing.Point(19, 144);
			this.txtNombreCompleto.Name = "txtNombreCompleto";
			this.txtNombreCompleto.Size = new System.Drawing.Size(219, 29);
			this.txtNombreCompleto.TabIndex = 75;
			// 
			// lblNombreCompleto
			// 
			this.lblNombreCompleto.AutoSize = true;
			this.lblNombreCompleto.BackColor = System.Drawing.Color.Transparent;
			this.lblNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreCompleto.ForeColor = System.Drawing.Color.SpringGreen;
			this.lblNombreCompleto.Location = new System.Drawing.Point(16, 121);
			this.lblNombreCompleto.Name = "lblNombreCompleto";
			this.lblNombreCompleto.Size = new System.Drawing.Size(157, 20);
			this.lblNombreCompleto.TabIndex = 74;
			this.lblNombreCompleto.Text = "Nombre Completo:";
			// 
			// txtDocumentoCliente
			// 
			this.txtDocumentoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDocumentoCliente.Location = new System.Drawing.Point(19, 88);
			this.txtDocumentoCliente.Name = "txtDocumentoCliente";
			this.txtDocumentoCliente.Size = new System.Drawing.Size(219, 29);
			this.txtDocumentoCliente.TabIndex = 73;
			// 
			// lblDocumento
			// 
			this.lblDocumento.AutoSize = true;
			this.lblDocumento.BackColor = System.Drawing.Color.Transparent;
			this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDocumento.ForeColor = System.Drawing.Color.SpringGreen;
			this.lblDocumento.Location = new System.Drawing.Point(16, 61);
			this.lblDocumento.Name = "lblDocumento";
			this.lblDocumento.Size = new System.Drawing.Size(129, 20);
			this.lblDocumento.TabIndex = 72;
			this.lblDocumento.Text = "N° Documento:";
			// 
			// dgvListaCliente
			// 
			this.dgvListaCliente.AllowUserToAddRows = false;
			this.dgvListaCliente.AllowUserToDeleteRows = false;
			this.dgvListaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListaCliente.Location = new System.Drawing.Point(251, 110);
			this.dgvListaCliente.Name = "dgvListaCliente";
			this.dgvListaCliente.ReadOnly = true;
			this.dgvListaCliente.RowTemplate.Height = 28;
			this.dgvListaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListaCliente.Size = new System.Drawing.Size(817, 372);
			this.dgvListaCliente.TabIndex = 71;
			// 
			// erpCorreoCliente
			// 
			this.erpCorreoCliente.ContainerControl = this;
			// 
			// erpNombreCompleto
			// 
			this.erpNombreCompleto.ContainerControl = this;
			// 
			// erpDocumentoCliente
			// 
			this.erpDocumentoCliente.ContainerControl = this;
			// 
			// erpTelefonoCliente
			// 
			this.erpTelefonoCliente.ContainerControl = this;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLimpiar.Image = global::CpLicoreria2024.Properties.Resources.limpiar;
			this.btnLimpiar.Location = new System.Drawing.Point(967, 25);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(101, 51);
			this.btnLimpiar.TabIndex = 108;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.Image = global::CpLicoreria2024.Properties.Resources.buscar;
			this.btnBuscar.Location = new System.Drawing.Point(861, 25);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(100, 51);
			this.btnBuscar.TabIndex = 107;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNuevo.Image = global::CpLicoreria2024.Properties.Resources.Nuevo;
			this.btnNuevo.Location = new System.Drawing.Point(12, 317);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(119, 51);
			this.btnNuevo.TabIndex = 106;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditar.Image = global::CpLicoreria2024.Properties.Resources.editar;
			this.btnEditar.Location = new System.Drawing.Point(137, 372);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(93, 51);
			this.btnEditar.TabIndex = 105;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEliminar.Image = global::CpLicoreria2024.Properties.Resources.eliminar;
			this.btnEliminar.Location = new System.Drawing.Point(12, 431);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(119, 51);
			this.btnEliminar.TabIndex = 104;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Image = global::CpLicoreria2024.Properties.Resources.cerrar;
			this.btnCerrar.Location = new System.Drawing.Point(138, 432);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(93, 51);
			this.btnCerrar.TabIndex = 103;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGuardar.Image = global::CpLicoreria2024.Properties.Resources.Guardar;
			this.btnGuardar.Location = new System.Drawing.Point(12, 374);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(119, 51);
			this.btnGuardar.TabIndex = 102;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// FrmCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.Chocolate;
			this.BackgroundImage = global::CpLicoreria2024.Properties.Resources.cerveza_vaso_984x6661;
			this.ClientSize = new System.Drawing.Size(1080, 501);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtTelefonoCliente);
			this.Controls.Add(this.txtParametroCliente);
			this.Controls.Add(this.lblBusqueda);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.lblTelefono);
			this.Controls.Add(this.txtCorreoCliente);
			this.Controls.Add(this.lblCorreo);
			this.Controls.Add(this.txtNombreCompleto);
			this.Controls.Add(this.lblNombreCompleto);
			this.Controls.Add(this.txtDocumentoCliente);
			this.Controls.Add(this.lblDocumento);
			this.Controls.Add(this.dgvListaCliente);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmCliente";
			this.Text = "::: Licoreria - Cliente :::";
			this.Load += new System.EventHandler(this.FrmCliente_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCorreoCliente)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpNombreCompleto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDocumentoCliente)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpTelefonoCliente)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.TextBox txtParametroCliente;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.TextBox txtDocumentoCliente;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.DataGridView dgvListaCliente;
        private System.Windows.Forms.ErrorProvider erpCorreoCliente;
        private System.Windows.Forms.ErrorProvider erpNombreCompleto;
        private System.Windows.Forms.ErrorProvider erpDocumentoCliente;
        private System.Windows.Forms.ErrorProvider erpTelefonoCliente;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnGuardar;
	}
}