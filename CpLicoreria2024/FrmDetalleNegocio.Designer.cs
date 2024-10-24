namespace CpLicoreria2024
{
    partial class FrmDetalleNegocio
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
			this.gbxDetalleNegocio = new System.Windows.Forms.GroupBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.txtNit = new System.Windows.Forms.TextBox();
			this.btnGuardar = new FontAwesome.Sharp.IconButton();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.lblNit = new System.Windows.Forms.Label();
			this.lblNombreNegocio = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.ibtnCargarImagen = new FontAwesome.Sharp.IconButton();
			this.label2 = new System.Windows.Forms.Label();
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.gbxDetalleNegocio.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(-2, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(542, 350);
			this.label1.TabIndex = 0;
			// 
			// gbxDetalleNegocio
			// 
			this.gbxDetalleNegocio.Controls.Add(this.txtDireccion);
			this.gbxDetalleNegocio.Controls.Add(this.txtNit);
			this.gbxDetalleNegocio.Controls.Add(this.btnGuardar);
			this.gbxDetalleNegocio.Controls.Add(this.lblDireccion);
			this.gbxDetalleNegocio.Controls.Add(this.lblNit);
			this.gbxDetalleNegocio.Controls.Add(this.lblNombreNegocio);
			this.gbxDetalleNegocio.Controls.Add(this.txtNombre);
			this.gbxDetalleNegocio.Controls.Add(this.ibtnCargarImagen);
			this.gbxDetalleNegocio.Controls.Add(this.label2);
			this.gbxDetalleNegocio.Controls.Add(this.picLogo);
			this.gbxDetalleNegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxDetalleNegocio.Location = new System.Drawing.Point(12, 12);
			this.gbxDetalleNegocio.Name = "gbxDetalleNegocio";
			this.gbxDetalleNegocio.Size = new System.Drawing.Size(514, 325);
			this.gbxDetalleNegocio.TabIndex = 1;
			this.gbxDetalleNegocio.TabStop = false;
			this.gbxDetalleNegocio.Text = "Detalle del Negocio";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(218, 187);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(238, 26);
			this.txtDireccion.TabIndex = 30;
			// 
			// txtNit
			// 
			this.txtNit.Location = new System.Drawing.Point(218, 122);
			this.txtNit.Name = "txtNit";
			this.txtNit.Size = new System.Drawing.Size(238, 26);
			this.txtNit.TabIndex = 29;
			// 
			// btnGuardar
			// 
			this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Share;
			this.btnGuardar.IconColor = System.Drawing.Color.Black;
			this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnGuardar.IconSize = 28;
			this.btnGuardar.Location = new System.Drawing.Point(235, 219);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(185, 33);
			this.btnGuardar.TabIndex = 28;
			this.btnGuardar.Text = "Guardar Cambios";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGuardar.UseVisualStyleBackColor = true;
			// 
			// lblDireccion
			// 
			this.lblDireccion.AutoSize = true;
			this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDireccion.Location = new System.Drawing.Point(215, 163);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblDireccion.Size = new System.Drawing.Size(75, 18);
			this.lblDireccion.TabIndex = 26;
			this.lblDireccion.Text = "Dirección:";
			// 
			// lblNit
			// 
			this.lblNit.AutoSize = true;
			this.lblNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNit.Location = new System.Drawing.Point(215, 101);
			this.lblNit.Name = "lblNit";
			this.lblNit.Size = new System.Drawing.Size(30, 18);
			this.lblNit.TabIndex = 24;
			this.lblNit.Text = "Nit:";
			// 
			// lblNombreNegocio
			// 
			this.lblNombreNegocio.AutoSize = true;
			this.lblNombreNegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreNegocio.Location = new System.Drawing.Point(215, 44);
			this.lblNombreNegocio.Name = "lblNombreNegocio";
			this.lblNombreNegocio.Size = new System.Drawing.Size(146, 18);
			this.lblNombreNegocio.TabIndex = 22;
			this.lblNombreNegocio.Text = "Nombre de Negocio:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(218, 65);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(238, 26);
			this.txtNombre.TabIndex = 23;
			// 
			// ibtnCargarImagen
			// 
			this.ibtnCargarImagen.IconChar = FontAwesome.Sharp.IconChar.Upload;
			this.ibtnCargarImagen.IconColor = System.Drawing.Color.Black;
			this.ibtnCargarImagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.ibtnCargarImagen.IconSize = 28;
			this.ibtnCargarImagen.Location = new System.Drawing.Point(36, 208);
			this.ibtnCargarImagen.Name = "ibtnCargarImagen";
			this.ibtnCargarImagen.Size = new System.Drawing.Size(124, 33);
			this.ibtnCargarImagen.TabIndex = 21;
			this.ibtnCargarImagen.Text = "Subir";
			this.ibtnCargarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ibtnCargarImagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ibtnCargarImagen.UseVisualStyleBackColor = true;
			this.ibtnCargarImagen.Click += new System.EventHandler(this.ibtnCargarImagen_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(21, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 18);
			this.label2.TabIndex = 20;
			this.label2.Text = "Logo";
			// 
			// picLogo
			// 
			this.picLogo.Location = new System.Drawing.Point(24, 70);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(146, 132);
			this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLogo.TabIndex = 18;
			this.picLogo.TabStop = false;
			// 
			// FrmDetalleNegocio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(552, 360);
			this.Controls.Add(this.gbxDetalleNegocio);
			this.Controls.Add(this.label1);
			this.Name = "FrmDetalleNegocio";
			this.Text = "FrmDetalleNegocio";
			this.gbxDetalleNegocio.ResumeLayout(false);
			this.gbxDetalleNegocio.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxDetalleNegocio;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNit;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.Label lblNombreNegocio;
        private System.Windows.Forms.TextBox txtNombre;
        private FontAwesome.Sharp.IconButton ibtnCargarImagen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picLogo;
    }
}