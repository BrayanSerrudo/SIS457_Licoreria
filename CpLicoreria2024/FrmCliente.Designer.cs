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
			this.label1 = new System.Windows.Forms.Label();
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
			this.txtTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefonoCliente.Location = new System.Drawing.Point(19, 238);
			this.txtTelefonoCliente.Name = "txtTelefonoCliente";
			this.txtTelefonoCliente.Size = new System.Drawing.Size(210, 22);
			this.txtTelefonoCliente.TabIndex = 84;
			// 
			// txtParametroCliente
			// 
			this.txtParametroCliente.Location = new System.Drawing.Point(455, 38);
			this.txtParametroCliente.Name = "txtParametroCliente";
			this.txtParametroCliente.Size = new System.Drawing.Size(265, 26);
			this.txtParametroCliente.TabIndex = 83;
			this.txtParametroCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametroCliente_KeyPress);
			// 
			// lblBusqueda
			// 
			this.lblBusqueda.AutoSize = true;
			this.lblBusqueda.BackColor = System.Drawing.Color.White;
			this.lblBusqueda.Location = new System.Drawing.Point(270, 38);
			this.lblBusqueda.Name = "lblBusqueda";
			this.lblBusqueda.Size = new System.Drawing.Size(221, 60);
			this.lblBusqueda.TabIndex = 82;
			this.lblBusqueda.Text = "Buscar por   N° Documento,\r\n                    Nombre Completo,\r\n               " +
    "     Correo o Teléfono:\r\n";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.BackColor = System.Drawing.Color.White;
			this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.Location = new System.Drawing.Point(251, 8);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(713, 85);
			this.lblSubtitulo.TabIndex = 80;
			this.lblSubtitulo.Text = "Lista de Clientes:";
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.BackColor = System.Drawing.SystemColors.Control;
			this.lblTitulo.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(15, 11);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(151, 20);
			this.lblTitulo.TabIndex = 79;
			this.lblTitulo.Text = "Detalle de Clientes";
			// 
			// lblTelefono
			// 
			this.lblTelefono.AutoSize = true;
			this.lblTelefono.BackColor = System.Drawing.SystemColors.Control;
			this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelefono.Location = new System.Drawing.Point(16, 219);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(64, 16);
			this.lblTelefono.TabIndex = 78;
			this.lblTelefono.Text = "Teléfono:";
			// 
			// txtCorreoCliente
			// 
			this.txtCorreoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCorreoCliente.Location = new System.Drawing.Point(19, 180);
			this.txtCorreoCliente.Name = "txtCorreoCliente";
			this.txtCorreoCliente.Size = new System.Drawing.Size(210, 22);
			this.txtCorreoCliente.TabIndex = 77;
			// 
			// lblCorreo
			// 
			this.lblCorreo.AutoSize = true;
			this.lblCorreo.BackColor = System.Drawing.SystemColors.Control;
			this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCorreo.Location = new System.Drawing.Point(16, 159);
			this.lblCorreo.Name = "lblCorreo";
			this.lblCorreo.Size = new System.Drawing.Size(51, 16);
			this.lblCorreo.TabIndex = 76;
			this.lblCorreo.Text = "Correo:";
			// 
			// txtNombreCompleto
			// 
			this.txtNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreCompleto.Location = new System.Drawing.Point(19, 122);
			this.txtNombreCompleto.Name = "txtNombreCompleto";
			this.txtNombreCompleto.Size = new System.Drawing.Size(210, 22);
			this.txtNombreCompleto.TabIndex = 75;
			// 
			// lblNombreCompleto
			// 
			this.lblNombreCompleto.AutoSize = true;
			this.lblNombreCompleto.BackColor = System.Drawing.SystemColors.Control;
			this.lblNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreCompleto.Location = new System.Drawing.Point(16, 101);
			this.lblNombreCompleto.Name = "lblNombreCompleto";
			this.lblNombreCompleto.Size = new System.Drawing.Size(109, 16);
			this.lblNombreCompleto.TabIndex = 74;
			this.lblNombreCompleto.Text = "Nombre Comple:";
			// 
			// txtDocumentoCliente
			// 
			this.txtDocumentoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDocumentoCliente.Location = new System.Drawing.Point(19, 64);
			this.txtDocumentoCliente.Name = "txtDocumentoCliente";
			this.txtDocumentoCliente.Size = new System.Drawing.Size(210, 22);
			this.txtDocumentoCliente.TabIndex = 73;
			// 
			// lblDocumento
			// 
			this.lblDocumento.AutoSize = true;
			this.lblDocumento.BackColor = System.Drawing.SystemColors.Control;
			this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDocumento.Location = new System.Drawing.Point(16, 43);
			this.lblDocumento.Name = "lblDocumento";
			this.lblDocumento.Size = new System.Drawing.Size(96, 16);
			this.lblDocumento.TabIndex = 72;
			this.lblDocumento.Text = "N° Documento:";
			// 
			// dgvListaCliente
			// 
			this.dgvListaCliente.AllowUserToAddRows = false;
			this.dgvListaCliente.AllowUserToDeleteRows = false;
			this.dgvListaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListaCliente.Location = new System.Drawing.Point(251, 101);
			this.dgvListaCliente.Name = "dgvListaCliente";
			this.dgvListaCliente.ReadOnly = true;
			this.dgvListaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListaCliente.Size = new System.Drawing.Size(713, 381);
			this.dgvListaCliente.TabIndex = 71;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(242, 533);
			this.label1.TabIndex = 70;
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
			this.btnLimpiar.Location = new System.Drawing.Point(842, 22);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(93, 51);
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
			this.btnBuscar.Location = new System.Drawing.Point(737, 22);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(93, 51);
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
			this.btnNuevo.Location = new System.Drawing.Point(19, 293);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(93, 51);
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
			this.btnEditar.Location = new System.Drawing.Point(118, 345);
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
			this.btnEliminar.Location = new System.Drawing.Point(19, 409);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(93, 51);
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
			this.btnCerrar.Location = new System.Drawing.Point(117, 407);
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
			this.btnGuardar.Location = new System.Drawing.Point(19, 350);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(93, 51);
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
			this.ClientSize = new System.Drawing.Size(976, 501);
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
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.Label label1;
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