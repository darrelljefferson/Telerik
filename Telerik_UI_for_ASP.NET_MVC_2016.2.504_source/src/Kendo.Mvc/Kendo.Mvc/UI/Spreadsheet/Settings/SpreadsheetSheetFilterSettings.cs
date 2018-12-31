namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class SpreadsheetSheetFilterSettings : JsonObject
    {
        public SpreadsheetSheetFilterSettings()
        {
            Columns = new List<SpreadsheetSheetFilterSettingsColumn>();

            //>> Initialization
        
        //<< Initialization
        }

        //>> Fields
        
        public string Ref { get; set; }
        
        //<< Fields

        public List<SpreadsheetSheetFilterSettingsColumn> Columns
        {
            get;
            set;
        }

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (Ref.HasValue())
            {
                json["ref"] = Ref;
            }
            
        //<< Serialization            

            // serlialize columns only when there is Ref
            if (Ref.HasValue())
            {
                json["columns"] = Columns.ToJson();
            }
            
        }
    }
}
