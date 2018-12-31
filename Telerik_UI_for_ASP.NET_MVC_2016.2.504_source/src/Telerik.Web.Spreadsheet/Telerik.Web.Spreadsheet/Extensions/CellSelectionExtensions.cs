using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.Utilities;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Extensions for the Cells class
    /// </summary>
    public static class CellSelectionExtensions
    {
        /// <summary>
        /// Gets a cell selection from A1 reference
        /// </summary>
        /// <param name="cells">The cells collection</param>
        /// <param name="cellRangeRef">An A1 reference designating a rectangular area, e.g. "A1:B5"</param>
        /// <returns>A cell selection matching the referenced area</returns>
        public static CellSelection GetCellSelection(this Cells cells, string cellRangeRef)
        {
            var cellNames = cellRangeRef.Split(':');
            int row;
            int column;
            CellRange cellRange;

            if (cellNames.Length == 1)
            {
                NameConverter.ConvertCellNameToIndex(cellRangeRef, out row, out column);
                CellIndex index = new CellIndex(row, column);
                cellRange = new CellRange(index, index);
            }
            else
            {
                int row1 = 0;
                int column1 = 0;
                bool isRowAbsolute;
                bool isColumnAbsolute;
                bool isRowAbsolute1;
                bool isColumnAbsolute1;

                NameConverter.ConvertCellNameToIndex(cellNames[0], out isRowAbsolute, out row, out isColumnAbsolute, out column);
                NameConverter.ConvertCellNameToIndex(cellNames[1], out isRowAbsolute1, out row1, out isColumnAbsolute1, out column1);

                cellRange = new CellRange(new CellIndex(row, column), new CellIndex(row1, column1));
            }

            return cells[cellRange];
        }
    }
}
