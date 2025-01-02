using Calabria.Base.Forms;
using System;

namespace Calabria
{
	public partial class frmMain : BaseForm
	{
		private Stock.frmMain _frmStockMain;
		private People.frmList _People;
		private Workshop.frmList _Workshop;

		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{

		}

		private void Button1_Click(object sender, EventArgs e)
		{
			_frmStockMain = new Stock.frmMain();
			_frmStockMain.ShowDialog();
		}		

		private void btnPeople_Click(object sender, EventArgs e)
		{
			_People = new People.frmList();
			_People.ShowDialog();
		}

		private void btn_Workshops_Click(object sender, EventArgs e)
		{
			_Workshop = new Workshop.frmList();
			_Workshop.ShowDialog();
		}
	}
}