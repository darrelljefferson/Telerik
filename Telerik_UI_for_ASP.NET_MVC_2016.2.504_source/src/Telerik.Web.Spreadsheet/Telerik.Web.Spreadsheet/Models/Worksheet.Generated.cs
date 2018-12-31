using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Represents a Worksheet
    /// </summary>
    [DataContract]
    public partial class Worksheet
    {
        /// <summary>
        /// The active cell in the sheet, e.g. "A1".
        /// </summary>
        [DataMember(Name = "activeCell", EmitDefaultValue = false)]
        public string ActiveCell { get; set; }

        /// <summary>
        /// The name of the sheet.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// An array defining the columns in this sheet and their content.
        /// </summary>
        [DataMember(Name = "columns", EmitDefaultValue = false)]
        public List<Column> Columns
        {
            get;
            set;
        }

        /// <summary>
        /// Defines the filtering criteria for this sheet, if any.
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = false)]
        public Filter Filter
        {
            get;
            set;
        }

        /// <summary>
        /// The number of frozen columns in this sheet.
        /// </summary>
        [DataMember(Name = "frozenColumns", EmitDefaultValue = false)]
        public int? FrozenColumns { get; set; }

        /// <summary>
        /// The number of frozen rows in this sheet.
        /// </summary>
        [DataMember(Name = "frozenRows", EmitDefaultValue = false)]
        public int? FrozenRows { get; set; }

        /// <summary>
        /// The row data for this sheet.
        /// </summary>
        [DataMember(Name = "rows", EmitDefaultValue = false)]
        public List<Row> Rows
        {
            get;
            set;
        }

        /// <summary>
        /// The selected range in the sheet, e.g. "A1:B10".
        /// </summary>
        [DataMember(Name = "selection", EmitDefaultValue = false)]
        public string Selection { get; set; }

        /// <summary>
        /// Defines the sort criteria for the sheet.
        /// </summary>
        [DataMember(Name = "sort", EmitDefaultValue = false)]
        public Sort Sort
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "mergedCells", EmitDefaultValue = false)]
        public List<string> MergedCells
        {
            get;
            set;
        }


        /// <summary>
        /// Serialize current instance to Dictionary
        /// </summary>
        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (ActiveCell != null)
            {
                settings["activeCell"] = ActiveCell;
            }

            if (Name != null)
            {
                settings["name"] = Name;
            }

            if (Columns != null)
            {
                settings["columns"] = Columns.Select(item => item.Serialize());
            }

            if (Filter != null)
            {
                settings["filter"] = Filter.Serialize();
            }

            if (FrozenColumns != null)
            {
                settings["frozenColumns"] = FrozenColumns;
            }

            if (FrozenRows != null)
            {
                settings["frozenRows"] = FrozenRows;
            }

            if (Rows != null)
            {
                settings["rows"] = Rows.Select(item => item.Serialize());
            }

            if (Selection != null)
            {
                settings["selection"] = Selection;
            }

            if (Sort != null)
            {
                settings["sort"] = Sort.Serialize();
            }

            if (MergedCells != null)
            {
                settings["mergedCells"] = MergedCells;
            }

            return settings;
        }
    }
}
