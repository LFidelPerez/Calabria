using System.Text;

namespace Calabria.Helpers.Google
{
	public class SpreadSheetRange
	{
		private readonly string _range = "{sheetName}!{rangeFirstColumn}{firstIndexOffset}:{rangeLastColumn}{lastIndexOffset}";
		private readonly string _sheetName;
		private readonly string _firstColumn;
		private readonly string _lastColumn;
		private readonly int _firstIndexOffset = int.MinValue;
		private readonly int _lastIndexOffset = int.MinValue;

		public string SheetName { get; set; }
		public string FirstColumn { get; set; }
		public string LastColumn { get; set; }
		public int FirstIndexOffset { get; set; }
		public int LastIndexOffset { get; set; }
		public int InitialFirstIndexOffset { get { return _firstIndexOffset; } }

		public SpreadSheetRange(string sheetName, string firstColumn, string lastColumn, int firstIndexOffset)
		{
			_sheetName = sheetName;
			_firstColumn = firstColumn;
			_lastColumn = lastColumn;
			_firstIndexOffset = firstIndexOffset;
		}

		public void Init()
		{
			SheetName = _sheetName;
			FirstColumn = _firstColumn;
			LastColumn = _lastColumn;
			FirstIndexOffset = _firstIndexOffset;
			LastIndexOffset = _lastIndexOffset;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder(_range);

			string firstIndexOffset = FirstIndexOffset.ToString();
			string lastIndexOffset = "";

			sb.Replace("{sheetName}", SheetName);
			sb.Replace("{rangeFirstColumn}", FirstColumn);
			sb.Replace("{firstIndexOffset}", firstIndexOffset);
			sb.Replace("{rangeLastColumn}", LastColumn);
			sb.Replace("{lastIndexOffset}", lastIndexOffset);

			return sb.ToString();
		}

		public string ToString(string firstIndexOffset)
		{
			StringBuilder sb = new StringBuilder(_range);

			string lastIndexOffset = "";

			sb.Replace("{sheetName}", SheetName);
			sb.Replace("{rangeFirstColumn}", FirstColumn);
			sb.Replace("{firstIndexOffset}", firstIndexOffset.ToString());
			sb.Replace("{rangeLastColumn}", LastColumn);
			sb.Replace("{lastIndexOffset}", lastIndexOffset);

			return sb.ToString();
		}
	}
}