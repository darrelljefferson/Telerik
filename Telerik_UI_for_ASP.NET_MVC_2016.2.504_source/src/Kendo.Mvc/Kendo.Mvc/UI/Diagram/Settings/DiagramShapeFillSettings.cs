namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class DiagramShapeFillSettings : JsonObject
    {
        public DiagramShapeFillSettings()
        {
            //>> Initialization
        
            Gradient = new DiagramShapeFillGradientSettings();
                
        //<< Initialization
        }

        //>> Fields
        
        public string Color { get; set; }
        
        public double? Opacity { get; set; }
        
        public DiagramShapeFillGradientSettings Gradient
        {
            get;
            set;
        }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (Color.HasValue())
            {
                json["color"] = Color;
            }
            
            if (Opacity.HasValue)
            {
                json["opacity"] = Opacity;
            }
                
            var gradient = Gradient.ToJson();
            if (gradient.Any())
            {
                json["gradient"] = gradient;
            }
        //<< Serialization
        }
    }
}
