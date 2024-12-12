using System;
using System.Windows.Forms;

namespace Calabria.Base.Forms
{
	public partial class CRUDForm : BaseForm
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

			switch (CRUDState)
			{
				case CRUDStateEnum.Create:
				case CRUDStateEnum.Update:
				case CRUDStateEnum.Delete:
					break;
				default:
					throw new Exception("CRUD State invalid");
			}
		}
	}
}