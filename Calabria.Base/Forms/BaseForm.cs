using System.Windows.Forms;

namespace Calabria.Base.Forms
{
	public partial class BaseForm : Form
	{
		public BaseForm()
		{
			InitializeComponent();

			StartPosition = FormStartPosition.CenterScreen;

			if (Parent != null)
			{
				StartPosition=FormStartPosition.CenterParent;
			}
		}
	}
}
