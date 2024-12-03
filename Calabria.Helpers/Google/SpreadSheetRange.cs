using System.Text;

namespace Calabria.Helpers.Google
{
	public class SpreadSheetRange
	{
		/*
		private readonly string sheetName = "StockItems";
		private readonly string rangeFirstColumn = "A";
		private readonly string rangeLastColumn = "D";
		private readonly int indexOffset = 2;
		*/

		private readonly string range = "{sheetName}!{rangeFirstColumn}{firstIndexOffset}:{rangeLastColumn}{lastIndexOffset}";

		public string SheetName { get; set; } = string.Empty;
		public string FirstColumn { get; set; } = string.Empty;
		public string LastColumn { get; set; } = string.Empty;
		public int FirstIndexOffset { get; set; } = int.MinValue;
		public int LastIndexOffset { get; set; } = int.MinValue;


		public SpreadSheetRange() { }

		public SpreadSheetRange(string range, string sheetName, string firstColumn, string lastColumn, int firstIndexOffset, int lastIndexOffset)
		{
			this.range = range;
			SheetName = sheetName;
			FirstColumn = firstColumn;
			LastColumn = lastColumn;
			FirstIndexOffset = firstIndexOffset;
			LastIndexOffset = lastIndexOffset;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder(range);

			sb.Replace("{sheetName}", SheetName);
			sb.Replace("{rangeFirstColumn}", FirstColumn);
			sb.Replace("{indexOffset}", FirstIndexOffset.ToString());
			sb.Replace("{rangeLastColumn}", LastColumn);
			sb.Replace("{lastIndexOffset}", (LastIndexOffset != int.MinValue) ? LastIndexOffset.ToString() : string.Empty);

			return sb.ToString();
		}
	}
}