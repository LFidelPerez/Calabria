using Calabria.Helpers;
using Calabria.Models;
using Calabria.Services.Google;
using System.Collections.Generic;

namespace Calabria.Services.Models
{
	public class PersonDataService
	{
		public List<Person> DataList { get { return _dataList; } }
		public int InitialFirstIndexOffset
		{
			get { return sheetConnector.SpreadSheetRange.InitialFirstIndexOffset; }
		}
		public int MaxItemId { get { return _maxItemId; } }
		public readonly SpreadSheetConnector sheetConnector;
		private List<Person> _dataList = new List<Person>();
		private int _maxItemId;
		private int MaxItemId_Ok;

		public PersonDataService()
		{
			_maxItemId = 1;
			MaxItemId_Ok = 1;
			sheetConnector = new SpreadSheetConnector(
				sheetName: "Miembros",
				firstColumn: "A",
				lastColumn: "P",
				firstIndexOffset: 2
			);
			sheetConnector.ConnectToGoogle();

			sheetConnector.SpreadSheetRange.Init();
		}

		public void SetUpdateIndex(int offset)
		{
			/*
			var itemOffset = offset + sheetConnector.SpreadSheetRange.InitialFirstIndexOffset;

			sheetConnector.SpreadSheetRange.FirstIndexOffset = itemOffset;
			*/
		}

		public string AppendData(List<IList<object>> data)
		{
			data[0][2] = MaxItemId_Ok + 1;

			return sheetConnector.AppendData(data);
		}

		public string UpdateData(List<IList<object>> data)
		{
			return sheetConnector.UpdateData(data);
		}

		public void DeleteData(List<IList<object>> data)
		{
			sheetConnector.DeleteData(data);
		}

		public List<Person> GetDataListItems()
		{
			_dataList.Clear();

			var rangeValues = sheetConnector.GetData();

			// Do nothing if range has no values
			if (rangeValues.Values == null)
			{
				return null;
			}

			for (int i = 0; rangeValues.Values.Count > i; i++)
			{
				var item = rangeValues.Values[i];

				_dataList.Add(new Person()
				{
					IsDeleted = ObjectTypeCast.ToBool(item[0]),
					Id = ObjectTypeCast.ToInt(item[2]),
					Names = item[3].ToString(),
					Surnames = item[4].ToString(),
					Email = item[5].ToString(),
					Phone = item[6].ToString(),
					EmergencyContact = item[7].ToString(),
					Birthday = ObjectTypeCast.ToDateTime(item[8]),
					IsMember = ObjectTypeCast.ToBool(item[9]),
					IsExcempt = ObjectTypeCast.ToBool(item[10]),
					Gender = item[11].ToString(),
					DischargeDate = ObjectTypeCast.ToDateTime(item[12]),
					AssociateDate = ObjectTypeCast.ToDateTime(item[13]),
					IsWorkshopper = ObjectTypeCast.ToBool(item[14])
				});

				_maxItemId = _dataList[i].Id;
				MaxItemId_Ok = _dataList[i].Id;
			}

			return _dataList;
		}

		public int? FindRowIndexById(int id)
		{
			return sheetConnector.FindRowIndexById(id);
		}

		public Person FindItemInList(int id)
		{
			foreach (var item in _dataList)
			{
				if (item.Id == id)
				{
					return item;
				}
			}

			return null;
		}
	}
}