namespace CpLicoreria2024
{
    partial class FrmProducto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducto));
			this.txtParametroProducto = new System.Windows.Forms.TextBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblTelefono = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.lblCorreo = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblRazonSocial = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.lblDocumento = new System.Windows.Forms.Label();
			this.dgvListaProducto = new System.Windows.Forms.DataGridView();
			this.cbxCategoria = new System.Windows.Forms.ComboBox();
			this.erpCodigo = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpNombre = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvListaProducto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCodigo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpNombre)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDescripcion)).BeginInit();
			this.SuspendLayout();
			// 
			// txtParametroProducto
			// 
			this.txtParametroProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtParametroProducto.Location = new System.Drawing.Point(524, 67);
			this.txtParametroProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtParametroProducto.Name = "txtParametroProducto";
			this.txtParametroProducto.Size = new System.Drawing.Size(351, 29);
			this.txtParametroProducto.TabIndex = 78;
			this.txtParametroProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametroProducto_KeyPress);
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
			this.lblTitulo.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.Aqua;
			this.lblTitulo.Location = new System.Drawing.Point(13, 9);
			this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(215, 23);
			this.lblTitulo.TabIndex = 77;
			this.lblTitulo.Text = "Detalles de Productos";
			this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
			// 
			// lblTelefono
			// 
			this.lblTelefono.AutoSize = true;
			this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
			this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelefono.ForeColor = System.Drawing.Color.LawnGreen;
			this.lblTelefono.Location = new System.Drawing.Point(13, 211);
			this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(92, 20);
			this.lblTelefono.TabIndex = 76;
			this.lblTelefono.Text = "Categoria:";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescripcion.Location = new System.Drawing.Point(11, 180);
			this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(212, 29);
			this.txtDescripcion.TabIndex = 75;
			// 
			// lblCorreo
			// 
			this.lblCorreo.AutoSize = true;
			this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
			this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCorreo.ForeColor = System.Drawing.Color.LawnGreen;
			this.lblCorreo.Location = new System.Drawing.Point(8, 155);
			this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCorreo.Name = "lblCorreo";
			this.lblCorreo.Size = new System.Drawing.Size(108, 20);
			this.lblCorreo.TabIndex = 74;
			this.lblCorreo.Text = "Descripción:";
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(12, 124);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(211, 29);
			this.txtNombre.TabIndex = 73;
			// 
			// lblRazonSocial
			// 
			this.lblRazonSocial.AutoSize = true;
			this.lblRazonSocial.BackColor = System.Drawing.Color.Transparent;
			this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRazonSocial.ForeColor = System.Drawing.Color.LawnGreen;
			this.lblRazonSocial.Location = new System.Drawing.Point(9, 104);
			this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRazonSocial.Name = "lblRazonSocial";
			this.lblRazonSocial.Size = new System.Drawing.Size(76, 20);
			this.lblRazonSocial.TabIndex = 72;
			this.lblRazonSocial.Text = "Nombre:";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(12, 73);
			this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(211, 29);
			this.txtCodigo.TabIndex = 71;
			// 
			// lblDocumento
			// 
			this.lblDocumento.AutoSize = true;
			this.lblDocumento.BackColor = System.Drawing.Color.Transparent;
			this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDocumento.ForeColor = System.Drawing.Color.LawnGreen;
			this.lblDocumento.Location = new System.Drawing.Point(9, 47);
			this.lblDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDocumento.Name = "lblDocumento";
			this.lblDocumento.Size = new System.Drawing.Size(70, 20);
			this.lblDocumento.TabIndex = 70;
			this.lblDocumento.Text = "Código:";
			// 
			// dgvListaProducto
			// 
			this.dgvListaProducto.AllowUserToAddRows = false;
			this.dgvListaProducto.AllowUserToDeleteRows = false;
			this.dgvListaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvListaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListaProducto.Location = new System.Drawing.Point(246, 124);
			this.dgvListaProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvListaProducto.Name = "dgvListaProducto";
			this.dgvListaProducto.ReadOnly = true;
			this.dgvListaProducto.RowTemplate.Height = 28;
			this.dgvListaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListaProducto.Size = new System.Drawing.Size(910, 391);
			this.dgvListaProducto.TabIndex = 69;
			// 
			// cbxCategoria
			// 
			this.cbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxCategoria.FormattingEnabled = true;
			this.cbxCategoria.Location = new System.Drawing.Point(13, 236);
			this.cbxCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbxCategoria.Name = "cbxCategoria";
			this.cbxCategoria.Size = new System.Drawing.Size(182, 32);
			this.cbxCategoria.TabIndex = 86;
			// 
			// erpCodigo
			// 
			this.erpCodigo.ContainerControl = this;
			// 
			// erpNombre
			// 
			this.erpNombre.ContainerControl = this;
			// 
			// erpDescripcion
			// 
			this.erpDescripcion.ContainerControl = this;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Lime;
			this.label4.Location = new System.Drawing.Point(246, 62);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(270, 40);
			this.label4.TabIndex = 93;
			this.label4.Text = "Buscar producto por:\r\n       Código, Nombre o Categoría";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Lime;
			this.label5.Location = new System.Drawing.Point(279, 21);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(186, 23);
			this.label5.TabIndex = 94;
			this.label5.Text = "Lista de Productos";
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLimpiar.Image = global::CpLicoreria2024.Properties.Resources.limpiar;
			this.btnLimpiar.Location = new System.Drawing.Point(999, 47);
			this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(104, 52);
			this.btnLimpiar.TabIndex = 101;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.Image = global::CpLicoreria2024.Properties.Resources.buscar;
			this.btnBuscar.Location = new System.Drawing.Point(883, 47);
			this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(108, 52);
			this.btnBuscar.TabIndex = 100;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNuevo.Image = global::CpLicoreria2024.Properties.Resources.Nuevo;
			this.btnNuevo.Location = new System.Drawing.Point(21, 339);
			this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(115, 52);
			this.btnNuevo.TabIndex = 99;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditar.Image = global::CpLicoreria2024.Properties.Resources.editar;
			this.btnEditar.Location = new System.Drawing.Point(145, 401);
			this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(93, 52);
			this.btnEditar.TabIndex = 98;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEliminar.Image = global::CpLicoreria2024.Properties.Resources.eliminar;
			this.btnEliminar.Location = new System.Drawing.Point(21, 463);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(115, 52);
			this.btnEliminar.TabIndex = 97;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Image = global::CpLicoreria2024.Properties.Resources.cerrar;
			this.btnCerrar.Location = new System.Drawing.Point(145, 463);
			this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(93, 52);
			this.btnCerrar.TabIndex = 96;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGuardar.Image = global::CpLicoreria2024.Properties.Resources.Guardar;
			this.btnGuardar.Location = new System.Drawing.Point(21, 401);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(115, 52);
			this.btnGuardar.TabIndex = 95;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// FrmProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::CpLicoreria2024.Properties.Resources.cerveza_vaso_984x6661;
			this.ClientSize = new System.Drawing.Size(1169, 553);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbxCategoria);
			this.Controls.Add(this.txtParametroProducto);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.lblTelefono);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.lblCorreo);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblRazonSocial);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.lblDocumento);
			this.Controls.Add(this.dgvListaProducto);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "FrmProducto";
			this.Text = "::: Licoreria - Producto :::";
			this.Load += new System.EventHandler(this.FrmProducto_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvListaProducto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCodigo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpNombre)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDescripcion)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtParametroProducto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.DataGridView dgvListaProducto;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ErrorProvider erpCodigo;
        private System.Windows.Forms.ErrorProvider erpNombre;
        private System.Windows.Forms.ErrorProvider erpDescripcion;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnCerrar;
	}
}