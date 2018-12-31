namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class DiagramConnectionEndCapSettings : JsonObject
    {
        public DiagramConnectionEndCapSettings()
        {
            //>> Initialization
        
            Fill = new DiagramConnectionEndCapFillSettings();
                
            Stroke = new DiagramConnectionEndCapStrokeSettings();
                
        //<< Initialization
        }

        //>> Fields
        
        public DiagramConnectionEndCapFillSettings Fill
        {
            get;
            set;
        }
        
        public DiagramConnectionEndCapStrokeSettings Stroke
        {
            get;
            set;
        }
        
        public string Type { get; set; }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            var fill = Fill.ToJson();
            if (fill.Any())
            {
                json["fill"] = fill;
            }
            var stroke = Stroke.ToJson();
            if (stroke.Any())
            {
                json["stroke"] = stroke;
            }
            if (Type.HasValue())
            {
                json["type"] = Type;
            }
            
        //<< Serialization
        }
    }
}
