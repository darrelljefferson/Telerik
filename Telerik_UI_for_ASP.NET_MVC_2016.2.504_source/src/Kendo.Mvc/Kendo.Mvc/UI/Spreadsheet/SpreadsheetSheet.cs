namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class SpreadsheetSheet : JsonObject
    {
        public SpreadsheetSheet()
        {
            //>> Initialization
        
            Columns = new List<SpreadsheetSheetColumn>();
                
            Filter = new SpreadsheetSheetFilterSettings();
                
            Rows = new List<SpreadsheetSheetRow>();
                
            Sort = new SpreadsheetSheetSortSettings();
                
        //<< Initialization
        }

        //>> Fields
        
        public string ActiveCell { get; set; }
        
        public string Name { get; set; }
        
        public List<SpreadsheetSheetColumn> Columns
        {
            get;
            set;
        }
        
        public SpreadsheetSheetFilterSettings Filter
        {
            get;
            set;
        }
        
        public int? FrozenColumns { get; set; }
        
        public int? FrozenRows { get; set; }
        
        public string[] MergedCells { get; set; }
        
        public List<SpreadsheetSheetRow> Rows
        {
            get;
            set;
        }
        
        public string Selection { get; set; }
        
        public bool? ShowGridLines { get; set; }
        
        public SpreadsheetSheetSortSettings Sort
        {
            get;
            set;
        }
        
        //<< Fields

        public DataSource DataSource
        {
            get;
            set;
        }

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (ActiveCell.HasValue())
            {
                json["activeCell"] = ActiveCell;
            }
            
            if (Name.HasValue())
            {
                json["name"] = Name;
            }
            
            var columns = Columns.ToJson();
            if (columns.Any())
            {
                json["columns"] = columns;
            }
            var filter = Filter.ToJson();
            if (filter.Any())
            {
                json["filter"] = filter;
            }
            if (FrozenColumns.HasValue)
            {
                json["frozenColumns"] = FrozenColumns;
            }
                
            if (FrozenRows.HasValue)
            {
                json["frozenRows"] = FrozenRows;
            }
                
            if (MergedCells != null)
            {
                json["mergedCells"] = MergedCells;
            }
            
            var rows = Rows.ToJson();
            if (rows.Any())
            {
                json["rows"] = rows;
            }
            if (Selection.HasValue())
            {
                json["selection"] = Selection;
            }
            
            if (ShowGridLines.HasValue)
            {
                json["showGridLines"] = ShowGridLines;
            }
                
            var sort = Sort.ToJson();
            if (sort.Any())
            {
                json["sort"] = sort;
            }
        //<< Serialization

            if (DataSource != null)
            {
                json["dataSource"] = DataSource.ToJson();
            }
        }
    }
}
