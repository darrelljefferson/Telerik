namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class SpreadsheetSheetFilterSettingsColumn : JsonObject
    {
        public SpreadsheetSheetFilterSettingsColumn()
        {
            //>> Initialization
        
            Criteria = new List<SpreadsheetSheetFilterSettingsColumnCriteria>();
                
        //<< Initialization
        }

        //>> Fields
        
        public List<SpreadsheetSheetFilterSettingsColumnCriteria> Criteria
        {
            get;
            set;
        }
        
        public string Filter { get; set; }
        
        public double? Index { get; set; }
        
        public string Logic { get; set; }
        
        public string Type { get; set; }
        
        public double? Value { get; set; }
        
        public object[] Values { get; set; }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            var criteria = Criteria.ToJson();
            if (criteria.Any())
            {
                json["criteria"] = criteria;
            }
            if (Filter.HasValue())
            {
                json["filter"] = Filter;
            }
            
            if (Index.HasValue)
            {
                json["index"] = Index;
            }
                
            if (Logic.HasValue())
            {
                json["logic"] = Logic;
            }
            
            if (Type.HasValue())
            {
                json["type"] = Type;
            }
            
            if (Value.HasValue)
            {
                json["value"] = Value;
            }
                
            if (Values != null)
            {
                json["values"] = Values;
            }
            
        //<< Serialization
        }
    }
}
