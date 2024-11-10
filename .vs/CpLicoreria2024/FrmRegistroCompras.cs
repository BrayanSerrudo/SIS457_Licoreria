using CadLicoreria2024;
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
			using (var context = new Labsis457licoreriaEntities2())
			{
				var resultados = context.Database.SqlQuery<RegistroCompraDTO>("EXEC ObtenerDetallesCompras").ToList();
				dgvRegistro.DataSource = resultados;
			}
		}

	
	}
}
