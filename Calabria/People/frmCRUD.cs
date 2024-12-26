using Calabria.Base.Forms;
using Calabria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Calabria.People
{
	public partial class frmCRUD : CRUDForm
	{
		private int ItemId { get; set; }
		private frmList MyOwner { get { return (frmList)Owner; } }
		private Person _person;
		private int _itemOffset;

		private List<IList<object>> GetItemData(bool delete = false)
		{
			var item = new Person
			{
				AssociateDate = dtpAssociateDate.Value,
				Birthday = dtpBirthday.Value,
				Discount = Helpers.StringExtensions.ParseNullableInt(txtDiscount.Text.Trim()),
				Email = txtEmail.Text,
				Gender = cmbGender.SelectedText,
				Id = ItemId,
				IsExcempt = chkExempt.Checked,
				IsMember = chkMember.Checked,
				IsWorkshopper = chkWorkshopper.Checked,
				Names = txtNames.Text.Trim(),
				Surnames = txtSurnames.Text.Trim(),
				EmergencyContact = txtEmergenciContact.Text.Trim(),
				Phone = txtPhoneNumber.Text.Trim()
			};

			return new List<IList<object>>
				{
					new List<object>
					{
						delete,
						delete?DateTime.Now:DateTime.MinValue,
						item.Id,
						item.Names,
						item.Surnames,
						item.Email,
						item.Phone,
						item.EmergencyContact,
						item.Birthday,
						item.IsMember,
						item.IsExcempt,
						item.Discount,
						item.Gender,
						item.DischargeDate,
						item.IsWorkshopper
					}
				};
		}

		public frmCRUD(CRUDStateEnum stateEnum, int itemOffset, Person person) : base(stateEnum)
		{
			InitializeComponent();

			_person = person;
			_itemOffset = itemOffset;
		}

		private void frmCRUD_Load(object sender, EventArgs e)
		{
			switch (CRUDState)
			{
				case CRUDStateEnum.Create:
					ItemId = _itemOffset + 1;
					btnUpdate.Enabled = false;
					break;
				case CRUDStateEnum.Update:
					ItemId = (int)_person.Id;
					btnSave.Enabled = false;
					break;
			}

			SetUpdateIndex();
			
			if (_person != null)
			{
				txtNames.Text = _person.Names;
				txtSurnames.Text = _person.Surnames;
				dtpBirthday.Value = (DateTime)_person.Birthday;
				txtEmail.Text = _person.Email;
				txtPhoneNumber.Text = _person.Phone;
				txtEmergenciContact.Text = _person.EmergencyContact;
				chkWorkshopper.Checked = _person.IsWorkshopper;
				chkMember.Checked = _person.IsMember;
				chkExempt.Checked = _person.IsExcempt;
				txtDiscount.Text = Convert.ToString(_person.Discount);
				cmbGender.Text = _person.Gender;
				dtpAssociateDate.Value = (DateTime)_person.AssociateDate;
			}
		}

		private void SetUpdateIndex()
		{
			var itemOffset = MyOwner.sheetConnector.SpreadSheetRange.InitialFirstIndexOffset + _itemOffset;

			MyOwner.sheetConnector.SpreadSheetRange.FirstIndexOffset = itemOffset;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			MyOwner.sheetConnector.SpreadSheetRange.FirstIndexOffset = int.MinValue;
			MyOwner.sheetConnector.AppendData(GetItemData());

			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			MyOwner.sheetConnector.UpdateData(GetItemData());

			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			MyOwner.sheetConnector.DeleteData(GetItemData(true));

			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
