using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Represents a Row
    /// </summary>
    public partial class Row
    {
        /// <summary>
        /// Adds the cells to the row
        /// </summary>
        /// <param name="cells">The cells to add</param>
        public void AddCells(IEnumerable<Cell> cells)
        {
            if (Cells == null)
            {
                Cells = new List<Cell>();
            }

            Cells.AddRange(cells);
        }

        /// <summary>
        /// Adds a cell to the row
        /// </summary>
        /// <param name="cell">The cell to add</param>
        public void AddCell(Cell cell)
        {
            AddCells(new[] { cell });
        }

        internal Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            return settings;
        }
    }
}

