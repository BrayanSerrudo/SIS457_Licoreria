namespace CpLicoreria2024
{
	partial class FrmVenta
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
			this.dgvVentas = new System.Windows.Forms.DataGridView();
			this.txtMontoAPagar = new System.Windows.Forms.TextBox();
			this.lblTotalPagar = new System.Windows.Forms.Label();
			this.gbxInfoProducto = new System.Windows.Forms.GroupBox();
			this.btnBuscarProducto = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.nudCantidadVender = new System.Windows.Forms.NumericUpDown();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.txtPrecioVenta = new System.Windows.Forms.TextBox();
			this.lblStock = new System.Windows.Forms.Label();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.lblProducto = new System.Windows.Forms.Label();
			this.txtProducto = new System.Windows.Forms.TextBox();
			this.txtIdProducto = new System.Windows.Forms.TextBox();
			this.lblCodigoProducto = new System.Windows.Forms.Label();
			this.txtCodigoProducto = new System.Windows.Forms.TextBox();
			this.gbxInformacionCliente = new System.Windows.Forms.GroupBox();
			this.btnBuscarCliente = new System.Windows.Forms.Button();
			this.txtIdCliente = new System.Windows.Forms.TextBox();
			this.lblNombreCompleto = new System.Windows.Forms.Label();
			this.txtNombreCliente = new System.Windows.Forms.TextBox();
			this.txtDocuCliente = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.gbxInfoCompra = new System.Windows.Forms.GroupBox();
			this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbxTipoDocumento = new System.Windows.Forms.ComboBox();
			this.txtFecha = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.lblRegistroVenta = new System.Windows.Forms.Label();
			this.txtPagaCon = new System.Windows.Forms.TextBox();
			this.lblPagoCon = new System.Windows.Forms.Label();
			this.txtCambio = new System.Windows.Forms.TextBox();
			this.lblCambio = new System.Windows.Forms.Label();
			this.iBtnQuitar = new FontAwesome.Sharp.IconButton();
			this.iBtnCrearVenta = new FontAwesome.Sharp.IconButton();
			this.ibtnAgregar = new FontAwesome.Sharp.IconButton();
			this.erpTipoDocumento = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpNfactura = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpDocuCliente = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpCodigoProducto = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpCantidadVender = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpPagaCon = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
			this.gbxInfoProducto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidadVender)).BeginInit();
			this.gbxInformacionCliente.SuspendLayout();
			this.gbxInfoCompra.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.erpTipoDocumento)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpNfactura)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDocuCliente)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCodigoProducto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCantidadVender)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpPagaCon)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvVentas
			// 
			this.dgvVentas.AllowUserToAddRows = false;
			this.dgvVentas.AllowUserToDeleteRows = false;
			this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVentas.Location = new System.Drawing.Point(19, 226);
			this.dgvVentas.Name = "dgvVentas";
			this.dgvVentas.ReadOnly = true;
			this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvVentas.Size = new System.Drawing.Size(696, 266);
			this.dgvVentas.TabIndex = 23;
			// 
			// txtMontoAPagar
			// 
			this.txtMontoAPagar.Location = new System.Drawing.Point(721, 312);
			this.txtMontoAPagar.Name = "txtMontoAPagar";
			this.txtMontoAPagar.Size = new System.Drawing.Size(90, 20);
			this.txtMontoAPagar.TabIndex = 21;
			// 
			// lblTotalPagar
			// 
			this.lblTotalPagar.AutoSize = true;
			this.lblTotalPagar.Location = new System.Drawing.Point(727, 296);
			this.lblTotalPagar.Name = "lblTotalPagar";
			this.lblTotalPagar.Size = new System.Drawing.Size(74, 13);
			this.lblTotalPagar.TabIndex = 20;
			this.lblTotalPagar.Text = "Total a Pagar:";
			// 
			// gbxInfoProducto
			// 
			this.gbxInfoProducto.Controls.Add(this.btnBuscarProducto);
			this.gbxInfoProducto.Controls.Add(this.label5);
			this.gbxInfoProducto.Controls.Add(this.nudCantidadVender);
			this.gbxInfoProducto.Controls.Add(this.lblPrecio);
			this.gbxInfoProducto.Controls.Add(this.txtPrecioVenta);
			this.gbxInfoProducto.Controls.Add(this.lblStock);
			this.gbxInfoProducto.Controls.Add(this.txtStock);
			this.gbxInfoProducto.Controls.Add(this.lblProducto);
			this.gbxInfoProducto.Controls.Add(this.txtProducto);
			this.gbxInfoProducto.Controls.Add(this.txtIdProducto);
			this.gbxInfoProducto.Controls.Add(this.lblCodigoProducto);
			this.gbxInfoProducto.Controls.Add(this.txtCodigoProducto);
			this.gbxInfoProducto.Location = new System.Drawing.Point(19, 135);
			this.gbxInfoProducto.Name = "gbxInfoProducto";
			this.gbxInfoProducto.Size = new System.Drawing.Size(696, 84);
			this.gbxInfoProducto.TabIndex = 18;
			this.gbxInfoProducto.TabStop = false;
			this.gbxInfoProducto.Text = "Información de Producto";
			// 
			// btnBuscarProducto
			// 
			this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscarProducto.Image = global::CpLicoreria2024.Properties.Resources.buscar;
			this.btnBuscarProducto.Location = new System.Drawing.Point(148, 39);
			this.btnBuscarProducto.Name = "btnBuscarProducto";
			this.btnBuscarProducto.Size = new System.Drawing.Size(42, 41);
			this.btnBuscarProducto.TabIndex = 18;
			this.btnBuscarProducto.UseVisualStyleBackColor = true;
			this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(577, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "Cantidad:";
			// 
			// nudCantidadVender
			// 
			this.nudCantidadVender.Location = new System.Drawing.Point(578, 51);
			this.nudCantidadVender.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudCantidadVender.Name = "nudCantidadVender";
			this.nudCantidadVender.Size = new System.Drawing.Size(79, 20);
			this.nudCantidadVender.TabIndex = 15;
			// 
			// lblPrecio
			// 
			this.lblPrecio.AutoSize = true;
			this.lblPrecio.Location = new System.Drawing.Point(486, 34);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(40, 13);
			this.lblPrecio.TabIndex = 13;
			this.lblPrecio.Text = "Precio:";
			// 
			// txtPrecioVenta
			// 
			this.txtPrecioVenta.Location = new System.Drawing.Point(487, 50);
			this.txtPrecioVenta.Name = "txtPrecioVenta";
			this.txtPrecioVenta.Size = new System.Drawing.Size(75, 20);
			this.txtPrecioVenta.TabIndex = 14;
			// 
			// lblStock
			// 
			this.lblStock.AutoSize = true;
			this.lblStock.Location = new System.Drawing.Point(395, 34);
			this.lblStock.Name = "lblStock";
			this.lblStock.Size = new System.Drawing.Size(38, 13);
			this.lblStock.TabIndex = 11;
			this.lblStock.Text = "Stock:";
			// 
			// txtStock
			// 
			this.txtStock.Location = new System.Drawing.Point(398, 50);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(76, 20);
			this.txtStock.TabIndex = 12;
			// 
			// lblProducto
			// 
			this.lblProducto.AutoSize = true;
			this.lblProducto.Location = new System.Drawing.Point(205, 32);
			this.lblProducto.Name = "lblProducto";
			this.lblProducto.Size = new System.Drawing.Size(53, 13);
			this.lblProducto.TabIndex = 10;
			this.lblProducto.Text = "Producto:";
			// 
			// txtProducto
			// 
			this.txtProducto.Location = new System.Drawing.Point(208, 52);
			this.txtProducto.Name = "txtProducto";
			this.txtProducto.Size = new System.Drawing.Size(171, 20);
			this.txtProducto.TabIndex = 10;
			// 
			// txtIdProducto
			// 
			this.txtIdProducto.Enabled = false;
			this.txtIdProducto.Location = new System.Drawing.Point(96, 25);
			this.txtIdProducto.Name = "txtIdProducto";
			this.txtIdProducto.Size = new System.Drawing.Size(33, 20);
			this.txtIdProducto.TabIndex = 10;
			// 
			// lblCodigoProducto
			// 
			this.lblCodigoProducto.AutoSize = true;
			this.lblCodigoProducto.Location = new System.Drawing.Point(7, 35);
			this.lblCodigoProducto.Name = "lblCodigoProducto";
			this.lblCodigoProducto.Size = new System.Drawing.Size(78, 13);
			this.lblCodigoProducto.TabIndex = 10;
			this.lblCodigoProducto.Text = "Cod. Producto:";
			// 
			// txtCodigoProducto
			// 
			this.txtCodigoProducto.Location = new System.Drawing.Point(10, 51);
			this.txtCodigoProducto.Name = "txtCodigoProducto";
			this.txtCodigoProducto.Size = new System.Drawing.Size(119, 20);
			this.txtCodigoProducto.TabIndex = 10;
			// 
			// gbxInformacionCliente
			// 
			this.gbxInformacionCliente.Controls.Add(this.btnBuscarCliente);
			this.gbxInformacionCliente.Controls.Add(this.txtIdCliente);
			this.gbxInformacionCliente.Controls.Add(this.lblNombreCompleto);
			this.gbxInformacionCliente.Controls.Add(this.txtNombreCliente);
			this.gbxInformacionCliente.Controls.Add(this.txtDocuCliente);
			this.gbxInformacionCliente.Controls.Add(this.label4);
			this.gbxInformacionCliente.Location = new System.Drawing.Point(364, 59);
			this.gbxInformacionCliente.Name = "gbxInformacionCliente";
			this.gbxInformacionCliente.Size = new System.Drawing.Size(447, 70);
			this.gbxInformacionCliente.TabIndex = 17;
			this.gbxInformacionCliente.TabStop = false;
			this.gbxInformacionCliente.Text = "Información Cliente";
			// 
			// btnBuscarCliente
			// 
			this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscarCliente.Image = global::CpLicoreria2024.Properties.Resources.buscar;
			this.btnBuscarCliente.Location = new System.Drawing.Point(144, 22);
			this.btnBuscarCliente.Name = "btnBuscarCliente";
			this.btnBuscarCliente.Size = new System.Drawing.Size(42, 41);
			this.btnBuscarCliente.TabIndex = 17;
			this.btnBuscarCliente.UseVisualStyleBackColor = true;
			this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
			// 
			// txtIdCliente
			// 
			this.txtIdCliente.Enabled = false;
			this.txtIdCliente.Location = new System.Drawing.Point(387, 13);
			this.txtIdCliente.Name = "txtIdCliente";
			this.txtIdCliente.Size = new System.Drawing.Size(33, 20);
			this.txtIdCliente.TabIndex = 9;
			// 
			// lblNombreCompleto
			// 
			this.lblNombreCompleto.AutoSize = true;
			this.lblNombreCompleto.Location = new System.Drawing.Point(211, 22);
			this.lblNombreCompleto.Name = "lblNombreCompleto";
			this.lblNombreCompleto.Size = new System.Drawing.Size(91, 13);
			this.lblNombreCompleto.TabIndex = 8;
			this.lblNombreCompleto.Text = "Nombre Completo";
			// 
			// txtNombreCliente
			// 
			this.txtNombreCliente.Location = new System.Drawing.Point(211, 38);
			this.txtNombreCliente.Name = "txtNombreCliente";
			this.txtNombreCliente.Size = new System.Drawing.Size(209, 20);
			this.txtNombreCliente.TabIndex = 7;
			// 
			// txtDocuCliente
			// 
			this.txtDocuCliente.Location = new System.Drawing.Point(9, 37);
			this.txtDocuCliente.Name = "txtDocuCliente";
			this.txtDocuCliente.Size = new System.Drawing.Size(119, 20);
			this.txtDocuCliente.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(108, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Número Documento::";
			// 
			// gbxInfoCompra
			// 
			this.gbxInfoCompra.Controls.Add(this.txtNumeroDocumento);
			this.gbxInfoCompra.Controls.Add(this.label6);
			this.gbxInfoCompra.Controls.Add(this.cbxTipoDocumento);
			this.gbxInfoCompra.Controls.Add(this.txtFecha);
			this.gbxInfoCompra.Controls.Add(this.label3);
			this.gbxInfoCompra.Controls.Add(this.lblFecha);
			this.gbxInfoCompra.Location = new System.Drawing.Point(19, 59);
			this.gbxInfoCompra.Name = "gbxInfoCompra";
			this.gbxInfoCompra.Size = new System.Drawing.Size(339, 70);
			this.gbxInfoCompra.TabIndex = 16;
			this.gbxInfoCompra.TabStop = false;
			this.gbxInfoCompra.Text = "Información Venta";
			// 
			// txtNumeroDocumento
			// 
			this.txtNumeroDocumento.Location = new System.Drawing.Point(238, 37);
			this.txtNumeroDocumento.Name = "txtNumeroDocumento";
			this.txtNumeroDocumento.Size = new System.Drawing.Size(74, 20);
			this.txtNumeroDocumento.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(237, 17);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "N° Factura/Boleta";
			// 
			// cbxTipoDocumento
			// 
			this.cbxTipoDocumento.FormattingEnabled = true;
			this.cbxTipoDocumento.Items.AddRange(new object[] {
            "Factura",
            "Boleta"});
			this.cbxTipoDocumento.Location = new System.Drawing.Point(109, 35);
			this.cbxTipoDocumento.Name = "cbxTipoDocumento";
			this.cbxTipoDocumento.Size = new System.Drawing.Size(121, 21);
			this.cbxTipoDocumento.TabIndex = 3;
			// 
			// txtFecha
			// 
			this.txtFecha.Location = new System.Drawing.Point(10, 37);
			this.txtFecha.Name = "txtFecha";
			this.txtFecha.Size = new System.Drawing.Size(94, 20);
			this.txtFecha.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(103, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Tipo Documento:";
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Location = new System.Drawing.Point(7, 20);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(40, 13);
			this.lblFecha.TabIndex = 0;
			this.lblFecha.Text = "Fecha:";
			// 
			// lblRegistroVenta
			// 
			this.lblRegistroVenta.AutoSize = true;
			this.lblRegistroVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRegistroVenta.Location = new System.Drawing.Point(15, 22);
			this.lblRegistroVenta.Name = "lblRegistroVenta";
			this.lblRegistroVenta.Size = new System.Drawing.Size(138, 24);
			this.lblRegistroVenta.TabIndex = 15;
			this.lblRegistroVenta.Text = "Registrar Venta";
			// 
			// txtPagaCon
			// 
			this.txtPagaCon.Location = new System.Drawing.Point(721, 362);
			this.txtPagaCon.Name = "txtPagaCon";
			this.txtPagaCon.Size = new System.Drawing.Size(90, 20);
			this.txtPagaCon.TabIndex = 26;
			this.txtPagaCon.TextChanged += new System.EventHandler(this.txtPagaCon_TextChanged);
			// 
			// lblPagoCon
			// 
			this.lblPagoCon.AutoSize = true;
			this.lblPagoCon.Location = new System.Drawing.Point(727, 346);
			this.lblPagoCon.Name = "lblPagoCon";
			this.lblPagoCon.Size = new System.Drawing.Size(56, 13);
			this.lblPagoCon.TabIndex = 25;
			this.lblPagoCon.Text = "Paga con:";
			// 
			// txtCambio
			// 
			this.txtCambio.Location = new System.Drawing.Point(721, 411);
			this.txtCambio.Name = "txtCambio";
			this.txtCambio.Size = new System.Drawing.Size(90, 20);
			this.txtCambio.TabIndex = 28;
			// 
			// lblCambio
			// 
			this.lblCambio.AutoSize = true;
			this.lblCambio.Location = new System.Drawing.Point(727, 395);
			this.lblCambio.Name = "lblCambio";
			this.lblCambio.Size = new System.Drawing.Size(45, 13);
			this.lblCambio.TabIndex = 27;
			this.lblCambio.Text = "Cambio:";
			// 
			// iBtnQuitar
			// 
			this.iBtnQuitar.IconChar = FontAwesome.Sharp.IconChar.Remove;
			this.iBtnQuitar.IconColor = System.Drawing.Color.Crimson;
			this.iBtnQuitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iBtnQuitar.Location = new System.Drawing.Point(730, 226);
			this.iBtnQuitar.Name = "iBtnQuitar";
			this.iBtnQuitar.Size = new System.Drawing.Size(61, 54);
			this.iBtnQuitar.TabIndex = 24;
			this.iBtnQuitar.Text = "Quitar";
			this.iBtnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.iBtnQuitar.UseVisualStyleBackColor = true;
			this.iBtnQuitar.Click += new System.EventHandler(this.iBtnQuitar_Click);
			// 
			// iBtnCrearVenta
			// 
			this.iBtnCrearVenta.IconChar = FontAwesome.Sharp.IconChar.Store;
			this.iBtnCrearVenta.IconColor = System.Drawing.Color.MediumTurquoise;
			this.iBtnCrearVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iBtnCrearVenta.IconSize = 30;
			this.iBtnCrearVenta.Location = new System.Drawing.Point(721, 437);
			this.iBtnCrearVenta.Name = "iBtnCrearVenta";
			this.iBtnCrearVenta.Size = new System.Drawing.Size(90, 55);
			this.iBtnCrearVenta.TabIndex = 22;
			this.iBtnCrearVenta.Text = "Crear Venta";
			this.iBtnCrearVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iBtnCrearVenta.UseVisualStyleBackColor = true;
			this.iBtnCrearVenta.Click += new System.EventHandler(this.iBtnCrearVenta_Click);
			// 
			// ibtnAgregar
			// 
			this.ibtnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.ibtnAgregar.IconColor = System.Drawing.Color.ForestGreen;
			this.ibtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.ibtnAgregar.Location = new System.Drawing.Point(721, 135);
			this.ibtnAgregar.Name = "ibtnAgregar";
			this.ibtnAgregar.Size = new System.Drawing.Size(90, 85);
			this.ibtnAgregar.TabIndex = 19;
			this.ibtnAgregar.Text = "Agregar";
			this.ibtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.ibtnAgregar.UseVisualStyleBackColor = true;
			this.ibtnAgregar.Click += new System.EventHandler(this.ibtnAgregar_Click);
			// 
			// erpTipoDocumento
			// 
			this.erpTipoDocumento.ContainerControl = this;
			// 
			// erpNfactura
			// 
			this.erpNfactura.ContainerControl = this;
			// 
			// erpDocuCliente
			// 
			this.erpDocuCliente.ContainerControl = this;
			// 
			// erpCodigoProducto
			// 
			this.erpCodigoProducto.ContainerControl = this;
			// 
			// erpCantidadVender
			// 
			this.erpCantidadVender.ContainerControl = this;
			// 
			// erpPagaCon
			// 
			this.erpPagaCon.ContainerControl = this;
			// 
			// FrmVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(826, 504);
			this.Controls.Add(this.txtCambio);
			this.Controls.Add(this.lblCambio);
			this.Controls.Add(this.txtPagaCon);
			this.Controls.Add(this.lblPagoCon);
			this.Controls.Add(this.iBtnQuitar);
			this.Controls.Add(this.dgvVentas);
			this.Controls.Add(this.iBtnCrearVenta);
			this.Controls.Add(this.txtMontoAPagar);
			this.Controls.Add(this.ibtnAgregar);
			this.Controls.Add(this.lblTotalPagar);
			this.Controls.Add(this.gbxInfoProducto);
			this.Controls.Add(this.gbxInformacionCliente);
			this.Controls.Add(this.gbxInfoCompra);
			this.Controls.Add(this.lblRegistroVenta);
			this.Name = "FrmVenta";
			this.Text = "FrmVenta";
			this.Load += new System.EventHandler(this.FrmVenta_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
			this.gbxInfoProducto.ResumeLayout(false);
			this.gbxInfoProducto.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidadVender)).EndInit();
			this.gbxInformacionCliente.ResumeLayout(false);
			this.gbxInformacionCliente.PerformLayout();
			this.gbxInfoCompra.ResumeLayout(false);
			this.gbxInfoCompra.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.erpTipoDocumento)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpNfactura)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDocuCliente)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCodigoProducto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCantidadVender)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpPagaCon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private FontAwesome.Sharp.IconButton iBtnQuitar;
		private System.Windows.Forms.DataGridView dgvVentas;
		private FontAwesome.Sharp.IconButton iBtnCrearVenta;
		private System.Windows.Forms.TextBox txtMontoAPagar;
		private FontAwesome.Sharp.IconButton ibtnAgregar;
		private System.Windows.Forms.Label lblTotalPagar;
		private System.Windows.Forms.GroupBox gbxInfoProducto;
		private System.Windows.Forms.Button btnBuscarProducto;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown nudCantidadVender;
		private System.Windows.Forms.Label lblPrecio;
		private System.Windows.Forms.TextBox txtPrecioVenta;
		private System.Windows.Forms.Label lblStock;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.Label lblProducto;
		private System.Windows.Forms.TextBox txtProducto;
		private System.Windows.Forms.TextBox txtIdProducto;
		private System.Windows.Forms.Label lblCodigoProducto;
		private System.Windows.Forms.TextBox txtCodigoProducto;
		private System.Windows.Forms.GroupBox gbxInformacionCliente;
		private System.Windows.Forms.Button btnBuscarCliente;
		private System.Windows.Forms.TextBox txtIdCliente;
		private System.Windows.Forms.Label lblNombreCompleto;
		private System.Windows.Forms.TextBox txtNombreCliente;
		private System.Windows.Forms.TextBox txtDocuCliente;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox gbxInfoCompra;
		private System.Windows.Forms.TextBox txtNumeroDocumento;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbxTipoDocumento;
		private System.Windows.Forms.TextBox txtFecha;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Label lblRegistroVenta;
		private System.Windows.Forms.TextBox txtPagaCon;
		private System.Windows.Forms.Label lblPagoCon;
		private System.Windows.Forms.TextBox txtCambio;
		private System.Windows.Forms.Label lblCambio;
		private System.Windows.Forms.ErrorProvider erpTipoDocumento;
		private System.Windows.Forms.ErrorProvider erpNfactura;
		private System.Windows.Forms.ErrorProvider erpDocuCliente;
		private System.Windows.Forms.ErrorProvider erpCodigoProducto;
		private System.Windows.Forms.ErrorProvider erpCantidadVender;
		private System.Windows.Forms.ErrorProvider erpPagaCon;
	}
}