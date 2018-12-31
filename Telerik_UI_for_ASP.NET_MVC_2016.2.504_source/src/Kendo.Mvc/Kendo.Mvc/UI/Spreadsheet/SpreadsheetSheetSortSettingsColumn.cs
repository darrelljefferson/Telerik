namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class SpreadsheetSheetSortSettingsColumn : JsonObject
    {
        public SpreadsheetSheetSortSettingsColumn()
        {
            //>> Initialization
        
        //<< Initialization
        }

        //>> Fields
        
        public bool? Ascending { get; set; }
        
        public double? Index { get; set; }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (Ascending.HasValue)
            {
                json["ascending"] = Ascending;
            }
                
            if (Index.HasValue)
            {
                json["index"] = Index;
            }
                
        //<< Serialization
        }
    }
}
