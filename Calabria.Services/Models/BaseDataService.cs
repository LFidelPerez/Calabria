using Calabria.Models;
using Calabria.Services.Google;
using Google.Apis.Sheets.v4.Data;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Calabria.Services.Models
{
	public abstract class BaseDataService<T> where T : Base.IModel
	{
		public List<T> DataList { get { return _dataList; } }
		public readonly SpreadSheetConnector sheetConnector;
		internal int _maxItemId;
		private List<T> _dataList = new List<T>();
		

		public BaseDataService(string sheetName, string firstColumn, string lastColumn, int firstIndexOffset)
		{
			_maxItemId = 1;
			sheetConnector = new SpreadSheetConnector(
				sheetName: sheetName,
				firstColumn: firstColumn,
				lastColumn: lastColumn,
				firstIndexOffset: firstIndexOffset
			);
			sheetConnector.ConnectToGoogle();
			sheetConnector.SpreadSheetRange.Init();
		}

		internal void SetDataList(List<T> list)
		{
			_dataList = list;
		}

		public ValueRange GetDataItems()
		{
			_dataList.Clear();

			var rangeValues = sheetConnector.GetData();

			return rangeValues;
		}

		public abstract List<T> GetDataListItems();

		public string AppendData(List<IList<object>> data)
		{
			data[0][2] = _maxItemId + 1;

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

		public int? FindRowIndexById(int id)
		{
			return sheetConnector.FindRowIndexById(id);
		}

		public T FindItemInList(int id)
		{
			foreach (var item in DataList)
			{
				if (item.Id == id)
				{
					return item;
				}
			}

			return default(T);
		}
	}
}