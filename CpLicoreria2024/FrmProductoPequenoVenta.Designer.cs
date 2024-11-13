namespace CpLicoreria2024
{
	partial class FrmProductoPequenoVenta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductoPequenoVenta));
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			this.iBtnBuscar = new FontAwesome.Sharp.IconButton();
			this.txtParametropequeño = new System.Windows.Forms.TextBox();
			this.lblBusqueda = new System.Windows.Forms.Label();
			this.lblSubtitulo = new System.Windows.Forms.Label();
			this.dgvLista = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
			this.SuspendLayout();
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
			this.iconButton1.Location = new System.Drawing.Point(557, 40);
			this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.iconButton1.Name = "iconButton1";
			this.iconButton1.Size = new System.Drawing.Size(54, 48);
			this.iconButton1.TabIndex = 88;
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
			this.iBtnBuscar.Location = new System.Drawing.Point(494, 40);
			this.iBtnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.iBtnBuscar.Name = "iBtnBuscar";
			this.iBtnBuscar.Size = new System.Drawing.Size(54, 48);
			this.iBtnBuscar.TabIndex = 87;
			this.iBtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iBtnBuscar.UseVisualStyleBackColor = false;
			this.iBtnBuscar.Click += new System.EventHandler(this.iBtnBuscar_Click);
			// 
			// txtParametropequeño
			// 
			this.txtParametropequeño.Location = new System.Drawing.Point(194, 62);
			this.txtParametropequeño.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtParametropequeño.Name = "txtParametropequeño";
			this.txtParametropequeño.Size = new System.Drawing.Size(278, 26);
			this.txtParametropequeño.TabIndex = 85;
			this.txtParametropequeño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametropequeño_KeyPress);
			// 
			// lblBusqueda
			// 
			this.lblBusqueda.AutoSize = true;
			this.lblBusqueda.BackColor = System.Drawing.Color.White;
			this.lblBusqueda.Location = new System.Drawing.Point(36, 68);
			this.lblBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBusqueda.Name = "lblBusqueda";
			this.lblBusqueda.Size = new System.Drawing.Size(150, 20);
			this.lblBusqueda.TabIndex = 84;
			this.lblBusqueda.Text = "Buscar por Nombre:";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.BackColor = System.Drawing.Color.White;
			this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.Location = new System.Drawing.Point(14, 12);
			this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(672, 131);
			this.lblSubtitulo.TabIndex = 83;
			this.lblSubtitulo.Text = "Lista de Productos:";
			// 
			// dgvLista
			// 
			this.dgvLista.AllowUserToAddRows = false;
			this.dgvLista.AllowUserToDeleteRows = false;
			this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLista.Location = new System.Drawing.Point(14, 155);
			this.dgvLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvLista.Name = "dgvLista";
			this.dgvLista.ReadOnly = true;
			this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLista.Size = new System.Drawing.Size(672, 491);
			this.dgvLista.TabIndex = 82;
			this.dgvLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellDoubleClick);
			// 
			// FrmProductoPequenoVenta
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.ClientSize = new System.Drawing.Size(701, 658);
			this.Controls.Add(this.iconButton1);
			this.Controls.Add(this.iBtnBuscar);
			this.Controls.Add(this.txtParametropequeño);
			this.Controls.Add(this.lblBusqueda);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.dgvLista);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FrmProductoPequenoVenta";
			this.Text = ":: Licoreria - ProductoPequenoVenta :::";
			this.Load += new System.EventHandler(this.FrmProductoPequenoVenta_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private FontAwesome.Sharp.IconButton iconButton1;
		private FontAwesome.Sharp.IconButton iBtnBuscar;
		private System.Windows.Forms.TextBox txtParametropequeño;
		private System.Windows.Forms.Label lblBusqueda;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.DataGridView dgvLista;
	}
}