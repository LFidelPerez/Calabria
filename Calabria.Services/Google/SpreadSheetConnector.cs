using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Calabria.Services.Google
{
	public class SpreadSheetConnector
	{

		private string[] _scopes = { SheetsService.Scope.Spreadsheets }; // Change this if you're accessing Drive or Docs
		private string _applicationName = "My Application Name from Google API Project ";
		private string _spreadsheetId = "1UaUcWbk_aMYG05KZJdu3ZiztWiNfxfZ6hh14skKKF7k";
		private SheetsService _sheetsService;

		public SpreadSheetConnector() { }
		public SpreadSheetConnector(string applicationName, string spreadsheetId, SheetsService sheetsService)
		{
			_applicationName = applicationName;
			_spreadsheetId = spreadsheetId;
			_sheetsService = sheetsService;
		}

		public void ConnectToGoogle()
		{
			GoogleCredential credential;

			var _exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase).Replace(@"file:\", "");

			// Put your credentials json file in the root of the solution and make sure copy to output dir property is set to always copy 
			using (var stream = new FileStream(Path.Combine(_exePath, "blazor3.json"),
				FileMode.Open, FileAccess.Read))
			{
				credential = GoogleCredential.FromStream(stream).CreateScoped(_scopes);
			}

			// Create Google Sheets API service.
			_sheetsService = new SheetsService(new BaseClientService.Initializer()
			{
				HttpClientInitializer = credential,
				ApplicationName = _applicationName
			});
		}

		public int? FindRowIndexById(ValueRange data, int id) {
			for (int i = 0; data.Values.Count > i; i++)
			{
				var item = data.Values[i];
				var itemId = int.Parse((string)item[0]);

				if (itemId == id) return i;
			}

			return null;
		}

		public ValueRange GetData(string range) {
			var requestList = _sheetsService.Spreadsheets.Values.Get(_spreadsheetId, range);

			return requestList.Execute();
		}

		public string AppendData(string range, List<IList<object>> data)
		{
			var dataValueRange = new ValueRange
			{
				Range = range,
				Values = data
			};

			var request = _sheetsService.Spreadsheets.Values.Append(dataValueRange, _spreadsheetId, range);
			request.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.RAW;

			AppendValuesResponse response = request.Execute();

			return JsonConvert.SerializeObject(response);
		}

		// Pass in your data as a list of a list (2-D lists are equivalent to the 2-D spreadsheet structure)
		public string UpdateData(string range, List<IList<object>> data)
		{
			//string _range = "Data-Ingreso!A1:Y";
			string valueInputOption = "RAW";
			
			// The new values to apply to the spreadsheet.
			List<ValueRange> updateData = new List<ValueRange>();
			var dataValueRange = new ValueRange
			{
				Range = range,
				Values = data
			};
			updateData.Add(dataValueRange);

			BatchUpdateValuesRequest requestBody = new BatchUpdateValuesRequest
			{
				ValueInputOption = valueInputOption,
				Data = updateData
			};

			var request = _sheetsService.Spreadsheets.Values.BatchUpdate(requestBody, _spreadsheetId);

			BatchUpdateValuesResponse response = request.Execute();

			return JsonConvert.SerializeObject(response);
		}

		public void DeleteData(string range, List<IList<object>> data)
		{
			UpdateData(range, data);
		}
	}
}
