namespace CpLicoreria2024
{
    partial class FrmProveedor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.erpTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCorreo = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpRazonSocial = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDocumento = new System.Windows.Forms.ErrorProvider(this.components);
            this.iBtnNuevo = new FontAwesome.Sharp.IconButton();
            this.iBtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.ibtnCerrar = new FontAwesome.Sharp.IconButton();
            this.iBtnBuscar = new FontAwesome.Sharp.IconButton();
            this.iBtnEditar = new FontAwesome.Sharp.IconButton();
            this.iBtnEliminar = new FontAwesome.Sharp.IconButton();
            this.iBtnGuardar = new FontAwesome.Sharp.IconButton();
            this.txtParametroProveedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpRazonSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDocumento)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(22, 239);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(210, 22);
            this.txtTelefono.TabIndex = 60;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.BackColor = System.Drawing.Color.White;
            this.lblBusqueda.Location = new System.Drawing.Point(284, 42);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(64, 13);
            this.lblBusqueda.TabIndex = 58;
            this.lblBusqueda.Text = "Buscar por :";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.BackColor = System.Drawing.Color.White;
            this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(251, 9);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(664, 85);
            this.lblSubtitulo.TabIndex = 57;
            this.lblSubtitulo.Text = "Lista de Proveedores:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(18, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(184, 20);
            this.lblTitulo.TabIndex = 56;
            this.lblTitulo.Text = "Detalle de Proveedores";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(19, 220);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 16);
            this.lblTelefono.TabIndex = 55;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(22, 181);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(210, 22);
            this.txtCorreo.TabIndex = 54;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.SystemColors.Control;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(19, 160);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(51, 16);
            this.lblCorreo.TabIndex = 53;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(22, 123);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(210, 22);
            this.txtRazonSocial.TabIndex = 52;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.BackColor = System.Drawing.SystemColors.Control;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(19, 102);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(90, 16);
            this.lblRazonSocial.TabIndex = 51;
            this.lblRazonSocial.Text = "Razon Social:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(22, 65);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(210, 22);
            this.txtDocumento.TabIndex = 50;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.BackColor = System.Drawing.SystemColors.Control;
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(19, 44);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(96, 16);
            this.lblDocumento.TabIndex = 49;
            this.lblDocumento.Text = "N° Documento:";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(251, 102);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(664, 381);
            this.dgvLista.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(242, 533);
            this.label1.TabIndex = 47;
            // 
            // erpTelefono
            // 
            this.erpTelefono.ContainerControl = this;
            // 
            // erpCorreo
            // 
            this.erpCorreo.ContainerControl = this;
            // 
            // erpRazonSocial
            // 
            this.erpRazonSocial.ContainerControl = this;
            // 
            // erpDocumento
            // 
            this.erpDocumento.ContainerControl = this;
            // 
            // iBtnNuevo
            // 
            this.iBtnNuevo.AutoEllipsis = true;
            this.iBtnNuevo.BackColor = System.Drawing.Color.DodgerBlue;
            this.iBtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iBtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iBtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnNuevo.ForeColor = System.Drawing.Color.White;
            this.iBtnNuevo.IconChar = FontAwesome.Sharp.IconChar.Notdef;
            this.iBtnNuevo.IconColor = System.Drawing.Color.White;
            this.iBtnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnNuevo.IconSize = 32;
            this.iBtnNuevo.Location = new System.Drawing.Point(30, 268);
            this.iBtnNuevo.Name = "iBtnNuevo";
            this.iBtnNuevo.Size = new System.Drawing.Size(152, 36);
            this.iBtnNuevo.TabIndex = 68;
            this.iBtnNuevo.Text = "Nuevo";
            this.iBtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iBtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnNuevo.UseVisualStyleBackColor = false;
            this.iBtnNuevo.Click += new System.EventHandler(this.iBtnNuevo_Click);
            // 
            // iBtnLimpiar
            // 
            this.iBtnLimpiar.BackColor = System.Drawing.Color.DarkGreen;
            this.iBtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iBtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iBtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.iBtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iBtnLimpiar.IconColor = System.Drawing.Color.White;
            this.iBtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnLimpiar.IconSize = 32;
            this.iBtnLimpiar.Location = new System.Drawing.Point(826, 27);
            this.iBtnLimpiar.Name = "iBtnLimpiar";
            this.iBtnLimpiar.Size = new System.Drawing.Size(82, 43);
            this.iBtnLimpiar.TabIndex = 67;
            this.iBtnLimpiar.Text = "Clear";
            this.iBtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnLimpiar.UseVisualStyleBackColor = false;
            this.iBtnLimpiar.Click += new System.EventHandler(this.iBtnLimpiar_Click);
            // 
            // ibtnCerrar
            // 
            this.ibtnCerrar.BackColor = System.Drawing.Color.Gold;
            this.ibtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCerrar.ForeColor = System.Drawing.Color.White;
            this.ibtnCerrar.IconChar = FontAwesome.Sharp.IconChar.Equals;
            this.ibtnCerrar.IconColor = System.Drawing.Color.White;
            this.ibtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCerrar.IconSize = 32;
            this.ibtnCerrar.Location = new System.Drawing.Point(30, 437);
            this.ibtnCerrar.Name = "ibtnCerrar";
            this.ibtnCerrar.Size = new System.Drawing.Size(152, 36);
            this.ibtnCerrar.TabIndex = 66;
            this.ibtnCerrar.Text = "Cerrar";
            this.ibtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnCerrar.UseVisualStyleBackColor = false;
            this.ibtnCerrar.Click += new System.EventHandler(this.ibtnCerrar_Click);
            // 
            // iBtnBuscar
            // 
            this.iBtnBuscar.BackColor = System.Drawing.Color.DarkGreen;
            this.iBtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iBtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iBtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnBuscar.ForeColor = System.Drawing.Color.White;
            this.iBtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.iBtnBuscar.IconColor = System.Drawing.Color.White;
            this.iBtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnBuscar.IconSize = 32;
            this.iBtnBuscar.Location = new System.Drawing.Point(734, 27);
            this.iBtnBuscar.Name = "iBtnBuscar";
            this.iBtnBuscar.Size = new System.Drawing.Size(86, 43);
            this.iBtnBuscar.TabIndex = 65;
            this.iBtnBuscar.Text = "Buscar";
            this.iBtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnBuscar.UseVisualStyleBackColor = false;
            this.iBtnBuscar.Click += new System.EventHandler(this.iBtnBuscar_Click);
            // 
            // iBtnEditar
            // 
            this.iBtnEditar.BackColor = System.Drawing.Color.MediumBlue;
            this.iBtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iBtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iBtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnEditar.ForeColor = System.Drawing.Color.White;
            this.iBtnEditar.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.iBtnEditar.IconColor = System.Drawing.Color.White;
            this.iBtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnEditar.IconSize = 32;
            this.iBtnEditar.Location = new System.Drawing.Point(30, 352);
            this.iBtnEditar.Name = "iBtnEditar";
            this.iBtnEditar.Size = new System.Drawing.Size(152, 37);
            this.iBtnEditar.TabIndex = 64;
            this.iBtnEditar.Text = "Editar";
            this.iBtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iBtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnEditar.UseVisualStyleBackColor = false;
            this.iBtnEditar.Click += new System.EventHandler(this.iBtnEditar_Click);
            // 
            // iBtnEliminar
            // 
            this.iBtnEliminar.BackColor = System.Drawing.Color.Red;
            this.iBtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iBtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iBtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnEliminar.ForeColor = System.Drawing.Color.White;
            this.iBtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Equals;
            this.iBtnEliminar.IconColor = System.Drawing.Color.White;
            this.iBtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnEliminar.IconSize = 32;
            this.iBtnEliminar.Location = new System.Drawing.Point(30, 395);
            this.iBtnEliminar.Name = "iBtnEliminar";
            this.iBtnEliminar.Size = new System.Drawing.Size(152, 36);
            this.iBtnEliminar.TabIndex = 63;
            this.iBtnEliminar.Text = "Eliminar";
            this.iBtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iBtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnEliminar.UseVisualStyleBackColor = false;
            this.iBtnEliminar.Click += new System.EventHandler(this.iBtnEliminar_Click);
            // 
            // iBtnGuardar
            // 
            this.iBtnGuardar.BackColor = System.Drawing.Color.DarkGreen;
            this.iBtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iBtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iBtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnGuardar.ForeColor = System.Drawing.Color.White;
            this.iBtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Spa;
            this.iBtnGuardar.IconColor = System.Drawing.Color.White;
            this.iBtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnGuardar.IconSize = 32;
            this.iBtnGuardar.Location = new System.Drawing.Point(30, 310);
            this.iBtnGuardar.Name = "iBtnGuardar";
            this.iBtnGuardar.Size = new System.Drawing.Size(152, 36);
            this.iBtnGuardar.TabIndex = 62;
            this.iBtnGuardar.Text = "Guardar";
            this.iBtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iBtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnGuardar.UseVisualStyleBackColor = false;
            this.iBtnGuardar.Click += new System.EventHandler(this.iBtnGuardar_Click);
            // 
            // txtParametroProveedor
            // 
            this.txtParametroProveedor.Location = new System.Drawing.Point(410, 43);
            this.txtParametroProveedor.Name = "txtParametroProveedor";
            this.txtParametroProveedor.Size = new System.Drawing.Size(302, 20);
            this.txtParametroProveedor.TabIndex = 2;
            this.txtParametroProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametroProveedor_KeyPress);
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(923, 532);
            this.Controls.Add(this.txtParametroProveedor);
            this.Controls.Add(this.iBtnNuevo);
            this.Controls.Add(this.iBtnLimpiar);
            this.Controls.Add(this.ibtnCerrar);
            this.Controls.Add(this.iBtnBuscar);
            this.Controls.Add(this.iBtnEditar);
            this.Controls.Add(this.iBtnEliminar);
            this.Controls.Add(this.iBtnGuardar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.label1);
            this.Name = "FrmProveedor";
            this.Text = "::: Licoreria - Proveedor :::";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpRazonSocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDocumento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iBtnNuevo;
        private FontAwesome.Sharp.IconButton iBtnLimpiar;
        private FontAwesome.Sharp.IconButton ibtnCerrar;
        private FontAwesome.Sharp.IconButton iBtnBuscar;
        private FontAwesome.Sharp.IconButton iBtnEditar;
        private FontAwesome.Sharp.IconButton iBtnEliminar;
        private FontAwesome.Sharp.IconButton iBtnGuardar;
        private System.Windows.Forms.ErrorProvider erpTelefono;
        private System.Windows.Forms.ErrorProvider erpCorreo;
        private System.Windows.Forms.ErrorProvider erpRazonSocial;
        private System.Windows.Forms.ErrorProvider erpDocumento;
        private System.Windows.Forms.TextBox txtParametroProveedor;
    }
}

