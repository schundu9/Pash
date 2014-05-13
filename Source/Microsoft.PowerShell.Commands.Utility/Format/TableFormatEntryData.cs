using System;
using System.Collections.Generic;

namespace Microsoft.PowerShell.Commands.Utility
{
    internal class TableFormatEntryData : FormatEntryData
    {
        public List<TableCellEntry> Row { get; set; }
        public bool Wrap { get; set; }
        public bool ShowHeader { get; set; }

        internal TableFormatEntryData(List<TableCellEntry> row) : base(FormatShape.Table)
        {
            Row = row;
        }

        internal TableFormatEntryData(TableFormatEntryData entry) : base(entry)
        {
            Row = entry.Row;
            Wrap = entry.Wrap;
            ShowHeader = entry.ShowHeader;
        }
    }
}

