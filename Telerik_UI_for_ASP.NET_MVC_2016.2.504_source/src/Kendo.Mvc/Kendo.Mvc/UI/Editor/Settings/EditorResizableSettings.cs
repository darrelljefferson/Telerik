namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class EditorResizableSettings : JsonObject
    {
        public EditorResizableSettings()
        {
            Enabled = false;
        
            //>> Initialization
        
        //<< Initialization
        }

        public bool Enabled { get; set; }

        //>> Fields
        
        public bool? Content { get; set; }
        
        public double? Min { get; set; }
        
        public double? Max { get; set; }
        
        public bool? Toolbar { get; set; }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (Content.HasValue)
            {
                json["content"] = Content;
            }
                
            if (Min.HasValue)
            {
                json["min"] = Min;
            }
                
            if (Max.HasValue)
            {
                json["max"] = Max;
            }
                
            if (Toolbar.HasValue)
            {
                json["toolbar"] = Toolbar;
            }
                
        //<< Serialization
        }
    }
}
