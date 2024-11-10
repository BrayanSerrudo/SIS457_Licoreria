namespace CpLicoreria2024
{
	partial class FrmDetalleCompra
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
			this.dgvDetalles = new System.Windows.Forms.DataGridView();
			this.txtTotalPagar = new System.Windows.Forms.TextBox();
			this.lblTotalPagar = new System.Windows.Forms.Label();
			this.gbxInfoCompra = new System.Windows.Forms.GroupBox();
			this.txtTipoDocumento = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtFecha = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.lblRazonSocial = new System.Windows.Forms.Label();
			this.txtRazonSocial = new System.Windows.Forms.TextBox();
			this.txtDocuProveedor = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.gbxInformacionProveedor = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNFacturaBoleta = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnLimpiarNFactura = new System.Windows.Forms.Button();
			this.btnBuscarNFactura = new System.Windows.Forms.Button();
			this.btnDescargarPdf = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
			this.gbxInfoCompra.SuspendLayout();
			this.gbxInformacionProveedor.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvDetalles
			// 
			this.dgvDetalles.AllowUserToAddRows = false;
			this.dgvDetalles.AllowUserToDeleteRows = false;
			this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetalles.Location = new System.Drawing.Point(32, 437);
			this.dgvDetalles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvDetalles.Name = "dgvDetalles";
			this.dgvDetalles.ReadOnly = true;
			this.dgvDetalles.RowHeadersWidth = 62;
			this.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDetalles.Size = new System.Drawing.Size(790, 257);
			this.dgvDetalles.TabIndex = 34;
			// 
			// txtTotalPagar
			// 
			this.txtTotalPagar.Location = new System.Drawing.Point(150, 714);
			this.txtTotalPagar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTotalPagar.Name = "txtTotalPagar";
			this.txtTotalPagar.Size = new System.Drawing.Size(133, 26);
			this.txtTotalPagar.TabIndex = 30;
			// 
			// lblTotalPagar
			// 
			this.lblTotalPagar.AutoSize = true;
			this.lblTotalPagar.Location = new System.Drawing.Point(36, 725);
			this.lblTotalPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTotalPagar.Name = "lblTotalPagar";
			this.lblTotalPagar.Size = new System.Drawing.Size(97, 20);
			this.lblTotalPagar.TabIndex = 24;
			this.lblTotalPagar.Text = "Monto Total:";
			// 
			// gbxInfoCompra
			// 
			this.gbxInfoCompra.Controls.Add(this.txtTipoDocumento);
			this.gbxInfoCompra.Controls.Add(this.txtUsuario);
			this.gbxInfoCompra.Controls.Add(this.label6);
			this.gbxInfoCompra.Controls.Add(this.txtFecha);
			this.gbxInfoCompra.Controls.Add(this.label3);
			this.gbxInfoCompra.Controls.Add(this.lblFecha);
			this.gbxInfoCompra.Location = new System.Drawing.Point(27, 168);
			this.gbxInfoCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbxInfoCompra.Name = "gbxInfoCompra";
			this.gbxInfoCompra.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbxInfoCompra.Size = new System.Drawing.Size(795, 108);
			this.gbxInfoCompra.TabIndex = 20;
			this.gbxInfoCompra.TabStop = false;
			this.gbxInfoCompra.Text = "Información Compra";
			// 
			// txtTipoDocumento
			// 
			this.txtTipoDocumento.Location = new System.Drawing.Point(242, 52);
			this.txtTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTipoDocumento.Name = "txtTipoDocumento";
			this.txtTipoDocumento.Size = new System.Drawing.Size(223, 26);
			this.txtTipoDocumento.TabIndex = 6;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(532, 52);
			this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(150, 26);
			this.txtUsuario.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(531, 22);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 20);
			this.label6.TabIndex = 4;
			this.label6.Text = "Usuario:";
			// 
			// txtFecha
			// 
			this.txtFecha.Location = new System.Drawing.Point(15, 57);
			this.txtFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtFecha.Name = "txtFecha";
			this.txtFecha.Size = new System.Drawing.Size(139, 26);
			this.txtFecha.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(236, 29);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "Tipo Documento:";
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Location = new System.Drawing.Point(10, 31);
			this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(58, 20);
			this.lblFecha.TabIndex = 0;
			this.lblFecha.Text = "Fecha:";
			// 
			// lblRazonSocial
			// 
			this.lblRazonSocial.AutoSize = true;
			this.lblRazonSocial.Location = new System.Drawing.Point(237, 34);
			this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRazonSocial.Name = "lblRazonSocial";
			this.lblRazonSocial.Size = new System.Drawing.Size(107, 20);
			this.lblRazonSocial.TabIndex = 8;
			this.lblRazonSocial.Text = "Razon Social:";
			// 
			// txtRazonSocial
			// 
			this.txtRazonSocial.Location = new System.Drawing.Point(237, 58);
			this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtRazonSocial.Name = "txtRazonSocial";
			this.txtRazonSocial.Size = new System.Drawing.Size(312, 26);
			this.txtRazonSocial.TabIndex = 7;
			// 
			// txtDocuProveedor
			// 
			this.txtDocuProveedor.Location = new System.Drawing.Point(14, 57);
			this.txtDocuProveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDocuProveedor.Name = "txtDocuProveedor";
			this.txtDocuProveedor.Size = new System.Drawing.Size(176, 26);
			this.txtDocuProveedor.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 31);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "Número Documento::";
			// 
			// gbxInformacionProveedor
			// 
			this.gbxInformacionProveedor.Controls.Add(this.lblRazonSocial);
			this.gbxInformacionProveedor.Controls.Add(this.txtRazonSocial);
			this.gbxInformacionProveedor.Controls.Add(this.txtDocuProveedor);
			this.gbxInformacionProveedor.Controls.Add(this.label4);
			this.gbxInformacionProveedor.Location = new System.Drawing.Point(27, 297);
			this.gbxInformacionProveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbxInformacionProveedor.Name = "gbxInformacionProveedor";
			this.gbxInformacionProveedor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbxInformacionProveedor.Size = new System.Drawing.Size(795, 108);
			this.gbxInformacionProveedor.TabIndex = 21;
			this.gbxInformacionProveedor.TabStop = false;
			this.gbxInformacionProveedor.Text = "Información Proveedor";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(26, 34);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(271, 33);
			this.label2.TabIndex = 19;
			this.label2.Text = "Detalle De  Compra";
			// 
			// txtNFacturaBoleta
			// 
			this.txtNFacturaBoleta.Location = new System.Drawing.Point(405, 95);
			this.txtNFacturaBoleta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtNFacturaBoleta.Name = "txtNFacturaBoleta";
			this.txtNFacturaBoleta.Size = new System.Drawing.Size(162, 26);
			this.txtNFacturaBoleta.TabIndex = 38;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(252, 95);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 20);
			this.label1.TabIndex = 39;
			this.label1.Text = "N° Factura/Boleta:";
			// 
			// btnLimpiarNFactura
			// 
			this.btnLimpiarNFactura.Image = global::CpLicoreria2024.Properties.Resources.data_cleaning_12177271;
			this.btnLimpiarNFactura.Location = new System.Drawing.Point(706, 78);
			this.btnLimpiarNFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnLimpiarNFactura.Name = "btnLimpiarNFactura";
			this.btnLimpiarNFactura.Size = new System.Drawing.Size(120, 52);
			this.btnLimpiarNFactura.TabIndex = 43;
			this.btnLimpiarNFactura.Text = "Limpiar";
			this.btnLimpiarNFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLimpiarNFactura.UseVisualStyleBackColor = true;
			// 
			// btnBuscarNFactura
			// 
			this.btnBuscarNFactura.Image = global::CpLicoreria2024.Properties.Resources.refresh_4426426;
			this.btnBuscarNFactura.Location = new System.Drawing.Point(578, 78);
			this.btnBuscarNFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnBuscarNFactura.Name = "btnBuscarNFactura";
			this.btnBuscarNFactura.Size = new System.Drawing.Size(120, 52);
			this.btnBuscarNFactura.TabIndex = 42;
			this.btnBuscarNFactura.Text = "Buscar";
			this.btnBuscarNFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBuscarNFactura.UseVisualStyleBackColor = true;
			this.btnBuscarNFactura.Click += new System.EventHandler(this.btnBuscarNFactura_Click);
			// 
			// btnDescargarPdf
			// 
			this.btnDescargarPdf.Image = global::CpLicoreria2024.Properties.Resources.sheet_14180779;
			this.btnDescargarPdf.Location = new System.Drawing.Point(610, 703);
			this.btnDescargarPdf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnDescargarPdf.Name = "btnDescargarPdf";
			this.btnDescargarPdf.Size = new System.Drawing.Size(212, 60);
			this.btnDescargarPdf.TabIndex = 41;
			this.btnDescargarPdf.Text = "Descargar en PDF";
			this.btnDescargarPdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDescargarPdf.UseVisualStyleBackColor = true;
			this.btnDescargarPdf.Click += new System.EventHandler(this.btnDescargarPdf_Click);
			// 
			// FrmDetalleCompra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(844, 792);
			this.Controls.Add(this.btnLimpiarNFactura);
			this.Controls.Add(this.btnBuscarNFactura);
			this.Controls.Add(this.btnDescargarPdf);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNFacturaBoleta);
			this.Controls.Add(this.dgvDetalles);
			this.Controls.Add(this.txtTotalPagar);
			this.Controls.Add(this.lblTotalPagar);
			this.Controls.Add(this.gbxInfoCompra);
			this.Controls.Add(this.gbxInformacionProveedor);
			this.Controls.Add(this.label2);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FrmDetalleCompra";
			this.Text = "FrmDetalleCompra";
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
			this.gbxInfoCompra.ResumeLayout(false);
			this.gbxInfoCompra.PerformLayout();
			this.gbxInformacionProveedor.ResumeLayout(false);
			this.gbxInformacionProveedor.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView dgvDetalles;
		private System.Windows.Forms.TextBox txtTotalPagar;
		private System.Windows.Forms.Label lblTotalPagar;
		private System.Windows.Forms.GroupBox gbxInfoCompra;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtFecha;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Label lblRazonSocial;
		private System.Windows.Forms.TextBox txtRazonSocial;
		private System.Windows.Forms.TextBox txtDocuProveedor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox gbxInformacionProveedor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNFacturaBoleta;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDescargarPdf;
		private System.Windows.Forms.Button btnBuscarNFactura;
		private System.Windows.Forms.Button btnLimpiarNFactura;
		private System.Windows.Forms.TextBox txtTipoDocumento;
	}
}