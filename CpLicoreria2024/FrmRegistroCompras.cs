﻿using CadLicoreria2024;
using ClnLicoreria2024;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpLicoreria2024
{
	public partial class FrmRegistroCompras : Form
	{
		public FrmRegistroCompras()
		{
			InitializeComponent();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			// Obtener la fecha ingresada en el TextBox (asegúrate de que el formato sea correcto)
			string fechaInput = txtFecha.Text.Trim();  // txtFecha es el TextBox donde el usuario ingresa la fecha
			DateTime? fecha = null;

			// Intentamos convertir el texto a DateTime
			if (DateTime.TryParse(fechaInput, out DateTime fechaParsed))
			{
				fecha = fechaParsed;
			}

			// Usamos Entity Framework para obtener los registros filtrados por fecha
			using (var context = new Labsis457licoreriaEntities2())
			{
				// Si la fecha es válida, la pasamos al procedimiento almacenado; si no, dejamos el parámetro como NULL
				var query = "EXEC ObtenerDetallesCompras @Fecha = @Fecha";
				var parametros = new SqlParameter("@Fecha", fecha.HasValue ? (object)fecha.Value : DBNull.Value);

				// Ejecutamos la consulta y obtenemos los resultados
				var resultados = context.Database.SqlQuery<RegistroCompraDTO>(query, parametros).ToList();

				// Asignamos los resultados al DataGridView
				dgvRegistro.DataSource = resultados;
			}
		}

		private void FrmRegistroCompras_Load(object sender, EventArgs e)
		{
			dgvRegistro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
		
		}

	}
}
