namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class DiagramShapeDefaultsFillGradientSettingsStop : JsonObject
    {
        public DiagramShapeDefaultsFillGradientSettingsStop()
        {
            //>> Initialization
        
        //<< Initialization
        }

        //>> Fields
        
        public double? Offset { get; set; }
        
        public string Color { get; set; }
        
        public double? Opacity { get; set; }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (Offset.HasValue)
            {
                json["offset"] = Offset;
            }
                
            if (Color.HasValue())
            {
                json["color"] = Color;
            }
            
            if (Opacity.HasValue)
            {
                json["opacity"] = Opacity;
            }
                
        //<< Serialization
        }
    }
}
