namespace Kendo.Mvc.UI
{
    using System.Collections.Generic;
    using Kendo.Mvc.Extensions;
    using System.Linq;

    public class DiagramHoverSettings : JsonObject
    {
        public DiagramHoverSettings()
        {
            Fill = new DiagramFillSettings();
            Stroke = new DiagramStrokeSettings();
        }

        public DiagramFillSettings Fill
        {
            get;
            set;
        }

        public DiagramStrokeSettings Stroke
        {
            get;
            set;
        }

        protected override void Serialize(IDictionary<string, object> json)
        {
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
        }
    }
}
