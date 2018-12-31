using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Represents a Worksheet
    /// </summary>
    public partial class Worksheet
    {
        /// <summary>
        /// Adds rows to the worksheet.
        /// </summary>
        /// <param name="rows">The rows to add</param>
        public void AddRows(IEnumerable<Row> rows)
        {
            if (Rows == null)
            {
                Rows = new List<Row>();
            }

            Rows.AddRange(rows);
        }

        /// <summary>
        /// Adds a row to the worksheet.
        /// </summary>
        /// <param name="row">The row to add</param>
        public void AddRow(Row row)
        {
            AddRows(new[] { row });
        }

        /// <summary>
        /// Adds a merged range to the worksheet.
        /// </summary>
        /// <param name="range">The merged range, e.g. "A1:B4"</param>
        public void AddMergedCells(string range)
        {
            var merged = MergedCells.GetOrDefault();

            merged.Add(range);

            MergedCells = merged;
        }

        internal Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            return settings;
        }
    }
}

