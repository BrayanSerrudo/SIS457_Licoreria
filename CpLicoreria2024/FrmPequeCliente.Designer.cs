namespace CpLicoreria2024
{
	partial class FrmPequeCliente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPequeCliente));
			this.cbxBusqueda = new System.Windows.Forms.ComboBox();
			this.txtParametropequeño = new System.Windows.Forms.TextBox();
			this.lblBusqueda = new System.Windows.Forms.Label();
			this.lblSubtitulo = new System.Windows.Forms.Label();
			this.dgvLista = new System.Windows.Forms.DataGridView();
			this.ibtnclear = new FontAwesome.Sharp.IconButton();
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
			this.cbxBusqueda.Location = new System.Drawing.Point(94, 41);
			this.cbxBusqueda.Name = "cbxBusqueda";
			this.cbxBusqueda.Size = new System.Drawing.Size(94, 21);
			this.cbxBusqueda.TabIndex = 86;
			// 
			// txtParametropequeño
			// 
			this.txtParametropequeño.Location = new System.Drawing.Point(195, 41);
			this.txtParametropequeño.Name = "txtParametropequeño";
			this.txtParametropequeño.Size = new System.Drawing.Size(187, 20);
			this.txtParametropequeño.TabIndex = 85;
			this.txtParametropequeño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametropequeño_KeyPress);
			// 
			// lblBusqueda
			// 
			this.lblBusqueda.AutoSize = true;
			this.lblBusqueda.BackColor = System.Drawing.Color.White;
			this.lblBusqueda.Location = new System.Drawing.Point(24, 44);
			this.lblBusqueda.Name = "lblBusqueda";
			this.lblBusqueda.Size = new System.Drawing.Size(64, 13);
			this.lblBusqueda.TabIndex = 84;
			this.lblBusqueda.Text = "Buscar por :";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.BackColor = System.Drawing.Color.White;
			this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.Location = new System.Drawing.Point(9, 8);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(488, 85);
			this.lblSubtitulo.TabIndex = 83;
			this.lblSubtitulo.Text = "Lista de Clientes:";
			// 
			// dgvLista
			// 
			this.dgvLista.AllowUserToAddRows = false;
			this.dgvLista.AllowUserToDeleteRows = false;
			this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLista.Location = new System.Drawing.Point(9, 101);
			this.dgvLista.Name = "dgvLista";
			this.dgvLista.ReadOnly = true;
			this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLista.Size = new System.Drawing.Size(488, 319);
			this.dgvLista.TabIndex = 82;
			this.dgvLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellDoubleClick);
			// 
			// ibtnclear
			// 
			this.ibtnclear.BackColor = System.Drawing.Color.LightSeaGreen;
			this.ibtnclear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ibtnclear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.ibtnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ibtnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ibtnclear.ForeColor = System.Drawing.Color.White;
			this.ibtnclear.IconChar = FontAwesome.Sharp.IconChar.City;
			this.ibtnclear.IconColor = System.Drawing.Color.Black;
			this.ibtnclear.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.ibtnclear.IconSize = 28;
			this.ibtnclear.Location = new System.Drawing.Point(442, 33);
			this.ibtnclear.Name = "ibtnclear";
			this.ibtnclear.Size = new System.Drawing.Size(36, 31);
			this.ibtnclear.TabIndex = 88;
			this.ibtnclear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ibtnclear.UseVisualStyleBackColor = false;
			this.ibtnclear.Click += new System.EventHandler(this.ibtnclear_Click);
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
			this.iBtnBuscar.Location = new System.Drawing.Point(400, 33);
			this.iBtnBuscar.Name = "iBtnBuscar";
			this.iBtnBuscar.Size = new System.Drawing.Size(36, 31);
			this.iBtnBuscar.TabIndex = 87;
			this.iBtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iBtnBuscar.UseVisualStyleBackColor = false;
			this.iBtnBuscar.Click += new System.EventHandler(this.iBtnBuscar_Click);
			// 
			// FrmPequeCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(507, 428);
			this.Controls.Add(this.ibtnclear);
			this.Controls.Add(this.iBtnBuscar);
			this.Controls.Add(this.cbxBusqueda);
			this.Controls.Add(this.txtParametropequeño);
			this.Controls.Add(this.lblBusqueda);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.dgvLista);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmPequeCliente";
			this.Text = "::: icoreria - PequeCliente :::";
			this.Load += new System.EventHandler(this.FrmPequeCliente_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private FontAwesome.Sharp.IconButton ibtnclear;
		private FontAwesome.Sharp.IconButton iBtnBuscar;
		private System.Windows.Forms.ComboBox cbxBusqueda;
		private System.Windows.Forms.TextBox txtParametropequeño;
		private System.Windows.Forms.Label lblBusqueda;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.DataGridView dgvLista;
	}
}