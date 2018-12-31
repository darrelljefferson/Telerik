namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class SpreadsheetSheetSortSettings : JsonObject
    {
        public SpreadsheetSheetSortSettings()
        {
            //>> Initialization
        
            Columns = new List<SpreadsheetSheetSortSettingsColumn>();
                
        //<< Initialization
        }

        //>> Fields
        
        public List<SpreadsheetSheetSortSettingsColumn> Columns
        {
            get;
            set;
        }
        
        public string Ref { get; set; }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            var columns = Columns.ToJson();
            if (columns.Any())
            {
                json["columns"] = columns;
            }
            if (Ref.HasValue())
            {
                json["ref"] = Ref;
            }
            
        //<< Serialization
        }
    }
}
