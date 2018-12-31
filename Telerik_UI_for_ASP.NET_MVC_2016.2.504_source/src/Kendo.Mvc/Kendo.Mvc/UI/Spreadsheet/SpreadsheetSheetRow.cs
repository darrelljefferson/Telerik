namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class SpreadsheetSheetRow : JsonObject
    {
        public SpreadsheetSheetRow()
        {
            //>> Initialization
        
            Cells = new List<SpreadsheetSheetRowCell>();
                
        //<< Initialization
        }

        //>> Fields
        
        public List<SpreadsheetSheetRowCell> Cells
        {
            get;
            set;
        }
        
        public double? Height { get; set; }
        
        public int? Index { get; set; }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            var cells = Cells.ToJson();
            if (cells.Any())
            {
                json["cells"] = cells;
            }
            if (Height.HasValue)
            {
                json["height"] = Height;
            }
                
            if (Index.HasValue)
            {
                json["index"] = Index;
            }
                
        //<< Serialization
        }
    }
}
