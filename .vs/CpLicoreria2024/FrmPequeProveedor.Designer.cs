namespace CpLicoreria2024
{
    partial class FrmPequeProveedor
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
            this.cbxBusqueda = new System.Windows.Forms.ComboBox();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iBtnBuscar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxBusqueda
            // 
            this.cbxBusqueda.FormattingEnabled = true;
            this.cbxBusqueda.Items.AddRange(new object[] {
            "N° Documento",
            "Razon Social",
            "Correo",
            "Teléfono"});
            this.cbxBusqueda.Location = new System.Drawing.Point(94, 37);
            this.cbxBusqueda.Name = "cbxBusqueda";
            this.cbxBusqueda.Size = new System.Drawing.Size(94, 21);
            this.cbxBusqueda.TabIndex = 72;
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(195, 37);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(187, 20);
            this.txtParametro.TabIndex = 71;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.BackColor = System.Drawing.Color.White;
            this.lblBusqueda.Location = new System.Drawing.Point(24, 40);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(64, 13);
            this.lblBusqueda.TabIndex = 70;
            this.lblBusqueda.Text = "Buscar por :";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.BackColor = System.Drawing.Color.White;
            this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(9, 4);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(488, 85);
            this.lblSubtitulo.TabIndex = 69;
            this.lblSubtitulo.Text = "Lista de Proveedores:";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(9, 97);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(488, 319);
            this.dgvLista.TabIndex = 68;
            this.dgvLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellDoubleClick);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.City;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 28;
            this.iconButton1.Location = new System.Drawing.Point(442, 29);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(36, 31);
            this.iconButton1.TabIndex = 74;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.iBtnBuscar.IconSize = 28;
            this.iBtnBuscar.Location = new System.Drawing.Point(400, 29);
            this.iBtnBuscar.Name = "iBtnBuscar";
            this.iBtnBuscar.Size = new System.Drawing.Size(36, 31);
            this.iBtnBuscar.TabIndex = 73;
            this.iBtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnBuscar.UseVisualStyleBackColor = false;
            this.iBtnBuscar.Click += new System.EventHandler(this.iBtnBuscar_Click);
            // 
            // FrmPequeProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(513, 432);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.iBtnBuscar);
            this.Controls.Add(this.cbxBusqueda);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.dgvLista);
            this.Name = "FrmPequeProveedor";
            this.Text = "::: Licoreria - Proveedores :::";
            this.Load += new System.EventHandler(this.FrmPequeProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton iBtnBuscar;
        private System.Windows.Forms.ComboBox cbxBusqueda;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.DataGridView dgvLista;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}