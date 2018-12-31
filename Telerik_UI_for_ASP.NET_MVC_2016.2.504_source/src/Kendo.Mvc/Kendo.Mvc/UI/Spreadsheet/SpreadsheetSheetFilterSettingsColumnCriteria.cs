namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class SpreadsheetSheetFilterSettingsColumnCriteria : JsonObject
    {        
        public string Operator { get; set; }
        
        public object Value { get; set; }     

        protected override void Serialize(IDictionary<string, object> json)
        {     
            if (Operator.HasValue())
            {
                json["operator"] = Operator;
            }
            
            if (Value != null)
            {
                json["value"] = Value;
            }                    
        }
    }
}
