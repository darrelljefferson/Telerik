namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class DiagramConnectionDefaultsStartCapSettings : JsonObject
    {
        public DiagramConnectionDefaultsStartCapSettings()
        {
            //>> Initialization
        
            Fill = new DiagramConnectionDefaultsStartCapFillSettings();
                
            Stroke = new DiagramConnectionDefaultsStartCapStrokeSettings();
                
        //<< Initialization
        }

        //>> Fields
        
        public DiagramConnectionDefaultsStartCapFillSettings Fill
        {
            get;
            set;
        }
        
        public DiagramConnectionDefaultsStartCapStrokeSettings Stroke
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
