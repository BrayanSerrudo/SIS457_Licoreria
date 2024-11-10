namespace CpLicoreria2024
{
    partial class FrmCompra
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.gbxInfoCompra = new System.Windows.Forms.GroupBox();
			this.txtNfactura = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbxTipoDocumento = new System.Windows.Forms.ComboBox();
			this.txtFecha = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.gbxInformacionProveedor = new System.Windows.Forms.GroupBox();
			this.txtIdProveedor = new System.Windows.Forms.TextBox();
			this.lblRazonSocial = new System.Windows.Forms.Label();
			this.txtRazonSocial = new System.Windows.Forms.TextBox();
			this.txtDocuProveedor = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.gbxInfoProducto = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.nudCantidad = new System.Windows.Forms.NumericUpDown();
			this.lblPrecioVenta = new System.Windows.Forms.Label();
			this.txtPrecioVenta = new System.Windows.Forms.TextBox();
			this.lblPrecioCompra = new System.Windows.Forms.Label();
			this.txtPrecioCompra = new System.Windows.Forms.TextBox();
			this.lblProducto = new System.Windows.Forms.Label();
			this.txtProducto = new System.Windows.Forms.TextBox();
			this.txtIdProducto = new System.Windows.Forms.TextBox();
			this.lblCodigoProducto = new System.Windows.Forms.Label();
			this.txtCodigoProducto = new System.Windows.Forms.TextBox();
			this.ibtnAgregar = new FontAwesome.Sharp.IconButton();
			this.txtTotalPagar = new System.Windows.Forms.TextBox();
			this.lblTotalPagar = new System.Windows.Forms.Label();
			this.iBtnRegistrar = new FontAwesome.Sharp.IconButton();
			this.dgvCompras = new System.Windows.Forms.DataGridView();
			this.iBtnQuitar = new FontAwesome.Sharp.IconButton();
			this.erpTipoDocumento = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpNfactura = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpDocuProveedor = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpCodigoProducto = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpPrecioCompra = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpPrecioVenta = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpCantidad = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnBuscarProveedor = new System.Windows.Forms.Button();
			this.btnBuscarProducto = new System.Windows.Forms.Button();
			this.gbxInfoCompra.SuspendLayout();
			this.gbxInformacionProveedor.SuspendLayout();
			this.gbxInfoProducto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpTipoDocumento)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpNfactura)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDocuProveedor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCodigoProducto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpPrecioCompra)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpPrecioVenta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCantidad)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(-1, -2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(823, 404);
			this.label1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(11, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(156, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Registrar Compra";
			// 
			// gbxInfoCompra
			// 
			this.gbxInfoCompra.Controls.Add(this.txtNfactura);
			this.gbxInfoCompra.Controls.Add(this.label6);
			this.gbxInfoCompra.Controls.Add(this.cbxTipoDocumento);
			this.gbxInfoCompra.Controls.Add(this.txtFecha);
			this.gbxInfoCompra.Controls.Add(this.label3);
			this.gbxInfoCompra.Controls.Add(this.lblFecha);
			this.gbxInfoCompra.Location = new System.Drawing.Point(15, 57);
			this.gbxInfoCompra.Name = "gbxInfoCompra";
			this.gbxInfoCompra.Size = new System.Drawing.Size(339, 70);
			this.gbxInfoCompra.TabIndex = 3;
			this.gbxInfoCompra.TabStop = false;
			this.gbxInfoCompra.Text = "Información Compra";
			// 
			// txtNfactura
			// 
			this.txtNfactura.Location = new System.Drawing.Point(238, 37);
			this.txtNfactura.Name = "txtNfactura";
			this.txtNfactura.Size = new System.Drawing.Size(74, 20);
			this.txtNfactura.TabIndex = 5;
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
			// gbxInformacionProveedor
			// 
			this.gbxInformacionProveedor.Controls.Add(this.btnBuscarProveedor);
			this.gbxInformacionProveedor.Controls.Add(this.txtIdProveedor);
			this.gbxInformacionProveedor.Controls.Add(this.lblRazonSocial);
			this.gbxInformacionProveedor.Controls.Add(this.txtRazonSocial);
			this.gbxInformacionProveedor.Controls.Add(this.txtDocuProveedor);
			this.gbxInformacionProveedor.Controls.Add(this.label4);
			this.gbxInformacionProveedor.Location = new System.Drawing.Point(360, 57);
			this.gbxInformacionProveedor.Name = "gbxInformacionProveedor";
			this.gbxInformacionProveedor.Size = new System.Drawing.Size(447, 70);
			this.gbxInformacionProveedor.TabIndex = 4;
			this.gbxInformacionProveedor.TabStop = false;
			this.gbxInformacionProveedor.Text = "Información Proveedor";
			// 
			// txtIdProveedor
			// 
			this.txtIdProveedor.Enabled = false;
			this.txtIdProveedor.Location = new System.Drawing.Point(387, 13);
			this.txtIdProveedor.Name = "txtIdProveedor";
			this.txtIdProveedor.Size = new System.Drawing.Size(33, 20);
			this.txtIdProveedor.TabIndex = 9;
			// 
			// lblRazonSocial
			// 
			this.lblRazonSocial.AutoSize = true;
			this.lblRazonSocial.Location = new System.Drawing.Point(211, 22);
			this.lblRazonSocial.Name = "lblRazonSocial";
			this.lblRazonSocial.Size = new System.Drawing.Size(73, 13);
			this.lblRazonSocial.TabIndex = 8;
			this.lblRazonSocial.Text = "Razon Social:";
			// 
			// txtRazonSocial
			// 
			this.txtRazonSocial.Location = new System.Drawing.Point(211, 38);
			this.txtRazonSocial.Name = "txtRazonSocial";
			this.txtRazonSocial.Size = new System.Drawing.Size(209, 20);
			this.txtRazonSocial.TabIndex = 7;
			// 
			// txtDocuProveedor
			// 
			this.txtDocuProveedor.Location = new System.Drawing.Point(9, 37);
			this.txtDocuProveedor.Name = "txtDocuProveedor";
			this.txtDocuProveedor.Size = new System.Drawing.Size(119, 20);
			this.txtDocuProveedor.TabIndex = 5;
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
			// gbxInfoProducto
			// 
			this.gbxInfoProducto.Controls.Add(this.btnBuscarProducto);
			this.gbxInfoProducto.Controls.Add(this.label5);
			this.gbxInfoProducto.Controls.Add(this.nudCantidad);
			this.gbxInfoProducto.Controls.Add(this.lblPrecioVenta);
			this.gbxInfoProducto.Controls.Add(this.txtPrecioVenta);
			this.gbxInfoProducto.Controls.Add(this.lblPrecioCompra);
			this.gbxInfoProducto.Controls.Add(this.txtPrecioCompra);
			this.gbxInfoProducto.Controls.Add(this.lblProducto);
			this.gbxInfoProducto.Controls.Add(this.txtProducto);
			this.gbxInfoProducto.Controls.Add(this.txtIdProducto);
			this.gbxInfoProducto.Controls.Add(this.lblCodigoProducto);
			this.gbxInfoProducto.Controls.Add(this.txtCodigoProducto);
			this.gbxInfoProducto.Location = new System.Drawing.Point(15, 133);
			this.gbxInfoProducto.Name = "gbxInfoProducto";
			this.gbxInfoProducto.Size = new System.Drawing.Size(696, 84);
			this.gbxInfoProducto.TabIndex = 5;
			this.gbxInfoProducto.TabStop = false;
			this.gbxInfoProducto.Text = "Información de Producto";
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
			// nudCantidad
			// 
			this.nudCantidad.Location = new System.Drawing.Point(578, 51);
			this.nudCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudCantidad.Name = "nudCantidad";
			this.nudCantidad.Size = new System.Drawing.Size(79, 20);
			this.nudCantidad.TabIndex = 15;
			// 
			// lblPrecioVenta
			// 
			this.lblPrecioVenta.AutoSize = true;
			this.lblPrecioVenta.Location = new System.Drawing.Point(486, 34);
			this.lblPrecioVenta.Name = "lblPrecioVenta";
			this.lblPrecioVenta.Size = new System.Drawing.Size(71, 13);
			this.lblPrecioVenta.TabIndex = 13;
			this.lblPrecioVenta.Text = "Precio Venta:";
			// 
			// txtPrecioVenta
			// 
			this.txtPrecioVenta.Location = new System.Drawing.Point(487, 50);
			this.txtPrecioVenta.Name = "txtPrecioVenta";
			this.txtPrecioVenta.Size = new System.Drawing.Size(75, 20);
			this.txtPrecioVenta.TabIndex = 14;
			// 
			// lblPrecioCompra
			// 
			this.lblPrecioCompra.AutoSize = true;
			this.lblPrecioCompra.Location = new System.Drawing.Point(395, 34);
			this.lblPrecioCompra.Name = "lblPrecioCompra";
			this.lblPrecioCompra.Size = new System.Drawing.Size(79, 13);
			this.lblPrecioCompra.TabIndex = 11;
			this.lblPrecioCompra.Text = "Precio Compra:";
			// 
			// txtPrecioCompra
			// 
			this.txtPrecioCompra.Location = new System.Drawing.Point(398, 50);
			this.txtPrecioCompra.Name = "txtPrecioCompra";
			this.txtPrecioCompra.Size = new System.Drawing.Size(76, 20);
			this.txtPrecioCompra.TabIndex = 12;
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
			// ibtnAgregar
			// 
			this.ibtnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.ibtnAgregar.IconColor = System.Drawing.Color.ForestGreen;
			this.ibtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.ibtnAgregar.Location = new System.Drawing.Point(717, 133);
			this.ibtnAgregar.Name = "ibtnAgregar";
			this.ibtnAgregar.Size = new System.Drawing.Size(90, 85);
			this.ibtnAgregar.TabIndex = 7;
			this.ibtnAgregar.Text = "Agregar";
			this.ibtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.ibtnAgregar.UseVisualStyleBackColor = true;
			this.ibtnAgregar.Click += new System.EventHandler(this.ibtnAgregar_Click);
			// 
			// txtTotalPagar
			// 
			this.txtTotalPagar.Location = new System.Drawing.Point(717, 310);
			this.txtTotalPagar.Name = "txtTotalPagar";
			this.txtTotalPagar.Size = new System.Drawing.Size(90, 20);
			this.txtTotalPagar.TabIndex = 11;
			this.txtTotalPagar.TextChanged += new System.EventHandler(this.txtTotalPagar_TextChanged);
			// 
			// lblTotalPagar
			// 
			this.lblTotalPagar.AutoSize = true;
			this.lblTotalPagar.Location = new System.Drawing.Point(723, 294);
			this.lblTotalPagar.Name = "lblTotalPagar";
			this.lblTotalPagar.Size = new System.Drawing.Size(74, 13);
			this.lblTotalPagar.TabIndex = 10;
			this.lblTotalPagar.Text = "Total a Pagar:";
			this.lblTotalPagar.Click += new System.EventHandler(this.lblTotalPagar_Click);
			// 
			// iBtnRegistrar
			// 
			this.iBtnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Store;
			this.iBtnRegistrar.IconColor = System.Drawing.Color.MediumTurquoise;
			this.iBtnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iBtnRegistrar.IconSize = 30;
			this.iBtnRegistrar.Location = new System.Drawing.Point(717, 336);
			this.iBtnRegistrar.Name = "iBtnRegistrar";
			this.iBtnRegistrar.Size = new System.Drawing.Size(90, 55);
			this.iBtnRegistrar.TabIndex = 12;
			this.iBtnRegistrar.Text = "Regístrar";
			this.iBtnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iBtnRegistrar.UseVisualStyleBackColor = true;
			this.iBtnRegistrar.Click += new System.EventHandler(this.iBtnRegistrar_Click);
			// 
			// dgvCompras
			// 
			this.dgvCompras.AllowUserToAddRows = false;
			this.dgvCompras.AllowUserToDeleteRows = false;
			this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCompras.Location = new System.Drawing.Point(15, 224);
			this.dgvCompras.Name = "dgvCompras";
			this.dgvCompras.ReadOnly = true;
			this.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCompras.Size = new System.Drawing.Size(696, 167);
			this.dgvCompras.TabIndex = 13;
			// 
			// iBtnQuitar
			// 
			this.iBtnQuitar.IconChar = FontAwesome.Sharp.IconChar.Remove;
			this.iBtnQuitar.IconColor = System.Drawing.Color.Crimson;
			this.iBtnQuitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iBtnQuitar.Location = new System.Drawing.Point(726, 224);
			this.iBtnQuitar.Name = "iBtnQuitar";
			this.iBtnQuitar.Size = new System.Drawing.Size(61, 54);
			this.iBtnQuitar.TabIndex = 14;
			this.iBtnQuitar.Text = "Quitar";
			this.iBtnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.iBtnQuitar.UseVisualStyleBackColor = true;
			this.iBtnQuitar.Click += new System.EventHandler(this.iBtnQuitar_Click);
			// 
			// erpTipoDocumento
			// 
			this.erpTipoDocumento.ContainerControl = this;
			// 
			// erpNfactura
			// 
			this.erpNfactura.ContainerControl = this;
			// 
			// erpDocuProveedor
			// 
			this.erpDocuProveedor.ContainerControl = this;
			// 
			// erpCodigoProducto
			// 
			this.erpCodigoProducto.ContainerControl = this;
			// 
			// erpPrecioCompra
			// 
			this.erpPrecioCompra.ContainerControl = this;
			// 
			// erpPrecioVenta
			// 
			this.erpPrecioVenta.ContainerControl = this;
			// 
			// erpCantidad
			// 
			this.erpCantidad.ContainerControl = this;
			// 
			// btnBuscarProveedor
			// 
			this.btnBuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscarProveedor.Image = global::CpLicoreria2024.Properties.Resources.buscar;
			this.btnBuscarProveedor.Location = new System.Drawing.Point(144, 22);
			this.btnBuscarProveedor.Name = "btnBuscarProveedor";
			this.btnBuscarProveedor.Size = new System.Drawing.Size(42, 41);
			this.btnBuscarProveedor.TabIndex = 17;
			this.btnBuscarProveedor.UseVisualStyleBackColor = true;
			this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
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
			// FrmCompra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(826, 414);
			this.Controls.Add(this.iBtnQuitar);
			this.Controls.Add(this.dgvCompras);
			this.Controls.Add(this.iBtnRegistrar);
			this.Controls.Add(this.txtTotalPagar);
			this.Controls.Add(this.ibtnAgregar);
			this.Controls.Add(this.lblTotalPagar);
			this.Controls.Add(this.gbxInfoProducto);
			this.Controls.Add(this.gbxInformacionProveedor);
			this.Controls.Add(this.gbxInfoCompra);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmCompra";
			this.Text = "FrmCompra";
			this.Load += new System.EventHandler(this.FrmCompra_Load);
			this.gbxInfoCompra.ResumeLayout(false);
			this.gbxInfoCompra.PerformLayout();
			this.gbxInformacionProveedor.ResumeLayout(false);
			this.gbxInformacionProveedor.PerformLayout();
			this.gbxInfoProducto.ResumeLayout(false);
			this.gbxInfoProducto.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpTipoDocumento)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpNfactura)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDocuProveedor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCodigoProducto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpPrecioCompra)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpPrecioVenta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCantidad)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxInfoCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cbxTipoDocumento;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.GroupBox gbxInformacionProveedor;
        private System.Windows.Forms.TextBox txtDocuProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.GroupBox gbxInfoProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private FontAwesome.Sharp.IconButton ibtnAgregar;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label lblTotalPagar;
        private FontAwesome.Sharp.IconButton iBtnRegistrar;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.TextBox txtNfactura;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton iBtnQuitar;
        private System.Windows.Forms.ErrorProvider erpTipoDocumento;
        private System.Windows.Forms.ErrorProvider erpNfactura;
        private System.Windows.Forms.ErrorProvider erpDocuProveedor;
        private System.Windows.Forms.ErrorProvider erpCodigoProducto;
        private System.Windows.Forms.ErrorProvider erpPrecioCompra;
        private System.Windows.Forms.ErrorProvider erpPrecioVenta;
        private System.Windows.Forms.ErrorProvider erpCantidad;
		private System.Windows.Forms.Button btnBuscarProveedor;
		private System.Windows.Forms.Button btnBuscarProducto;
	}
}