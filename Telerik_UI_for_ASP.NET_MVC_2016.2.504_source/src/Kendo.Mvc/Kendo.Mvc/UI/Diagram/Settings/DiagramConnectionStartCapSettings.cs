namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class DiagramConnectionStartCapSettings : JsonObject
    {
        public DiagramConnectionStartCapSettings()
        {
            //>> Initialization
        
            Fill = new DiagramConnectionStartCapFillSettings();
                
            Stroke = new DiagramConnectionStartCapStrokeSettings();
                
        //<< Initialization
        }

        //>> Fields
        
        public DiagramConnectionStartCapFillSettings Fill
        {
            get;
            set;
        }
        
        public DiagramConnectionStartCapStrokeSettings Stroke
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
