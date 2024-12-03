using System.Windows.Forms;

namespace Calabria.Base.Forms
{
	public partial class CRUDForm : Form
	{
		public enum CRUDStateEnum
		{
			X, Create, Update, Delete
		}

		public CRUDStateEnum CRUDState { get; set; }

		public CRUDForm()
		{
			InitializeComponent();
		}

		public CRUDForm(CRUDStateEnum stateEnum)
		{
			InitializeComponent();

			CRUDState = stateEnum;
		}
	}
}