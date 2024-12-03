using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calabria
{
	public partial class frmMain : Form
	{
		private readonly SpreadSheetConnector sheetConnector;
		private frmStock _frmStock;

		public frmMain()
		{
			InitializeComponent();
			sheetConnector = new SpreadSheetConnector();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			_frmStock = new frmStock();	
			_frmStock.ShowDialog();
		}

		public void AddTestData()
		{
			try
			{
				var range = "Data-Ingreso!A2:C";

				sheetConnector.ConnectToGoogle();

				var model = new Ingreso { Id = 1, Nombre = "Leo1", Cuota = 100 };
				var model2 = new Ingreso { Id = 2, Nombre = "Leo2", Cuota = 200 };
				var model3 = new Ingreso { Id = 3, Nombre = "Leo3", Cuota = 300 };

				var modelList = new List<IList<object>>
				{
					new List<object>
					{
						model.Id,
						model.Nombre,
						model.Cuota
					},new List<object>
					{
						model2.Id,
						model2.Nombre,
						model2.Cuota
					},new List<object>
					{
						model3.Id,
						model3.Nombre,
						model3.Cuota
					}
				};

				sheetConnector.UpdateData(range, modelList);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		private void frmMain_Load(object sender, EventArgs e)
		{

		}
	}

	public class Ingreso
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public int Cuota { get; set; }
	}
}