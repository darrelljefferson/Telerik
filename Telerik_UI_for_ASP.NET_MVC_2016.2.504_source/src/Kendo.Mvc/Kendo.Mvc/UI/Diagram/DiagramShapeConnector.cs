namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class DiagramShapeConnector : JsonObject
    {
        public DiagramShapeConnector()
        {
            Fill = new DiagramFillSettings();
            Stroke = new DiagramStrokeSettings();
            Hover = new DiagramHoverSettings();
        }
        
        public string Description { get; set; }
        
        public string Name { get; set; }

        public double? Width { get; set; }

        public double? Height { get; set; }

        public DiagramFillSettings Fill { get; set; }

        public DiagramStrokeSettings Stroke { get; set; }

        public DiagramHoverSettings Hover { get; set; }
        
        public ClientHandlerDescriptor Position { get; set; }

        protected override void Serialize(IDictionary<string, object> json)
        {
            if (Description.HasValue())
            {
                json["description"] = Description;
            }
            
            if (Name.HasValue())
            {
                json["name"] = Name;
            }
            
            if (Position != null)
            {
                json["position"] = Position;
            }

            if (Width.HasValue)
            {
                json["width"] = Width;
            }

            if (Height.HasValue)
            {
                json["height"] = Height;
            }

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

            var hover = Hover.ToJson();
            if (hover.Any())
            {
                json["hover"] = hover;
            }
        }
    }
}
