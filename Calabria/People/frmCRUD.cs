﻿using Calabria.Base.Forms;
using Calabria.Models;
using Calabria.Services.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calabria.People
{
	public partial class frmCRUD : CRUDForm
	{
		private int ItemId { get; set; }
		private readonly Person _person;
		private readonly PersonDataService _dataService;

		private List<IList<object>> GetItemData(bool delete = false)
		{
			var item = new Person
			{
				AssociateDate = dtpAssociateDate.Value,
				Birthday = dtpBirthday.Value,
				Email = txtEmail.Text,
				Gender = cmbGender.Text,
				Id = ItemId,
				IsExcempt = chkExempt.Checked,
				IsMember = chkMember.Checked,
				IsWorkshopper = chkWorkshopper.Checked,
				Names = txtNames.Text.Trim(),
				Surnames = txtSurnames.Text.Trim(),
				EmergencyContact = txtEmergenciContact.Text.Trim(),
				Phone = txtPhoneNumber.Text.Trim(),
				BankTransferRef = txtBankTransferRef.Text.Trim(),
			};

			var list = new List<IList<object>>
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
						item.Gender,
						item.DischargeDate,
						item.AssociateDate,
						item.IsWorkshopper,
						item.BankTransferRef,
					}
				};

			return list;
		}

		public frmCRUD(CRUDStateEnum stateEnum, Person person, PersonDataService dataService) : base(stateEnum)
		{
			InitializeComponent();

			_dataService = dataService;
			_person = person;
			if (person !=null) ItemId = _person.Id;
		}

		private void frmCRUD_Load(object sender, EventArgs e)
		{
			switch (CRUDState)
			{
				case CRUDStateEnum.Create:
					btnUpdate.Text = "Agregar";
					break;
				case CRUDStateEnum.Update:
					btnUpdate.Text = "Modificar";
					btnDelete.Enabled = true;
					break;
			}

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
				cmbGender.Text = _person.Gender;
				dtpAssociateDate.Value = (DateTime)_person.AssociateDate;
				txtBankTransferRef.Text = _person.BankTransferRef;
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			switch (CRUDState)
			{
				case CRUDStateEnum.Create:
					_dataService.AppendData(GetItemData());
					break;
				case CRUDStateEnum.Update:
					_dataService.UpdateData(GetItemData());
					break;
				default:
					break;
			}

			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			_dataService.DeleteData(GetItemData(true));

			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
