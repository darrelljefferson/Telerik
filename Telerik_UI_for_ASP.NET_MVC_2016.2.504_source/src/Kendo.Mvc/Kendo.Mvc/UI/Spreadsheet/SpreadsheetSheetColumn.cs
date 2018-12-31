namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class SpreadsheetSheetColumn : JsonObject
    {
        public SpreadsheetSheetColumn()
        {
            //>> Initialization
        
        //<< Initialization
        }

        //>> Fields
        
        public int? Index { get; set; }
        
        public double? Width { get; set; }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (Index.HasValue)
            {
                json["index"] = Index;
            }
                
            if (Width.HasValue)
            {
                json["width"] = Width;
            }
                
        //<< Serialization
        }
    }
}
