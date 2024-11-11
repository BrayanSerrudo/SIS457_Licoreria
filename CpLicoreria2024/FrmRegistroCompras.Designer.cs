namespace CpLicoreria2024
{
	partial class FrmRegistroCompras
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.lblContenedor = new System.Windows.Forms.Label();
			this.dgvRegistro = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(825, 83);
			this.label1.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(194, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "Registro De Compras:";
			// 
			// btnBuscar
			// 
			this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.Image = global::CpLicoreria2024.Properties.Resources.buscar;
			this.btnBuscar.Location = new System.Drawing.Point(505, 25);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(88, 41);
			this.btnBuscar.TabIndex = 127;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// lblContenedor
			// 
			this.lblContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblContenedor.BackColor = System.Drawing.Color.White;
			this.lblContenedor.Location = new System.Drawing.Point(0, 101);
			this.lblContenedor.Name = "lblContenedor";
			this.lblContenedor.Size = new System.Drawing.Size(825, 355);
			this.lblContenedor.TabIndex = 128;
			// 
			// dgvRegistro
			// 
			this.dgvRegistro.AllowUserToAddRows = false;
			this.dgvRegistro.AllowUserToDeleteRows = false;
			this.dgvRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRegistro.Location = new System.Drawing.Point(12, 162);
			this.dgvRegistro.Name = "dgvRegistro";
			this.dgvRegistro.ReadOnly = true;
			this.dgvRegistro.Size = new System.Drawing.Size(801, 276);
			this.dgvRegistro.TabIndex = 129;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Image = global::CpLicoreria2024.Properties.Resources.buscar;
			this.button1.Location = new System.Drawing.Point(725, 115);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 41);
			this.button1.TabIndex = 130;
			this.button1.Text = "Buscar";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(148, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(351, 24);
			this.label3.TabIndex = 131;
			this.label3.Text = "Buscar Todos Los Registro De Compras:";
			// 
			// FrmRegistroCompras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(825, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dgvRegistro);
			this.Controls.Add(this.lblContenedor);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmRegistroCompras";
			this.Text = "FrmRegistroCompras";
			((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label lblContenedor;
		private System.Windows.Forms.DataGridView dgvRegistro;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
	}
}