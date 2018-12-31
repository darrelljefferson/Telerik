namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class DiagramEditableDragSnapSettings : JsonObject
    {
        public DiagramEditableDragSnapSettings()
        {
            Enabled = true;
        
            //>> Initialization
        
        //<< Initialization
        }

        public bool Enabled { get; set; }

        //>> Fields
        
        public double? Size { get; set; }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (Size.HasValue)
            {
                json["size"] = Size;
            }
                
        //<< Serialization
        }
    }
}
