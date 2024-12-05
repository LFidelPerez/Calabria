using System.Text;

namespace Calabria.Helpers.Google
{

	public enum SpreadSheetRangeEnum
	{
		Base,
		Indexed
	}

	public class SpreadSheetRange
	{
		private readonly string _range = "{sheetName}!{rangeFirstColumn}{firstIndexOffset}:{rangeLastColumn}{lastIndexOffset}";
		private readonly string _sheetName;
		private readonly string _firstColumn;
		private readonly string _lastColumn;
		private readonly int _firstIndexOffset = int.MinValue;
		private readonly int _lastIndexOffset = int.MinValue;

		public string SheetName { get; set; } = string.Empty;
		public string FirstColumn { get; set; } = string.Empty;
		public string LastColumn { get; set; } = string.Empty;
		public int FirstIndexOffset { get; set; } = int.MinValue;
		public int LastIndexOffset { get; set; } = int.MinValue;


		public SpreadSheetRange() { }

		public SpreadSheetRange(string range, string sheetName, string firstColumn, string lastColumn, int firstIndexOffset, int lastIndexOffset)
		{
			this._range = range;
			_sheetName = sheetName;
			_firstColumn = firstColumn;
			_lastColumn = lastColumn;
			_firstIndexOffset = firstIndexOffset;
			_lastIndexOffset = lastIndexOffset;
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

			sb.Replace("{sheetName}", SheetName);
			sb.Replace("{rangeFirstColumn}", FirstColumn);
			sb.Replace("{firstIndexOffset}", FirstIndexOffset.ToString());
			sb.Replace("{rangeLastColumn}", LastColumn);
			sb.Replace("{lastIndexOffset}", (LastIndexOffset != int.MinValue) ? LastIndexOffset.ToString() : string.Empty);

			return sb.ToString();
		}

		public string ToString(SpreadSheetRangeEnum rangeEnum)
		{
			if (rangeEnum == SpreadSheetRangeEnum.Base) return this.ToString();

			StringBuilder sb = new StringBuilder(_range);

			string firstIndexOffset = string.Empty;
			string lastIndexOffset = string.Empty;

			if (rangeEnum == SpreadSheetRangeEnum.Indexed)
			{
				firstIndexOffset = (FirstIndexOffset != int.MinValue) ? FirstIndexOffset.ToString() : string.Empty;
				lastIndexOffset = (LastIndexOffset != int.MinValue) ? LastIndexOffset.ToString() : string.Empty;
			}

			sb.Replace("{sheetName}", SheetName);
			sb.Replace("{rangeFirstColumn}", FirstColumn);
			sb.Replace("{firstIndexOffset}", firstIndexOffset);
			sb.Replace("{rangeLastColumn}", LastColumn);
			sb.Replace("{lastIndexOffset}", lastIndexOffset);

			return sb.ToString();
		}
	}
}