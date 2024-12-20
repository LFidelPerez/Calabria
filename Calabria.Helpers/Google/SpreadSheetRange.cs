﻿using System.Text;

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

		public SpreadSheetRange() { }

		public SpreadSheetRange(string sheetName, string firstColumn, string lastColumn, int firstIndexOffset)
		{
			_sheetName = sheetName;
			_firstColumn = firstColumn;
			_lastColumn = lastColumn;
			_firstIndexOffset = firstIndexOffset;
		}

		public SpreadSheetRange(string sheetName, string firstColumn, string lastColumn, int firstIndexOffset, int lastIndexOffset)
		{
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

			string firstIndexOffset = firstIndexOffset = (FirstIndexOffset != int.MinValue) ? FirstIndexOffset.ToString() : string.Empty;
			string lastIndexOffset = (LastIndexOffset != int.MinValue) ? LastIndexOffset.ToString() : string.Empty;

			sb.Replace("{sheetName}", SheetName);
			sb.Replace("{rangeFirstColumn}", FirstColumn);
			sb.Replace("{firstIndexOffset}", firstIndexOffset);
			sb.Replace("{rangeLastColumn}", LastColumn);
			sb.Replace("{lastIndexOffset}", lastIndexOffset);

			return sb.ToString();
		}
	}
}