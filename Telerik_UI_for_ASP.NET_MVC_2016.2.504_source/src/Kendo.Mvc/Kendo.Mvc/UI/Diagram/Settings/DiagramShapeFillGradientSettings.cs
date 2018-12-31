namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class DiagramShapeFillGradientSettings : JsonObject
    {
        public DiagramShapeFillGradientSettings()
        {
            //>> Initialization
        
            Stops = new List<DiagramShapeFillGradientSettingsStop>();
                
        //<< Initialization
        }

        //>> Fields
        
        public string Type { get; set; }
        
        public double[] Center { get; set; }
        
        public double? Radius { get; set; }
        
        public double[] Start { get; set; }
        
        public double[] End { get; set; }
        
        public List<DiagramShapeFillGradientSettingsStop> Stops
        {
            get;
            set;
        }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (Type.HasValue())
            {
                json["type"] = Type;
            }
            
            if (Center != null)
            {
                json["center"] = Center;
            }
            
            if (Radius.HasValue)
            {
                json["radius"] = Radius;
            }
                
            if (Start != null)
            {
                json["start"] = Start;
            }
            
            if (End != null)
            {
                json["end"] = End;
            }
            
            var stops = Stops.ToJson();
            if (stops.Any())
            {
                json["stops"] = stops;
            }
        //<< Serialization
        }
    }
}
