namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class EditorSerializationSettings : JsonObject
    {
        public EditorSerializationSettings()
        {
            //>> Initialization
        
        //<< Initialization
        }

        //>> Fields
        
        public string Custom { get; set; }
        
        public bool? Entities { get; set; }
        
        public bool? Scripts { get; set; }
        
        public bool? Semantic { get; set; }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (Custom.HasValue())
            {
                json["custom"] = Custom;
            }
            
            if (Entities.HasValue)
            {
                json["entities"] = Entities;
            }
                
            if (Scripts.HasValue)
            {
                json["scripts"] = Scripts;
            }
                
            if (Semantic.HasValue)
            {
                json["semantic"] = Semantic;
            }
                
        //<< Serialization
        }
    }
}
