namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class EditorDeserializationSettings : JsonObject
    {
        public EditorDeserializationSettings()
        {
            //>> Initialization
        
        //<< Initialization
        }

        //>> Fields
        
        public string Custom { get; set; }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (Custom.HasValue())
            {
                json["custom"] = Custom;
            }
            
        //<< Serialization
        }
    }
}
